using UnityEngine;
using System.Collections;

using System.Collections.Generic;

public class Traits : MonoBehaviour
{
	public HashSet< string> Tags { get; internal set; }

	void Awake ()
	{
		Tags = new HashSet< string> ();
	}

	void Set (string nameTag)
	{
		Tags.Add (nameTag);
	}

	void Remove (string nameTag)
	{
		Tags.Remove (nameTag);
	}

	bool Has (string nameTag)
	{
		return Tags.Contains (nameTag);
	}

}

