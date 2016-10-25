using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Place : MonoBehaviour
{
	public List<Agent> Agents { get; set; }

	public bool Act { get; internal set; }

	Generators generators;

	public int Size { get; set; }

	public bool ShouldAct = true;

	void Awake ()
	{
		Act = false;
		generators = FindObjectOfType<Generators> ();
		Agents = new List<Agent> ();
	}

	void Start ()
	{
		Act = ShouldAct;
		FindObjectOfType<NextTurn> ().NewTurnListener (NewTurn);
	}

	void OnDestroy ()
	{
		var nt = FindObjectOfType<NextTurn> ();
		if (nt != null)
			nt.RemoveNewTurnListener (NewTurn);
	}

	void NewTurn (VoidDelegate callback)
	{

		generators.GenerateMostUseful (gameObject, 0.15f);
		callback ();
	}

	WaitForSeconds seconds = new WaitForSeconds (1f);



	public bool Attach (Agent agent)
	{
		if (Size <= Agents.Count)
			return false;
		if (Attached != null)
			Attached (agent.gameObject);
		var marker = agent.GetComponent<PlaceMarker> ();
		if (marker == null)
			marker = agent.gameObject.AddComponent<PlaceMarker> ();
		marker.CurrentPlace = this;
		Agents.Add (agent);
		return true;
	}

	public void Detach (Agent agent)
	{
		if (Detached != null)
			Detached (agent.gameObject);
		Agents.Remove (agent);
	}

	public event GODelegate Attached;
	public event GODelegate Detached;
}

public class PlaceMarker : MonoBehaviour
{
	public Place CurrentPlace { get; set; }

	void OnDestroy ()
	{
		if (CurrentPlace != null)
			CurrentPlace.Detach (GetComponent<Agent> ());
	}

	void Start ()
	{
		var agent = GetComponent<Agent> ();
		if (!CurrentPlace.Agents.Contains (agent))
		if (!CurrentPlace.Attach (agent))
		{
			CurrentPlace = null;
			var ent = GetComponent<Entity> ();
			if (ent != null)
				ent.Destroy ();
			else
				Destroy (gameObject);
		}
	}
}
