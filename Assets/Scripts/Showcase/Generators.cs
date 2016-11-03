using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Linq;
public class Generators : MonoBehaviour
{
	BasicLoader loader;

	List<EventAction> actions = new List<EventAction> ();
    Dictionary<string, List<EventAction>> actionsByCategory = new Dictionary<string, List<EventAction>>();
    Dictionary<GameObject, HashSet<EventAction>> oncePerObjectMarkers = new Dictionary<GameObject, HashSet<EventAction>>();
	public bool Loaded = false;

	void Awake ()
	{
		loader = FindObjectOfType<BasicLoader> ();
		loader.Loaded += OnLoad;
        StartCoroutine(ClearUpCoroutine());
	}

    static WaitForSeconds clearUpWait = new WaitForSeconds(100);
    List<GameObject> keys = new List<GameObject>();
    IEnumerator ClearUpCoroutine()
    {
        yield return clearUpWait;
        while(true)
        {
            keys.Clear();
            foreach (var key in oncePerObjectMarkers.Keys)
                keys.Add(key);
            foreach (var key in keys)
            {
                if (oncePerObjectMarkers[key] == null)
                    oncePerObjectMarkers.Remove(key);
            }

            keys.Clear();
            yield return clearUpWait;
        }
    }

	void OnLoad ()
	{
		var eventTypes = loader.Engine.FindTypesCastableTo<EventAction> ();
		foreach (var type in eventTypes)
        {
            var ea = Activator.CreateInstance(type) as EventAction;
            actions.Add(ea);
            var eaa = type.GetCustomAttributes(typeof(EventActionAttribute), false)[0] as EventActionAttribute;
            ea.Category = eaa.Category;
            ea.ShouldHaveMaxUtility = eaa.ShouldHaveMaxUtility;
            ea.OncePerObject = eaa.OncePerObject;
            List<EventAction> catList = null;
            if(!actionsByCategory.TryGetValue(ea.Category, out catList))
            {
                catList = new List<EventAction>();
                actionsByCategory.Add(ea.Category, catList);
            }
            catList.Add(ea);
        }

		weights = new ActionWeight[actions.Count];
		Loaded = true;
	}
    List<EventAction> maximizeActions = new List<EventAction>();
	public void Generate (GameObject go)
	{
		bool oneMoreRun = true;
		while (oneMoreRun)
		{
			oneMoreRun = false;
            foreach (var category in actionsByCategory.Values)
            {
                maximizeActions.Clear();
                foreach ( var action in category)
                {
                    if (ActedThisWayAndShouldNoMore(go, action))
                        continue;
                    if (!action.ShouldHaveMaxUtility)
                    {
                        var cachedRoot = action.Root;
                        action.Root = go;
                        if (action.Filter())
                            if (oneMoreRun |= (action.Utility() > 0))
                            {
                                action.Action();
                                NotifyOfAct(go, action);
                            }
                        action.Root = cachedRoot;
                    }
                    else
                        maximizeActions.Add(action);
                    oneMoreRun |= GenerateMostUseful(go, 0, maximizeActions);
                }
            }
			
		}
	}
    void NotifyOfAct(GameObject go, EventAction action)
    {
        if(action.OncePerObject)
        {
            HashSet<EventAction> markers = null;
            if (!oncePerObjectMarkers.TryGetValue(go, out markers))
            {
                markers = new HashSet<EventAction>();
                oncePerObjectMarkers.Add(go, markers);
            }
            markers.Add(action);
        }
    }
    private bool ActedThisWayAndShouldNoMore(GameObject go, EventAction action)
    {
        if(action.OncePerObject)
        {
            HashSet<EventAction> markers = null;
            if (oncePerObjectMarkers.TryGetValue(go, out markers))
                return markers.Contains(action);
        }
        
        return false;
    }

    System.Random random = new System.Random ();

	public bool GenerateMostUseful (GameObject go, float fuzzy = 0f, List<EventAction> customActions = null)
	{
		if (fuzzy < 0f)
			fuzzy = -fuzzy;
		float maxUt = 0;
		EventAction act = null;
        GameObject maxCachedRoot = null;
        var actions = customActions == null ? this.actions : customActions;
		foreach (var action in actions)
        {
            var cachedRoot = action.Root;
            action.Root = go;
			if (!ActedThisWayAndShouldNoMore(go, action) && action.Filter ())
			{
				var baseUt = action.Utility ();
				if (baseUt > 0)
				{
					var ut = baseUt * (1f + fuzzy * ((float)random.NextDouble () - 0.5f) * 2f);
					if (ut > maxUt)
					{
						maxUt = ut;
						act = action;
                        maxCachedRoot = cachedRoot;

                    }
				}
                else
                    action.Root = cachedRoot;
            }
            else
                action.Root = cachedRoot;
        }
		if (act != null)
        {
            act.Action();
            act.Root = maxCachedRoot;
            NotifyOfAct(go, act);

        }
        return act != null;

	}

	ActionWeight[] weights;

	struct ActionWeight
	{
		public EventAction Action;
		public float Weight;
        public GameObject CachedRoot;
	}

	public void GenerateRandomByWeight (GameObject go, float fuzzy = 0f)
	{
		float cumulativeWeights = 0f;
		int filteredActionsCount = 0;
		foreach (var action in actions)
        {
            var cachedRoot = action.Root;
            action.Root = go;
			if (!ActedThisWayAndShouldNoMore(go, action) && action.Filter ())
			{
				var baseUt = action.Utility ();
				var ut = baseUt * (1f + fuzzy * ((float)random.NextDouble () - 0.5f) * 2f);
                if (baseUt > 0f)
                {
                    weights[filteredActionsCount].CachedRoot = cachedRoot;
                    weights[filteredActionsCount].Action = action;
                    weights[filteredActionsCount].Weight = cumulativeWeights;
                    cumulativeWeights += ut;
                    filteredActionsCount++;
                }
                else
                    action.Root = cachedRoot;

            }
            else
                action.Root = cachedRoot;
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
        {
            act.Action();
            NotifyOfAct(go, act);
        }
			
        for ( int i = 0; i < filteredActionsCount; i++)
        {
            weights[i].Action.Root = weights[i].CachedRoot;
        }
	}

	
}

