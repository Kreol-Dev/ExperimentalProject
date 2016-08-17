using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class EventsController : MonoBehaviour
{
	public Transform ReactionsTab;
	public Text UIText;

	public void NextEvent ()
	{
		Debug.Log ("Next event!");
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

