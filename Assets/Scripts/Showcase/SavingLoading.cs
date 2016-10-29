using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Linq.Expressions;
using System.Linq;
using System.Text;
using System.Reflection;

public class SavingLoading : MonoBehaviour
{
	Dictionary<int, Object> loadedObjects = new Dictionary<int, Object> ();

	public void Loaded (Object obj, int refId)
	{
		loadedObjects.Add (refId, obj);
	}

	List<Object> savedObjects = new List<Object> ();
	Dictionary<Object, int> objectToRef = new Dictionary<Object, int> ();
	Dictionary<System.Type, ISerializer> serializers = new Dictionary<System.Type, ISerializer> ();

	public bool IsLoading = true;

	public string SaveFilePath;

	void Awake ()
	{
		var allObjects = FindObjectsOfType<GameObject> ();
		foreach (var obj in allObjects)
		{
			obj.AddComponent<NonSerializable> ();

		}
		serializers.Add (typeof(GameObject), new GameobjectSerializer ());
	}

	List<ObjectSerializer.ResolveReferenceRequest> refRequests = new List<ObjectSerializer.ResolveReferenceRequest> ();

	public void Load ()
	{
        listRequests.Clear();
        refRequests.Clear ();
		loadedObjects.Clear ();
		TextReader textReader = new StreamReader (SaveFilePath);
		JsonReader jsonReader = new JsonTextReader (textReader);
		JObject saveFileObject = JObject.Load (jsonReader);
		var engine = FindObjectOfType<BasicLoader> ().Engine;
		foreach (var child in saveFileObject)
		{
			int refId = int.Parse (child.Key);
			JObject objData = child.Value as JObject;
			ISerializer srz = serializers [typeof(GameObject)];
			GameObject go = new GameObject ();

			srz.Deserialize (go, objData);
			Loaded (go, refId);
		}
		foreach (var refRequest in refRequests)
		{
			if (refRequest.RefID == "null")
				continue;
			int refID = 0;
			if (int.TryParse (refRequest.RefID, out refID))
			{
				Object resolvedRef = null;
				loadedObjects.TryGetValue (refID, out resolvedRef);
				refRequest.ResolveLambda (refRequest.Target, resolvedRef);
			} else
			{
				if (refRequest.CmpType == typeof(GameObject))
					refRequest.ResolveLambda (refRequest.Target, GameObject.Find (refRequest.RefID));
				else
					refRequest.ResolveLambda (refRequest.Target, GameObject.Find (refRequest.RefID).GetComponent (refRequest.CmpType));
			}
		}

        foreach (var listRequest in listRequests)
        {
            foreach (var id in listRequest.IDs)
            {
                int refIntID = 0;
                UnityEngine.Object resolvedObject = null;
                var refID = id.ToString();
                if (refID == "null")
                    listRequest.TargetList.Add(null);
                else if (int.TryParse(refID, out refIntID) && loadedObjects.TryGetValue(refIntID, out resolvedObject))
                    listRequest.TargetList.Add(resolvedObject);
                else
                    listRequest.TargetList.Add(GameObject.Find(refID));
            }
        }
	}

	int nextId = 0;

	public void Save ()
	{
		JObject saveFileObject = new JObject ();

		savedObjects.Clear ();
		var allObjects = from obj in FindObjectsOfType<GameObject> ()
		                 where obj.GetComponent<NonSerializable> () == null && obj.GetComponentInParent<NonSerializable> () == null
		                 select obj as Object;
		savedObjects.AddRange (allObjects);
		foreach (var obj in savedObjects)
		{
			var token = Serialize (obj);
			int refId = 0;
			if (!objectToRef.TryGetValue (obj, out refId))
			{
				refId = nextId++;
				objectToRef.Add (obj, refId);
			}
			saveFileObject.Add (refId.ToString (), token);
		}

		TextWriter textWriter = new StreamWriter (SaveFilePath);
		JsonWriter jsonWriter = new JsonTextWriter (textWriter);
		saveFileObject.WriteTo (jsonWriter);
		jsonWriter.Close ();
		textWriter.Close ();

	}

	public JToken Serialize (Object obj)
	{
		ISerializer srz = null;
		var objType = obj.GetType ();
		if (!serializers.TryGetValue (objType, out srz))
		{
			srz = new ObjectSerializer (objType);
			serializers.Add (objType, srz);
		}
		return srz.Serialize (obj);

	}

	public void PostResolveRequest (ObjectSerializer.ResolveReferenceRequest request)
	{
		refRequests.Add (request);
	}

	public int SetAsRef (Object obj)
	{
		if (obj == null)
			return -1;
		if (objectToRef.ContainsKey (obj))
			return objectToRef [obj];
		int refId = nextId++;
		objectToRef.Add (obj, refId);
		return refId;
	}

