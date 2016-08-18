﻿using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class EventsController : MonoBehaviour
{
	public Transform ReactionsTab;
	public Text UIText;
	Generators gens;
	World world;

	void Awake ()
	{
		world = FindObjectOfType<World> ();
		gens = FindObjectOfType<Generators> ();
	}

	void Start ()
	{
		NextEvent ();
	}

	public void NextEvent ()
	{
		Debug.Log ("Next event!");
		float maxUt = float.MinValue;
		EventAction maxAction = null;
		GameObject maxObject = null;
		foreach (var obj in world.Objects)
		{
			foreach (var action in gens.actions)
			{
				var cachedRoot = action.Root;
				action.Root = obj;
				if (action.Filter ())
				{
					var ut = action.Utility ();
					if (ut > maxUt)
					{
						maxUt = ut;
						maxAction = action;
						maxObject = obj;
					}
				}
				action.Root = cachedRoot;
			}
		}

		if (maxAction != null)
		{
			maxAction.Root = maxObject;
			maxAction.Action ();
		} else
		{
			Debug.Log ("Generate world");
			gens.Generate (world.gameObject);
		}
	}

	public void Reaction (string text, VoidDelegate reactFunc)
	{
		GameObject go = new GameObject ("reaction");
		ReactionButton button = go.AddComponent<ReactionButton> ();
		button.OnClick = reactFunc;
		button.Text = text;
		go.transform.SetParent (ReactionsTab);
	}

	public void EventDescription (string text)
	{
		UIText.text = text;
	}
}

