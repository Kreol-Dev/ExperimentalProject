using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Card : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
	UiObject uiObject;

	public GameObject ShowedObject { get { return uiObject.ShowedObject; } set { uiObject.ShowedObject = value; } }

	public Transform ReturnToParent;
	RectTransform transform;
	public CardsHolder currentHolder;

	void Awake ()
	{
		uiObject = gameObject.GetComponent<UiObject> ();
		transform = gameObject.GetComponent<RectTransform> ();
	}

	void Start ()
	{
		if (currentHolder == null)
			currentHolder = transform.parent.GetComponentInParent<CardsHolder> ();
	}

	public void OnBeginDrag (PointerEventData eventData)
	{
		ReturnToParent = transform.parent;
		transform.SetParent (currentHolder.DragOverZone);
		Debug.LogFormat ("{0} parent is now {1}, where holder is {2} and it's dragoverzone is {3}", this, transform.parent, currentHolder, currentHolder.DragOverZone);
		GetComponent<CanvasGroup> ().blocksRaycasts = false;
	}

	public void OnDrag (PointerEventData eventData)
	{
		transform.position += (Vector3)eventData.delta;
	}

	public void OnEndDrag (PointerEventData eventData)
	{

		GetComponent<CanvasGroup> ().blocksRaycasts = true;
		transform.SetParent (ReturnToParent);
	}

	public void CancelDrag ()
	{
		Debug.Log ("Canceled");
		transform.SetParent (ReturnToParent);
	}

	public void AcceptDrag (CardsHolder cardsHolder)
	{
		Debug.Log ("Accepted");
		currentHolder.CardRemove (this);
		currentHolder = cardsHolder;
		transform.SetParent (cardsHolder.gameObject.transform);
		ReturnToParent = transform.parent;
	}
}