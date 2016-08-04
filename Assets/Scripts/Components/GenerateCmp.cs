using UnityEngine;
using System.Collections;
using System;

public class GenerateCmp : MonoBehaviour, ILoadable
{
	public event VoidDelegate Loaded;

	Generators generators;
	DependencyWaiter waiter;

	void Awake ()
	{
		
		var loader = FindObjectOfType<BasicLoader> ();
		generators = FindObjectOfType<Generators> ();
		waiter = new DependencyWaiter (OnLoad, loader, generators);
	
	}

	int loaded = 0;

	void OnLoad ()
	{
		generators.Generate (gameObject);
		Debug.Log ("Generate " + gameObject);
		if (Loaded != null)
			Loaded ();
	}
}

