using UnityEngine;
using System.Collections;

public static class Event<T> where T : MonoBehaviour
{
	public static T Invoke (GameObject context)
	{
		GameObject eventObject = new GameObject ();
        var e = eventObject.AddComponent<Event>();
        e.Context = context;
        e.ShouldBeDestroyed = true;
        eventObject.AddComponent<Markers> ();
		var t = eventObject.AddComponent<T> ();
		return t;
	}
}

public class Event : MonoBehaviour
{
	public GameObject Context { get; set; }
    public bool ShouldBeDestroyed { get; set; }
	static Generators gens;

    void Awake()
    {
        ShouldBeDestroyed = false;
    }
	void Start ()
	{
		if (gens == null)
			gens = FindObjectOfType<Generators> ();
		gens.Generate (gameObject);
        if(ShouldBeDestroyed)
		    Destroy (gameObject);
	}
}


