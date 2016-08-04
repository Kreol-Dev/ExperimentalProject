using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class Generators : MonoBehaviour, ILoadable
{
	public event VoidDelegate Loaded;


	public List<EventAction> actions = new List<EventAction> ();

	void Awake ()
	{
		FindObjectOfType<BasicLoader> ().Loaded += OnLoad;
	}

	void OnLoad ()
	{
		var events = FindObjectOfType<BasicLoader> ().Engine.FindTypesCastableTo<EventAction> ();

		foreach (var ea in events)
		{
			var action = Activator.CreateInstance (ea) as EventAction;
			actions.Add (action);
		}
		if (Loaded != null)
			Loaded ();
	}

	public void Generate (GameObject go)
	{
		foreach (var gen in actions)
		{
			gen.Root = go;
			Debug.LogFormat ("Test {0} on {1}", gen.GetType (), go);
			if (gen.Filter (go))
			{

				gen.Action ();
				Debug.LogFormat ("Applied {0} to {1}", gen.GetType (), go);
			}
		}
			
	}
}