	public string SaveAsRef (Object obj)
	{
		if (obj == null)
			return "null";
		if (obj is GameObject)
		{
			if ((obj as GameObject).GetComponent<NonSerializable> () != null)
				return (obj as GameObject).name;
		} else if (obj is MonoBehaviour)
		{
			if ((obj as MonoBehaviour).GetComponent<NonSerializable> () != null)
				return (obj as MonoBehaviour).name;
		}
		if (objectToRef.ContainsKey (obj))
			return objectToRef [obj].ToString ();
		int refId = nextId++;
		objectToRef.Add (obj, refId);
		return refId.ToString ();
	}

	public ISerializer GetSerializer (System.Type type)
	{
		ISerializer ser = null;
		serializers.TryGetValue (type, out ser);
		if (ser == null)
		{

			ser = new ObjectSerializer (type);
			serializers.Add (type, ser);
		}
		return ser;
	}
    List<ResolveListRequest> listRequests = new List<ResolveListRequest>();
    public void PostResolveListRequest(ResolveListRequest request)
    {
        listRequests.Add(request);
    }
}

public interface ISerializer
{
	void Deserialize (Object obj, JObject data);

	JObject Serialize (Object obj);
}

public class ObjectSerializer : ISerializer
{
	static ScriptEngine engine;
	static SavingLoading savingLoading;
	System.Type type;

	public ObjectSerializer (System.Type type)
	{
		
		if (engine == null)
			engine = Object.FindObjectOfType<BasicLoader> ().Engine;
		if (savingLoading == null)
			savingLoading = Object.FindObjectOfType<SavingLoading> ();
		InitByType (type);
	}

	public delegate void TargetNodeDelegate (Object target, JObject node);


	public delegate void ResolveReference (Object target, Object resolvedRef);

	public class ResolveReferenceRequest
	{
		public Object Target;
		public string RefID;
		public ResolveReference ResolveLambda;
		public System.Type CmpType;

		public ResolveReferenceRequest (Object target, string refId, ResolveReference resolveLambda, System.Type cmpType)
		{
			Target = target;
			RefID = refId;
			ResolveLambda = resolveLambda;
			CmpType = cmpType;
		}

		public void Resolve (Object resolvedRef)
		{
			ResolveLambda (Target, resolvedRef);
		}
	}

	public ObjectSerializer (string typeName)
	{
		
		if (engine == null)
			engine = Object.FindObjectOfType<BasicLoader> ().Engine;
		if (savingLoading == null)
			savingLoading = Object.FindObjectOfType<SavingLoading> ();
		var type = engine.FindType (typeName);
		InitByType (type);
		
	}

	List<TargetNodeDelegate> loadingDelegates;
	List<TargetNodeDelegate> savingDelegates;

	JValue LogValueType (JValue v)
	{
		Debug.Log (v.Value.GetType ());
		return v;
	}

