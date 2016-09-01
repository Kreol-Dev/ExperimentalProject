using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Generators : MonoBehaviour
{
	BasicLoader loader;

	List<EventAction> actions = new List<EventAction> ();
	public bool Loaded = false;

	void Awake ()
	{
		loader = FindObjectOfType<BasicLoader> ();
		loader.Loaded += OnLoad;
	}

	void OnLoad ()
	{
		var eventTypes = loader.Engine.FindTypesCastableTo<EventAction> ();
		foreach (var type in eventTypes)
			actions.Add (Activator.CreateInstance (type) as EventAction);
		Loaded = true;
	}

	public void Generate (GameObject go)
	{
		bool oneMoreRun = true;
		while (oneMoreRun)
		{
			oneMoreRun = false;
			foreach (var action in actions)
			{
				action.Root = go;
				if (action.Filter ())
				if (oneMoreRun |= (action.Utility () > 0))
					action.Action ();
			}
		}
	}

	public void GenerateMostUseful (GameObject go)
	{
		float maxUt = 0;
		EventAction act = null;
		foreach (var action in actions)
		{
			action.Root = go;
			if (action.Filter ())
			{

				var ut = action.Utility ();
				if (ut > maxUt)
				{
					maxUt = ut;
					act = action;
				}
			}
		}
		if (act != null)
			act.Action ();


	}

}

