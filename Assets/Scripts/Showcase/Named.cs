using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Named : MonoBehaviour
{

	public struct NamePart
	{
		public string Part;
		public string Priority;
	}

	public Dictionary<string, NamePart> Names { get; internal set; }

	void Awake ()
	{
		Names = new Dictionary<string, NamePart> ();
	}

	public void Set (string nameTag, string priority, string name)
	{
		if (Names.ContainsKey (nameTag))
			Names [nameTag] = new NamePart (){ Part = name, Priority = priority };
		else
			Names.Add (nameTag, new NamePart (){ Part = name, Priority = priority });
	}

	public void Remove (string nameTag)
	{
		if (Names.ContainsKey (nameTag))
			Names.Remove (nameTag);
	}

	public string Get (string nameTag)
	{
		if (Names.ContainsKey (nameTag))
			return Names [nameTag].Part;
		else
			return "";
	}
}

