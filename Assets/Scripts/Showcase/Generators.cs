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

    Dictionary<string, List<EventAction>> interactionsByCategory = new Dictionary<string, List<EventAction>>();
    public bool Loaded = false;

	void Awake ()
	{
		loader = FindObjectOfType<BasicLoader> ();
		loader.Loaded += OnLoad;
	}

    static WaitForSeconds clearUpWait = new WaitForSeconds(100);
    List<GameObject> keys = new List<GameObject>();

	void OnLoad ()
	{
		var eventTypes = loader.Engine.FindTypesCastableTo<EventAction> ();
		foreach (var type in eventTypes)
        {
            var action = Activator.CreateInstance(type) as EventAction;
            
            var actionMeta = type.GetCustomAttributes(typeof(EventActionAttribute), false)[0] as EventActionAttribute;
            action.Meta = actionMeta;
            List<EventAction> catList = null;
            var cats = actionsByCategory;
            if(action.Meta.IsInteraction)
                cats = interactionsByCategory;
            else

                actions.Add(action);
            if (!cats.TryGetValue(action.Meta.Category, out catList))
            {
                catList = new List<EventAction>();
                cats.Add(action.Meta.Category, catList);
            }
            catList.Add(action);
        }

		weights = new ActionWeight[actions.Count];
		Loaded = true;
	}
    ObjectPool<HashSet<EventAction>> eaPool = new ObjectPool<HashSet<EventAction>>();
    ObjectPool<List<EventAction>> eaListPool = new ObjectPool<List<EventAction>>();
	public void Generate (GameObject go, float fuzzy = 0f)
	{
        var performedActions = eaPool.Get();
        var maximizeActions = eaListPool.Get();
        maximizeActions.Clear();
        performedActions.Clear();
		bool oneMoreRun = true;
        int iterations = 0;
        while (oneMoreRun)
		{
            if (Application.isEditor)
                if (iterations++ > 50)
                    break;
            oneMoreRun = false;
            foreach (var category in actionsByCategory.Values)
            {
                maximizeActions.Clear();
                foreach ( var action in category)
                {
                    if (ActedThisWayAndShouldNoMore(go, action) || (action.Meta.OncePerTurn && performedActions.Contains(action)))
                        continue;
                    if (!action.Meta.ShouldHaveMaxUtility)
                    {
                        var cachedRoot = action.Root;
                        action.Root = go;
                        if (action.Filter())
                            if (oneMoreRun |= (action.Utility() > 0))
                            {
                                if(action.Meta.OncePerTurn)
                                    performedActions.Add(action);
                                action.Action();
                                NotifyOfAct(go, action);
                            }
                        action.Root = cachedRoot;
                    }
                    else
                        maximizeActions.Add(action);                    
                }
                if (maximizeActions.Count > 0)
                {
                    var act = GenerateMostUseful(go, fuzzy, maximizeActions, performedActions);
                    if (act != null)
                    {
                        if (act.Meta.OncePerTurn)
                            performedActions.Add(act);
                        oneMoreRun = true;
                    }
                }
            }
            eaListPool.Return(maximizeActions);
            eaPool.Return(performedActions);
		}
        var inter = go.GetComponent<Interactable>();
        if (inter != null)
            GetInteractions(inter);
	}

    ObjectPool<Dictionary<Type, EventAction>> dictPool = new ObjectPool<Dictionary<Type, EventAction>>();
    public void GetInteractions(Interactable inter)
    {
        var interactionsByType = dictPool.Get();
        interactionsByType.Clear();
        bool oneMoreRun = true;
        int iterations = 0;
        foreach (var i in inter.Options)
        {
            var t = i.GetType();
            interactionsByType.Add(t, i);

            
        }
        inter.Options.Clear();

        while (oneMoreRun)
        {
            if (Application.isEditor)
                if (iterations++ > 50)
                    break;
            oneMoreRun = false;
            foreach (var category in interactionsByCategory.Values)
            {
                foreach (var action in category)
                {
                    
                    var cachedRoot = action.Root;
                    action.Root = inter.gameObject;
                    if (action.Filter())
                    {
                        var ta = action.GetType();
                        EventAction interaction = null;
                        if (!interactionsByType.TryGetValue(ta, out interaction))
                        {
                            interaction = Activator.CreateInstance(action.GetType()) as EventAction;
                            interaction.Meta = action.Meta;
                            interactionsByType.Add(ta, interaction);
                        }
                        inter.AddOption(interaction);

                    }
                    
                }
            }
        }

        dictPool.Return(interactionsByType);
    }
    void NotifyOfAct(GameObject go, EventAction action)
    {
        if(action.Meta.OncePerObject || action.Meta.OnceInCategory)
        {

            Markers markers = go.GetComponent<Markers>();
            if (markers == null)
                markers = go.AddComponent<Markers>();
            if (action.Meta.Category == "ui")
                markers.SetUiMarker(action.Meta.OnceInCategory ? action.Meta.Category : action.GetType().Name);
            else
                markers.SetMarker(action.Meta.OnceInCategory? action.Meta.Category : action.GetType().Name);

        }
        
    }
    private bool ActedThisWayAndShouldNoMore(GameObject go, EventAction action)
    {
        if(action.Meta.OncePerObject || action.Meta.OnceInCategory)
        {
            Markers markers = go.GetComponent<Markers>();
            if (markers != null)
                return markers.HasMarker(action.Meta.OnceInCategory ? action.Meta.Category : action.GetType().Name);
        }
        
        return false;
    }

    System.Random random = new System.Random (2);

	public EventAction GenerateMostUseful (GameObject go, float fuzzy = 0f, List<EventAction> customActions = null, HashSet<EventAction> performedActions = null)
    {
        //if (customActions != null)
        //{
        //    Debug.Log("Most useful for " + go);
        //    foreach (var action in customActions)
        //        Debug.Log(action.GetType().Name + " ");
        //}
            
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
			if (!ActedThisWayAndShouldNoMore(go, action) && !(action.Meta.OncePerTurn && performedActions != null && performedActions.Contains(action)) && action.Filter () )
			{
				var baseUt = action.Utility ();
				if (baseUt > 0)
				{
					var ut = baseUt * (1f + fuzzy * ((float)random.NextDouble () - 0.5f) * 2f);
                    //if (customActions != null)
                    //    Debug.LogFormat("Action {0} with ut = {1} is considered", action.GetType().Name, ut);
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
            //Debug.LogFormat("{0} has chosen to do {1} with ut {2}", go, act.GetType().Name, maxUt);
            act.Action();
            act.Root = maxCachedRoot;
            NotifyOfAct(go, act);

        }
        return act;

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

