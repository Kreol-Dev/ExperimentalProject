using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Encounter : MonoBehaviour
{
	public List<GameObject> reactProtos = new List<GameObject> ();

	public event GODelegate NewReaction;

	public void Reaction (GameObject reactProto)
	{
		reactProtos.Add (reactProto);
		if (NewReaction != null)
			NewReaction (reactProto);
	}
}

