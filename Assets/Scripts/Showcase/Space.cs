using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Space : MonoBehaviour
{
	public List<Place> Places { get; internal set; }

	public int size;

	public int Size { get { return size; } set { size = value; } }

	void Awake ()
	{
		Places = new List<Place> ();
	}

	public delegate void PlaceDelegate (Place place);

	public event PlaceDelegate PlaceAttached;
	public event PlaceDelegate PlaceDetached;

	public bool Attach (Place place)
	{
		if (Size <= Places.Count)
			return false;
		if (PlaceAttached != null)
			PlaceAttached (place);
		var marker = place.GetComponent<SpaceMarker> ();
		if (marker == null)
			marker = place.gameObject.AddComponent<SpaceMarker> ();
		marker.CurrentSpace = this;
		Places.Add (place);
		return true;
	}

	public void Detach (Place place)
	{
		if (PlaceDetached != null)
			PlaceDetached (place);
		Places.Remove (place);
	}

}

public class SpaceMarker : MonoBehaviour
{
	public Space CurrentSpace { get; set; }

	void OnDestroy ()
	{
		CurrentSpace.Detach (GetComponent<Place> ());
	}
}