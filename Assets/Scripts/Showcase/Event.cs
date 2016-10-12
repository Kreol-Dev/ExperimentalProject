using UnityEngine;
using System.Collections;

public static class Event<T> where T : MonoBehaviour
{
	public static T Invoke (GameObject context)
	{
		GameObject eventObject = new GameObject ();
		eventObject.AddComponent<Event> ().Context = context;
		eventObject.AddComponent<Markers> ();
		var t = eventObject.AddComponent<T> ();
		return t;
	}
}

public class Event : MonoBehaviour
{
	public GameObject Context { get; set; }

	static Generators gens;

	void Start ()
	{
		if (gens == null)
			gens = FindObjectOfType<Generators> ();
		gens.Generate (gameObject);
		Destroy (gameObject);
	}
}


