using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Linq.Expressions;

public class SavingLoading : MonoBehaviour
{
	Dictionary<int, Object> loadedObjects = new Dictionary<int, Object> ();
	List<Object> savedObjects = new List<Object> ();
	Dictionary<Object, int> objectToRef = new Dictionary<Object, int> ();
	Dictionary<System.Type, Serializer> serializers = new Dictionary<System.Type, Serializer> ();

	public bool IsLoading = false;

	public string SaveFilePath;

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
			Serializer srz = serializers [type];
			loadedObjects.Add (refId, srz.Deserialize (objData));
		}

	}

	int nextId = 0;

	public void Save ()
	{
		loadedObjects.Clear ();
		JObject saveFileObject = new JObject ();
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
		Serializer srz = null;
		var objType = obj.GetType ();
		if (!serializers.TryGetValue (objType, out srz))
		{
			srz = new Serializer (objType);
			serializers.Add (objType, srz);
		}
		return srz.Serialize (obj);

	}

	public void PostResolveRequest (Serializer.ResolveReferenceRequest request)
	{
		
	}

	public int SetAsRef (Object obj)
	{
		int refId = nextId++;
		objectToRef.Add (obj, refId);
		return refId;
	}
}

public class Serializer
{
	static ScriptEngine engine;
	static SavingLoading savingLoading;

	public Serializer (System.Type type)
	{
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

	public Serializer (string typeName)
	{
		if (engine == null)
			engine = Object.FindObjectOfType<BasicLoader> ().Engine;
		var type = engine.FindType (typeName);
		InitByType (type);
		
	}

	void InitByType (System.Type type)
	{
		var props = type.GetProperties ();
		var targetArg = Expression.Parameter (typeof(Object), "target");
		var nodeArg = Expression.Parameter (typeof(JObject), "node");
		var convertTargetArg = Expression.Convert (targetArg, type);
		//loading
		List<TargetNodeDelegate> loadingDelegates = new List<TargetNodeDelegate> ();
		List<TargetNodeDelegate> savingDelegates = new List<TargetNodeDelegate> ();
		foreach (var prop in props)
		{

			Expression exprBody = null;

			if (!prop.PropertyType.IsClass || prop.PropertyType == typeof(string))
			{
				//load directly

				var nodeGetValue = Expression.Convert (Expression.ArrayIndex (nodeArg, Expression.Constant (prop.Name)), prop.PropertyType);
				var assignProp = Expression.Call (convertTargetArg, prop.GetSetMethod (), nodeGetValue);
				exprBody = assignProp;
			} else
			{
				//load indirectly
				var refArg = Expression.Parameter (typeof(Object), "ref");
				var convertRefArg = Expression.Convert (refArg, prop.PropertyType);

				var assignProp = Expression.Call (convertTargetArg, prop.GetSetMethod (), convertRefArg);

				var resolveLambda = Expression.Lambda<ResolveReference> (assignProp, targetArg, refArg).Compile ();

				var nodeGetValue = Expression.Call (typeof(int), "Parse", new System.Type[]{ typeof(string) }, Expression.ArrayIndex (nodeArg, Expression.Constant (prop.Name)));

				var createRequest = Expression.New (typeof(ResolveReferenceRequest).GetConstructor (new System.Type[] { }), new Expression[] {
					targetArg,
					nodeGetValue,
					Expression.Constant (resolveLambda)
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

			Expression exprBody = null;

			if (!prop.PropertyType.IsClass || prop.PropertyType == typeof(string))
			{
				var nodeGetValue = Expression.Call (convertTargetArg, prop.GetGetMethod ());//Expression.Convert (Expression.ArrayIndex (nodeArg, Expression.Constant (prop.Name)), prop.PropertyType);
				var addToNode = Expression.Call (nodeArg, "Add", new System.Type[] { typeof(string), typeof(JToken) }, Expression.Constant (prop.Name), nodeGetValue);
				exprBody = addToNode;
			} else
			{
				
			}
			var saveLambda = Expression.Lambda<TargetNodeDelegate> (exprBody, targetArg, nodeArg);
			var saveCall = saveLambda.Compile ();
			savingDelegates.Add (saveCall);
		}


	}

	public Object Deserialize (JObject data)
	{
		return null;
	}

	public JObject Serialize (Object obj)
	{
		return null;
	}
}