	void InitByType (System.Type type)
	{
		this.type = type;
		StringBuilder debugBuilder = new StringBuilder ();

		debugBuilder.AppendLine (type.Name);
		var flags = BindingFlags.DeclaredOnly | BindingFlags.Public | BindingFlags.Instance;
		var props = type.GetProperties (flags);
		var targetArg = Expression.Parameter (typeof(Object), "target");
		var nodeArg = Expression.Parameter (typeof(JObject), "node");
		var convertTargetArg = Expression.Convert (targetArg, type);
		//loading
		loadingDelegates = new List<TargetNodeDelegate> ();
		savingDelegates = new List<TargetNodeDelegate> ();
		foreach (var prop in props)
		{
			if (!prop.CanWrite)
				continue;
			Expression exprBody = null;

			if (!prop.PropertyType.IsSubclassOf (typeof(UnityEngine.Object)))
			{
				//load directly
				Expression nodeGetValue = null;
				if (prop.PropertyType == typeof(string) || prop.PropertyType == typeof(float) ||
				    prop.PropertyType == typeof(bool) || prop.PropertyType == typeof(int))
				{
					Debug.LogFormat ("{0} - {1} primitive", type, prop);
					var getValueMethod = typeof(JObject).GetMethod ("GetValue", new System.Type[]{ typeof(string) });
					var call = Expression.Call (nodeArg, getValueMethod, Expression.Constant (prop.Name, typeof(string)));
					var convert = Expression.Convert (Expression.TypeAs (call, typeof(JValue)), prop.PropertyType);
					nodeGetValue = convert;

				} else
				{
					Debug.LogFormat ("{0} - {1} object", type, prop);
					var getValueMethod = typeof(JObject).GetMethod ("GetValue", new System.Type[]{ typeof(string) });
					var getValueCall = Expression.Call (nodeArg, getValueMethod, Expression.Constant (prop.Name, typeof(string)));
					var toObjectMethod = typeof(JToken).GetMethod ("ToObject", new [] { typeof(System.Type) });
					var toObjectCall = Expression.Call (getValueCall, toObjectMethod, Expression.Constant (prop.PropertyType, typeof(System.Type)));
					var convert = Expression.Convert (toObjectCall, prop.PropertyType);
					nodeGetValue = convert;
				}

				var setMethod = prop.GetSetMethod ();
				if (setMethod == null)
					continue;
				var assignProp = Expression.Call (convertTargetArg, setMethod, nodeGetValue);
				exprBody = assignProp;
			} else
			{
				//load indirectly
				Debug.LogFormat ("{0} - {1} ref", type, prop);
				var refArg = Expression.Parameter (typeof(Object), "ref");
				var convertRefArg = Expression.Convert (refArg, prop.PropertyType);
				var setMethod = prop.GetSetMethod ();
				if (setMethod == null)
					continue;
				var assignProp = Expression.Call (convertTargetArg, setMethod, convertRefArg);

				var resolveLambda = Expression.Lambda<ResolveReference> (assignProp, targetArg, refArg).Compile ();

				var parseMethod = typeof(int).GetMethod ("Parse", new System.Type[]{ typeof(string) });
				var getValueMethod = typeof(JObject).GetMethod ("GetValue", new System.Type[]{ typeof(string) });
				var getValueCall = Expression.Call (nodeArg, getValueMethod, Expression.Constant (prop.Name, typeof(string)));
				var convert = Expression.Convert (Expression.Property (Expression.Convert (getValueCall, typeof(JValue)), "Value"), typeof(string));

				var ctor = typeof(ResolveReferenceRequest).GetConstructor (new System.Type[] {
					typeof(UnityEngine.Object),
					typeof(string),
					typeof(ResolveReference),
					typeof(System.Type)
				});
				var createRequest = Expression.New (ctor, new Expression[] {
					targetArg,
					convert,
					Expression.Constant (resolveLambda),
					Expression.Constant (prop.PropertyType, typeof(System.Type))
				});

				var postRequest = Expression.Call (Expression.Constant (savingLoading), typeof(SavingLoading).GetMethod ("PostResolveRequest"), createRequest);
				exprBody = postRequest;
			}

			var loadLambda = Expression.Lambda<TargetNodeDelegate> (exprBody, targetArg, nodeArg);
			var loadCall = loadLambda.Compile ();
			loadingDelegates.Add (loadCall);

		}


		//saving
	
		foreach (var prop in props)
		{
			if (!prop.CanWrite)
				continue;
			debugBuilder.AppendLine (prop.Name);
			Expression exprBody = null;

			if (!prop.PropertyType.IsSubclassOf (typeof(UnityEngine.Object)))
			{
				Debug.LogWarning ("as direct prop " + prop.Name, savingLoading);
				var fromObjectMethod = typeof(JToken).GetMethod ("FromObject", new System.Type[] { typeof(System.Object) });
				Expression nodeGetValue = null;
				if (prop.PropertyType == typeof(string) || prop.PropertyType == typeof(float) ||
				    prop.PropertyType == typeof(bool) || prop.PropertyType == typeof(int))
				{
					Debug.LogWarningFormat ("{0} - {1} as primitive", type.Name, prop.Name);
					if (prop.PropertyType != typeof(float))
						nodeGetValue = Expression.Convert (Expression.Call (convertTargetArg, prop.GetGetMethod ()), typeof(JToken));
					else
					{
						var jvalueCtor = typeof(JValue).GetConstructor (new System.Type[]{ typeof(float) });
						var newFloat = Expression.New (jvalueCtor, Expression.Call (convertTargetArg, prop.GetGetMethod ()));
						nodeGetValue = Expression.Convert (newFloat, typeof(JToken));

					}
						
				} else
					nodeGetValue = Expression.Call (fromObjectMethod, Expression.Call (convertTargetArg, prop.GetGetMethod ()));
				var addToNode = Expression.Call (nodeArg, typeof(JObject).GetMethod ("Add", new System.Type[] {
					typeof(string),
					typeof(JToken)
				}), Expression.Constant (prop.Name, typeof(string)), nodeGetValue);
				exprBody = addToNode;
			} else
			{
				//По идее тут он должен будет разместить id
				//а сериализовать потом

				Debug.LogWarning ("as ref prop " + prop.Name, savingLoading);
				Debug.Log (savingLoading);
				var postId = Expression.Call (Expression.Constant (savingLoading, typeof(SavingLoading)), typeof(SavingLoading).GetMethod ("SaveAsRef"), Expression.Call (convertTargetArg, prop.GetGetMethod ()));
				var addToNode = Expression.Call (nodeArg, typeof(JObject).GetMethod ("Add", new System.Type[] {
					typeof(string),
					typeof(JToken)
				}), Expression.Constant (prop.Name, typeof(string)), Expression.Convert (postId, typeof(JToken)));
				exprBody = addToNode;
			}
			var saveLambda = Expression.Lambda<TargetNodeDelegate> (exprBody, targetArg, nodeArg);
			try
			{
				var saveCall = saveLambda.Compile ();
				savingDelegates.Add (saveCall);
			} catch (System.Exception e)
			{
				Debug.LogWarningFormat ("{0} - {1}", type.Name, prop.Name);
				throw e;
			}

		}

		Debug.Log (debugBuilder);
	}

