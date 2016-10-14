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
	List<Object> savedObjects = new List<Object> ();
	Dictionary<Object, int> objectToRef = new Dictionary<Object, int> ();
	Dictionary<System.Type, ISerializer> serializers = new Dictionary<System.Type, ISerializer> ();

	public bool IsLoading = false;

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


	public void Load ()
	{
		loadedObjects.Clear ();
		TextReader textReader = new StreamReader (SaveFilePath);
		JsonReader jsonReader = new JsonTextReader (textReader);
		JObject saveFileObject = JObject.Load (jsonReader);
		foreach (var child in saveFileObject)
		{
			int refId = int.Parse (child.Key);
			JObject objData = child.Value as JObject;
			var typeValue = objData ["type"] as JValue;
			System.Type type = null;
			ISerializer srz = serializers [type];
			loadedObjects.Add (refId, srz.Deserialize (objData));
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
}

public interface ISerializer
{
	Object Deserialize (JObject data);

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
		public int RefID;
		public ResolveReference ResolveLambda;

		public ResolveReferenceRequest (Object target, int refId, ResolveReference resolveLambda)
		{
			Target = target;
			RefID = refId;
			ResolveLambda = resolveLambda;
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
//		foreach (var prop in props)
//		{
//
//			Expression exprBody = null;
//
//			if (!prop.PropertyType.IsSubclassOf (typeof(UnityEngine.Object)))
//			{
//				//load directly
//
//				var nodeGetValue = Expression.Call (Expression.Call (nodeArg, typeof(JObject).GetMethod ("GetValue", new System.Type[]{ typeof(string) }), Expression.Constant (prop.Name)), prop.PropertyType);
//				var setMethod = prop.GetSetMethod ();
//				if (setMethod == null)
//					continue;
//				var assignProp = Expression.Call (convertTargetArg, setMethod, nodeGetValue);
//				exprBody = assignProp;
//			} else
//			{
//				//load indirectly
//				var refArg = Expression.Parameter (typeof(Object), "ref");
//				var convertRefArg = Expression.Convert (refArg, prop.PropertyType);
//				var setMethod = prop.GetSetMethod ();
//				if (setMethod == null)
//					continue;
//				var assignProp = Expression.Call (convertTargetArg, setMethod, convertRefArg);
//
//				var resolveLambda = Expression.Lambda<ResolveReference> (assignProp, targetArg, refArg).Compile ();
//
//				var nodeGetValue = Expression.Call (typeof(int), "Parse", new System.Type[]{ typeof(string) }, Expression.Call (nodeArg, typeof(JObject).GetMethod ("GetValue", new System.Type[]{ typeof(string) }), Expression.Constant (prop.Name)));
//
//				var createRequest = Expression.New (typeof(ResolveReferenceRequest).GetConstructor (new System.Type[] { }), new Expression[] {
//					targetArg,
//					nodeGetValue,
//					Expression.Constant (resolveLambda)
//				});
//
//				var postRequest = Expression.Call (Expression.Constant (savingLoading), typeof(SavingLoading).GetMethod ("PostResolveRequest"), createRequest);
//				exprBody = postRequest;
//			}
//
//			var loadLambda = Expression.Lambda<TargetNodeDelegate> (exprBody, targetArg, nodeArg);
//			var loadCall = loadLambda.Compile ();
//			loadingDelegates.Add (loadCall);
//		}


		//saving
	
		foreach (var prop in props)
		{
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
				var postId = Expression.Call (Expression.Constant (savingLoading, typeof(SavingLoading)), typeof(SavingLoading).GetMethod ("SetAsRef"), Expression.Call (convertTargetArg, prop.GetGetMethod ()));
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

	public Object Deserialize (JObject data)
	{
		return null;
	}

	public JObject Serialize (Object obj)
	{
		JObject jObj = new JObject ();
		jObj.Add ("lambda", type.FullName);
		foreach (var saveLambda in savingDelegates)
			saveLambda (obj, jObj);
		return jObj;
	}
}

public class GameobjectSerializer : ISerializer
{
	SavingLoading savingLoading;

	public GameobjectSerializer ()
	{
		savingLoading = Object.FindObjectOfType<SavingLoading> ();
	}

	public Object Deserialize (JObject data)
	{
		return null;
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