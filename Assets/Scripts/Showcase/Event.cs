using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Event : MonoBehaviour
{

	public string Description { get; internal set; }

	public List<Reaction> Reactions = new List<Reaction> ();

	public void Reaction (GameObject reaction)
	{
		Reactions.Add (reaction.GetComponent<Reaction> ());
	}
}

public class Reaction : MonoBehaviour
{
	public string Id { get; internal set; }

	public string Description { get; internal set; }

	VoidDelegate act;

	public void OnChosen (VoidDelegate act)
	{
		this.act = act;
	}

	public void React ()
	{
		act ();
	}
		
}