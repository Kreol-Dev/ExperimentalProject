using UnityEngine;
using System.Collections;
using System;

public class GenerateCmp : MonoBehaviour
{
	BasicLoader loader;

	void Awake ()
	{
		loader = FindObjectOfType<BasicLoader> ();
		loader.Loaded += OnLoad;
	}

	void OnLoad ()
	{
		var eventActions = loader.Engine.FindTypesCastableTo<EventAction> ();
		foreach (var ea in eventActions)
		{
			var action = Activator.CreateInstance (ea) as EventAction;
			if (action.Filter (gameObject))
				action.Action (gameObject);
		}
	
	}
}

