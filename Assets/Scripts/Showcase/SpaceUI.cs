using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SpaceUI : MonoBehaviour
{
	public Space ShowedPlace;
	public GameObject PlaceUI;
	Dictionary<Place, GameObject> uiByPlace = new Dictionary<Place, GameObject> ();
	Dictionary<GameObject, GameObject> cardsByCreation = new Dictionary<GameObject, GameObject> ();
	Generators gens;
	Transform temporaryCardsHolder;

	void Start ()
	{
		temporaryCardsHolder = GameObject.FindWithTag ("CardsHolder").transform;
		gens = FindObjectOfType<Generators> ();
		foreach (var place in ShowedPlace.Places)
		{
			OnPlaceAttached (place);
		}
		ShowedPlace.PlaceAttached += OnPlaceAttached;
		ShowedPlace.PlaceDetached += OnPlaceDetached;

	}

	List<Card> cards = new List<Card> ();

	void OnPlaceAttached (Place place)
	{
		

		GameObject found = null;
		cards.Clear ();

		GetComponentsInChildren<Card> (cards);
		for (int i = 0; i < cards.Count; i++)
			if (cards [i].ShowedObject == place.gameObject)
				found = cards [i].gameObject;
		//Debug.LogFormat ("UI:{0} OnPlaceAttached - Count of cards found : {1}", this, cards.Count);
		if (found == null)
		{
			temporaryCardsHolder.GetComponentsInChildren<Card> (cards);
			//Debug.LogFormat ("UI:{0} OnPlaceAttached - Count of cards found : {1}", this, cards.Count);
			for (int i = 0; i < cards.Count; i++)
				if (cards [i].ShowedObject == place.gameObject)
					found = cards [i].gameObject;
		}
		if (found == null)
		{
			Debug.LogFormat ("UI:{0} OnPlaceAttached - CreateNew {1}", this, place);
			var placeUIGO = GameObject.Instantiate (PlaceUI);
			placeUIGO.transform.SetParent (gameObject.transform);
			placeUIGO.GetComponent<Card> ().ShowedObject = place.gameObject;
			gens.Generate (placeUIGO);
			uiByPlace.Add (place, placeUIGO);
			cardsByCreation.Add (place.gameObject, placeUIGO);
			place.GetComponent<Entity> ().OnDestruction (OnEntityDestroyed);
		} else
		{

			Debug.LogFormat ("UI:{0} OnPlaceAttached - FoundOld {1}", this, place);
			uiByPlace.Add (place, found);
		}

	}

	void OnEntityDestroyed (GameObject place)
	{
		Destroy (cardsByCreation [place]);
	}

	void OnPlaceDetached (Place place)
	{
		var cardGo = uiByPlace [place];
		cardGo.transform.SetParent (temporaryCardsHolder);
		uiByPlace.Remove (place);
	}
}

