﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public delegate void GODelegate (GameObject entity);
public class Entity : MonoBehaviour
{

	void Awake ()
	{
		gameObject.AddComponent<CircleCollider2D> ().radius = 1;
	}

	public bool Dead { get; internal set; }

	public void Destroy ()
	{
		Dead = true;
		StartCoroutine (DeathCoroutine ());
	}

	event GODelegate onDestoryDelegate;

	public void OnDestruction (GODelegate del)
	{
		onDestoryDelegate += del;
	}

	IEnumerator DeathCoroutine ()
	{
		yield return null;
		Debug.Log ("Death " + gameObject, gameObject);
		if (onDestoryDelegate != null)
			onDestoryDelegate (gameObject);
		onDestoryDelegate = null;
		Destroy (gameObject);
	}
}
