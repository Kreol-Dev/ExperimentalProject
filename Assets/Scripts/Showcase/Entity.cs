using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public delegate void GODelegate (GameObject entity);
public class Entity : MonoBehaviour
{

	public Vector3 Position { get { return transform.position; } set { transform.position = value; } }

	public event VoidDelegate ComponentAddedEvent;

	void Awake ()
	{
	}

	public bool Dead { get; internal set; }

	public void Destroy ()
	{
		Dead = true;
		StartCoroutine (DeathCoroutine ());
	}

	public event GODelegate Destoryed;

	IEnumerator DeathCoroutine ()
	{
		yield return null;
		Debug.Log ("Death " + gameObject, gameObject);
		Event<EntityDeathEvent>.Invoke (gameObject);
		if (Destoryed != null)
			Destoryed (gameObject);

		yield return null;
		Destroy (gameObject);
	}

	public void ComponentAdded ()
	{
		if (ComponentAddedEvent != null)
			ComponentAddedEvent ();
	}
}


public class EntityDeathEvent : MonoBehaviour
{
	
}

