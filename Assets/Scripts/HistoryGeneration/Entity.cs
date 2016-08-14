using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class Entity : MonoBehaviour
{
	Dictionary<Type, object> blackboard = new Dictionary<Type, object> ();

	void Awake ()
	{
		gameObject.AddComponent<CircleCollider2D> ().radius = 1;
	}

	public bool Dead { get; internal set; }

	public void Destroy ()
	{
		Dead = true;
		Destroy (gameObject);
	}


}

