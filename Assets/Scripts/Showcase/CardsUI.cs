using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class CardsUI<T> : MonoBehaviour
{
    public T TargetContainer;
	public GameObject CardUI;
	Dictionary<GameObject, GameObject> uiByPlace = new Dictionary<GameObject, GameObject> ();
	Dictionary<GameObject, GameObject> cardsByCreation = new Dictionary<GameObject, GameObject> ();
	Generators gens;
	Transform temporaryCardsHolder;

	protected virtual void Init ()
	{
		
	}

	public abstract List<GameObject> GetContainer (T targetContainer);

	public abstract void SubscribeToAttachementEvent (T targetContainer, GODelegate del);

	public abstract void SubscribeToDetachmentEvent (T targetContainer, GODelegate del);

	void Start ()
	{

		Init ();
		temporaryCardsHolder = GameObject.FindWithTag ("CardsHolder").transform;
		gens = FindObjectOfType<Generators> ();
		foreach (var place in GetContainer(TargetContainer))
		{
			OnPlaceAttached (place);
		}
		SubscribeToAttachementEvent (TargetContainer, OnPlaceAttached);
		SubscribeToDetachmentEvent (TargetContainer, OnPlaceDetached);

	}

	List<Card> cards = new List<Card> ();

	void OnPlaceAttached (GameObject go)
	{
		

		GameObject found = null;
		cards.Clear ();
		Debug.LogFormat ("Try to attach {0} to {1}", go, this);
		GetComponentsInChildren<Card> (cards);
		for (int i = 0; i < cards.Count; i++)
			if (cards [i].ShowedObject == go)
				found = cards [i].gameObject;
		//Debug.LogFormat ("UI:{0} OnPlaceAttached - Count of cards found : {1}", this, cards.Count);
		if (found == null)
		{
			temporaryCardsHolder.GetComponentsInChildren<Card> (cards);
			//Debug.LogFormat ("UI:{0} OnPlaceAttached - Count of cards found : {1}", this, cards.Count);
			for (int i = 0; i < cards.Count; i++)
				if (cards [i].ShowedObject == go)
					found = cards [i].gameObject;
		}
		if (found == null)
		{
			Debug.LogFormat ("UI:{0} OnPlaceAttached - CreateNew {1}", this, go);
			var placeUIGO = GameObject.Instantiate (CardUI);
            
			placeUIGO.transform.SetParent (gameObject.transform);
			placeUIGO.GetComponent<UiObject> ().ShowedObject = go;
			gens.Generate (placeUIGO);
			uiByPlace.Add (go, placeUIGO);
			cardsByCreation.Add (go, placeUIGO);
			go.GetComponent<Entity> ().Destoryed += OnEntityDestroyed;
		} else
		{

			Debug.LogFormat ("UI:{0} OnPlaceAttached - FoundOld {1}", this, go);
			uiByPlace.Add (go, found);
		}

	}

	void OnEntityDestroyed (GameObject go)
	{
		Destroy (cardsByCreation [go]);
		cardsByCreation.Remove (go);
	}

	void OnPlaceDetached (GameObject go)
	{
		var cardGo = uiByPlace [go];
		if (cardGo != null)
			cardGo.transform.SetParent (temporaryCardsHolder);
		uiByPlace.Remove (go);
	}
}

