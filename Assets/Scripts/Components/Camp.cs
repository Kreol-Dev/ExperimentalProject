using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Camp : MonoBehaviour, ILoadable
{
	public event VoidDelegate Loaded;

	public List<Person> People { get; set; }

	public int Size { get; set; }

	void Awake ()
	{
		People = new List<Person> ();
	}
}
