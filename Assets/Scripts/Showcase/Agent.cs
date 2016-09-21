using UnityEngine;
using System.Collections;

public class Agent : MonoBehaviour
{
	public bool Act { get; internal set; }

	void Awake ()
	{
		Act = false;
	}
}

