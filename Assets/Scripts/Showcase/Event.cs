using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Event : MonoBehaviour
{

	public string Description { get; internal set; }

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
		
}