	public void Deserialize (Object obj, JObject data)
	{
		foreach (var loadLambda in loadingDelegates)
			loadLambda (obj, data);
	

	}

	public JObject Serialize (Object obj)
	{
		JObject jObj = new JObject ();
		jObj.Add ("type", type.FullName);
		foreach (var saveLambda in savingDelegates)
			saveLambda (obj, jObj);
		return jObj;
	}
}

public class GameobjectSerializer : ISerializer
{
	SavingLoading savingLoading;
	ScriptEngine engine;

	public GameobjectSerializer ()
	{
		engine = Object.FindObjectOfType<BasicLoader> ().Engine;
		savingLoading = Object.FindObjectOfType<SavingLoading> ();
	}

	public void Deserialize (Object obj, JObject data)
	{
		GameObject go = obj as GameObject;
		go.name = (data ["name"] as JValue).Value as string;
		foreach (var childPair in data)
		{
			int refId = 0;
			if (int.TryParse (childPair.Key, out refId))
			{
				var cmpData = childPair.Value as JObject;
				//it's a component! We need to instantiate it. But first - find the type
				var typeName = (cmpData ["type"] as JValue).Value as string;
				var type = engine.FindType (typeName);
				var cmp = go.AddComponent (type);
				var ser = savingLoading.GetSerializer (type);

				savingLoading.Loaded (cmp, refId);
				ser.Deserialize (cmp, cmpData);
			} 
		}
	}

	List<MonoBehaviour> components = new List<MonoBehaviour> ();

	public JObject Serialize (Object obj)
	{
		GameObject go = obj as GameObject;
		components.Clear ();
		go.GetComponents<MonoBehaviour> (components);

		JObject goObject = new JObject ();
		goObject.Add ("type", typeof(GameObject).FullName);
		goObject.Add ("name", go.name);
		for (int i = 0; i < components.Count; i++)
		{
			var cmp = components [i];
			var ser = savingLoading.GetSerializer (cmp.GetType ());
			var cmpObject = ser.Serialize (cmp);
			goObject.Add (savingLoading.SetAsRef (cmp).ToString (), cmpObject);
		}

//		var tSer = savingLoading.GetSerializer (typeof(Transform));
//		var tObject = tSer.Serialize (go.transform);
//		goObject.Add (savingLoading.SetAsRef (go.transform).ToString (), tObject);
		return goObject;
	}
}


public class NonSerializable : MonoBehaviour
{
	
}


public class ObjectRefConverter : JsonConverter
{

    SavingLoading loader;
    public ObjectRefConverter(SavingLoading loader)
    {
        this.loader = loader;
    }
    public override bool CanConvert(System.Type objectType)
    {
        var isGenericList = objectType.IsGenericType && objectType.GetGenericTypeDefinition() == typeof(List<>);
        if(isGenericList)
        {
            var contentIsUnityObject = objectType.GetGenericArguments()[0].IsSubclassOf(typeof(UnityEngine.Object));
            if (contentIsUnityObject)
                return true;
        }
        return false;
    }

    public override System.Object ReadJson(JsonReader reader, System.Type objectType, System.Object existingValue, JsonSerializer serializer)
    {
        IList list = System.Activator.CreateInstance(objectType) as IList;
        JArray arrayList = JArray.Load(reader);
        ResolveListRequest request = new ResolveListRequest();
        request.TargetList = list;
        request.IDs = arrayList;
        return list;
    }

    public override void WriteJson(JsonWriter writer, System.Object value, JsonSerializer serializer)
    {
        IList list = value as IList;
        JArray arrayList = new JArray();
        foreach ( var val in list)
        {
            string id = loader.SaveAsRef(val as UnityEngine.Object);
            arrayList.Add(id);
        }
        arrayList.WriteTo(writer);
    }

    public override bool CanRead
    {
        get
        {
            return true;
        }
    }

    public override bool CanWrite
    {
        get
        {
            return true;
        }
    }
}

public class ResolveListRequest
{
    public IList TargetList;
    public JArray IDs;
}