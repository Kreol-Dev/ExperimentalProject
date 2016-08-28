using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpaceUI : MonoBehaviour
{
	public Space ShowedPlace;
	public GameObject PlaceUI;
	Dictionary<Place, GameObject> uiByPlace = new Dictionary<Place, GameObject> ();
	Generators gens;

	void Start ()
	{
		gens = FindObjectOfType<Generators> ();
		foreach (var place in ShowedPlace.Places)
		{
			OnPlaceAttached (place);
		}
		ShowedPlace.PlaceAttached += OnPlaceAttached;
		ShowedPlace.PlaceDetached += OnPlaceDetached;

	}

	void OnPlaceAttached (Place place)
	{
		var placeUIGO = GameObject.Instantiate (PlaceUI);
		placeUIGO.transform.SetParent (gameObject.transform);
		placeUIGO.GetComponent<Card> ().ShowedObject = place.gameObject;
		gens.Generate (placeUIGO);
		uiByPlace.Add (place, placeUIGO);
	}

	void OnPlaceDetached (Place place)
	{
		var go = uiByPlace [place];
		uiByPlace.Remove (place);
		Destroy (go);
	}
}

