using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Named : MonoBehaviour
{
	public Dictionary<string, string> Names { get; internal set; }

	void Awake ()
	{
		Names = new Dictionary<string, string> ();
	}

	void Set (string nameTag, string name)
	{
		if (Names.ContainsKey (nameTag))
			Names [nameTag] = name;
		else
			Names.Add (nameTag, name);
	}

	void Remove (string nameTag)
	{
		if (Names.ContainsKey (nameTag))
			Names.Remove (nameTag);
	}

	string Get (string nameTag)
	{
		if (Names.ContainsKey (nameTag))
			return Names [nameTag];
		else
			return "";
	}
}

