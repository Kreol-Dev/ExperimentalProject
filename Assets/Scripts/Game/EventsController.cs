using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class EventsController : MonoBehaviour
{
	public Transform ReactionsTab;
	public Text UIText;
	Generators gens;
	World world;
	public GameObject ReactionButton;

	void Awake ()
	{
		world = FindObjectOfType<World> ();
		gens = FindObjectOfType<Generators> ();
	}

	void Start ()
	{
		NextEvent ();
	}

	void Update ()
	{
		if (Input.GetKeyUp (KeyCode.Space))
		{
			NextEvent ();
		}
	}

	public void NextEvent ()
	{
		Debug.Log ("Next event!");
		HasDesc = false;
		float maxUt = 0f;
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
		GameObject go = Instantiate (ReactionButton);
		ReactionButton button = go.GetComponent<ReactionButton> ();
		button.EventsController = this;
		button.OnClick = reactFunc;
		button.Text = text;
		go.transform.SetParent (ReactionsTab);
	}

	public bool HasDesc { get; set; }

	public void EventDescription (string text)
	{
		UIText.text = text;
	}
}

