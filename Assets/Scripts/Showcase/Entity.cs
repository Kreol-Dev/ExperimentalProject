using UnityEngine;
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
		if (onDestoryDelegate != null)
			onDestoryDelegate (gameObject);
		onDestoryDelegate = null;
		Dead = true;
		Destroy (gameObject);
	}

	event GODelegate onDestoryDelegate;

	public void OnDestruction (GODelegate del)
	{
		onDestoryDelegate += del;
	}
}
