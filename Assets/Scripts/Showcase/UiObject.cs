using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class UiObject : MonoBehaviour
{
	[SerializeField]
	GameObject showedObject;
	static Generators gens;
	public bool ShoudFit = true;
    Color firstColor;
	public GameObject ShowedObject {
		get { return showedObject; }
		set
		{
            if(showedObject != null)
            {
                var ent = showedObject.GetComponent<Entity>();
                if (ent != null)
                {
                    ent.Destoryed -= OnGODestoryed;
                    ent.ComponentAddedEvent -= EntComponentAdded;
                }
            }
			showedObject = value;
            if (value != null)
            {
                var ent = showedObject.GetComponent<Entity>();
                if (ent != null)
                {
                    ent.Destoryed += OnGODestoryed;
                    ent.ComponentAddedEvent += EntComponentAdded;
                }
                else
                    Debug.LogErrorFormat("{0} has no Entity component", showedObject);
                var gr = GetComponent<Graphic>();
                if (gr != null)
                    gr.color = firstColor;
                var cg = GetComponent<CanvasGroup>();
                if (cg != null)
                {
                    cg.interactable = true;
                    cg.blocksRaycasts = true;
                }
            }
            else
            {
                var gr = GetComponent<Graphic>();
                if (gr != null)
                    gr.color = Color.clear;
                var cg = GetComponent<CanvasGroup>();
                if(cg != null)
                {
                    cg.interactable = false;
                    cg.blocksRaycasts = false;
                }
                
            }
			
		}
	}
    
    void OnDestroy()
    {
        if(showedObject != null)
        {
            var ent = showedObject.GetComponent<Entity>();
            if (ent != null)
            {
                ent.Destoryed -= OnGODestoryed;
                ent.ComponentAddedEvent -= EntComponentAdded;
            }
        }
        
    }
	void EntComponentAdded ()
	{
		Debug.LogFormat ("Regenerating ui for {0}", ShowedObject);
		if (gens == null)
			gens = FindObjectOfType<Generators> ();
		gens.Generate (gameObject);
	}

	void OnGODestoryed (GameObject go)
	{
        if (go != showedObject)
            return;
        var ent = showedObject.GetComponent<Entity>();
        if (ent != null)
        {
            ent.Destoryed -= OnGODestoryed;
            ent.ComponentAddedEvent -= EntComponentAdded;
        }
        if (this != null)
        {
            ShowedObject = null;
            Destroy(gameObject);
        }
        
    }

	LayoutElement layout;

	public LayoutElement Layout {
		get
		{
			if (layout == null)
				layout = gameObject.AddComponent<LayoutElement> ();
			return layout;
		}
	}



	void Awake ()
    {
        var g = GetComponent<Graphic>();
        if (g != null)
            firstColor = g.color;
        //Reset
        if (showedObject == null)
            ShowedObject = null;

        if (GetComponent<Markers> () == null)
			gameObject.AddComponent<Markers> ();
	}

	void Start ()
	{
		if (gameObject.GetComponent<LayoutElement> () == null && ShoudFit)
		{
			gameObject.AddComponent<ContentSizeFitter> ().verticalFit = ContentSizeFitter.FitMode.PreferredSize;
		}
	}
}

public delegate bool BoolDelegate ();
public class Updated : MonoBehaviour
{
	List<BoolDelegate> delegates = new List<BoolDelegate> ();

	void Update ()
	{
		for (int i = 0; i < delegates.Count; i++)
		{
			bool shouldStop = delegates [i] ();
			if (shouldStop)
			{

				delegates.RemoveAt (i);
				i--;
			}
		}
	}

	public void OnUpdate (BoolDelegate boolDelegate)
	{
		delegates.Add (boolDelegate);
	}
}

