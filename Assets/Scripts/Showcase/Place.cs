using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Place : MonoBehaviour
{
	public List<Agent> Agents { get; set; }

	void Awake ()
	{
		Agents = new List<Agent> ();
	}

}

