using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Space : MonoBehaviour
{
	public List<Place> Places { get; internal set; }

	void Awake ()
	{
		Places = new List<Place> ();
	}

	public delegate void PlaceDelegate (Place place);

	public event PlaceDelegate PlaceAttached;
	public event PlaceDelegate PlaceDetached;

	public void Attach (Place place)
	{
		Debug.LogFormat ("{0} Attach {1}", gameObject, place);
		if (PlaceAttached != null)
			PlaceAttached (place);
		Places.Add (place);
	}

	public void Detach (Place place)
	{
		Debug.LogFormat ("{0} Detach {1}", gameObject, place);
		if (PlaceDetached != null)
			PlaceDetached (place);
		Places.Remove (place);
	}

}

