using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

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
}

public class Serializer
{
	public Serializer (System.Type type)
	{
		
	}

	public Object Deserialize (JObject data)
	{
		return null;
	}

	public JObject Serialize (Object obj)
	{
		
	}
}
