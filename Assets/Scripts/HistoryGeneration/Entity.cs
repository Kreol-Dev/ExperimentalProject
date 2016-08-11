using UnityEngine;
using System.Collections;

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
		Destroy (gameObject);
	}
}

