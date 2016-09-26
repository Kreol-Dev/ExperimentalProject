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

		weights = new ActionWeight[actions.Count];
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

	System.Random random = new System.Random ();

	public void GenerateMostUseful (GameObject go, float fuzzy = 0f)
	{
		if (fuzzy < 0f)
			fuzzy = -fuzzy;
		float maxUt = 0;
		EventAction act = null;
		foreach (var action in actions)
		{
			action.Root = go;
			if (action.Filter ())
			{
				var baseUt = action.Utility ();
				if (baseUt > 0)
				{
					var ut = baseUt * (1f + fuzzy * ((float)random.NextDouble () - 0.5f) * 2f);
					if (ut > maxUt)
					{
						maxUt = ut;
						act = action;
					}
				}

			}
		}
		if (act != null)
			act.Action ();


	}

	ActionWeight[] weights;

	struct ActionWeight
	{
		public EventAction Action;
		public float Weight;
	}

	public void GenerateRandomByWeight (GameObject go, float fuzzy = 0f)
	{
		float cumulativeWeights = 0f;
		int filteredActionsCount = 0;
		foreach (var action in actions)
		{
			action.Root = go;
			if (action.Filter ())
			{
				var baseUt = action.Utility ();
				var ut = baseUt * (1f + fuzzy * ((float)random.NextDouble () - 0.5f) * 2f);
				if (baseUt > 0f)
				{
					weights [filteredActionsCount].Action = action;
					weights [filteredActionsCount].Weight = cumulativeWeights;
					cumulativeWeights += ut;
					filteredActionsCount++;
				}

			}
		}

		var num = (float)random.NextDouble () * cumulativeWeights;
		EventAction act = null;
		for (int i = 1; i < filteredActionsCount; i++)
		{
			if (weights [i - 1].Weight <= num && weights [i].Weight > num)
				act = weights [i - 1].Action;
		}
		if (act == null && filteredActionsCount > 0)
			act = weights [filteredActionsCount - 1].Action;
		if (act != null)
			act.Action ();
	}

}

