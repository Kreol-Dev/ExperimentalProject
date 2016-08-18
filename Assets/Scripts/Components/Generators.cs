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
		bool changed;
		do
		{
			changed = false;
			foreach (var gen in actions)
			{
				var cachedRoot = gen.Root;
				gen.Root = go;
				Debug.Log ("Checking " + gen.GetType ());
				if (gen.Filter ())
				{

					Debug.Log ("Getting utility " + gen.GetType ());
					if (gen.Utility () > 0)
					{
						Debug.Log ("Performing " + gen.GetType ());
						gen.Action ();
						changed = true;
					}
				}
				gen.Root = cachedRoot;
			}
		} while(changed);
			
	}


}

