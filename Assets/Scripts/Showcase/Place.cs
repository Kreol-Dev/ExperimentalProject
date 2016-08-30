using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Place : MonoBehaviour
{
	public List<Agent> Agents { get; set; }

	public int Size { get; set; }

	void Awake ()
	{
		Agents = new List<Agent> ();
	}

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
}
