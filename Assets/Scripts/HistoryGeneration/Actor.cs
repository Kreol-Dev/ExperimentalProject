using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Actor : MonoBehaviour
{
	public HashSet< string> Tags { get; internal set; }

	void Awake ()
	{
		Tags = new HashSet< string> ();
	}

	void SetTag (string nameTag)
	{
		Tags.Add (nameTag);
	}

	void RemoveTag (string nameTag)
	{
		Tags.Remove (nameTag);
	}

	bool HasTag (string nameTag)
	{
		return Tags.Contains (nameTag);
	}

}

