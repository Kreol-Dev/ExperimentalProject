using UnityEngine;
using System.Collections;

public class AgentsActions : MonoBehaviour
{
	Place place;
	Generators generators;

	void Start ()
	{
		generators = FindObjectOfType<Generators> ();
		place = GetComponent<Place> ();
	}

	public void Tick ()
	{
		foreach (var agent in place.Agents)
		{
			agent.Act = true;
			generators.GenerateRandomByWeight (agent.gameObject, 0.1f);
		}
	}
}

