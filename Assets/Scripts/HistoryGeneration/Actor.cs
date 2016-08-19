using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Actor : MonoBehaviour
{
	HashSet< string> tags;
	public string Name;

	void Awake ()
	{
		tags = new HashSet< string> ();
	}

	void SetTag (string nameTag)
	{
		tags.Add (nameTag);
	}

	void RemoveTag (string nameTag)
	{
		tags.Remove (nameTag);
	}

	bool HasTag (string nameTag)
	{
		return tags.Contains (nameTag);
	}

}

