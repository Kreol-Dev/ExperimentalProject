using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Card : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
	UiObject uiObject;
	public bool Movable;

	public GameObject ShowedObject { get { return uiObject.ShowedObject; } set { uiObject.ShowedObject = value; } }

	public RectTransform ReturnToParent;
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

	bool dragged = false;
	Vector2 preDragPivot;

	public void OnBeginDrag (PointerEventData eventData)
	{
		if (!Movable)
			return;
		dragged = true;
		ReturnToParent = transform.parent.GetComponent<RectTransform> ();

		Debug.LogFormat ("{0} parent is now {1}, where holder is {2} and it's dragoverzone is {3}", this, transform.parent, currentHolder, currentHolder.DragOverZone);
		GetComponent<CanvasGroup> ().blocksRaycasts = false;

		transform.SetParent (currentHolder.DragOverZone);
//		Vector2 dragPos = eventData.position;
//		if (!RectTransformUtility.ScreenPointToLocalPointInRectangle (
//			    ReturnToParent, eventData.position, eventData.pressEventCamera, out dragPos))
//			return;
//		transform.position = new Vector3 (dragPos.x, dragPos.y, transform.localPosition.z);
	}



	public void OnDrag (PointerEventData eventData)
	{
		if (!Movable)
			return;
		//transform.position = eventData.position;
		transform.position += (Vector3)eventData.delta;
	}

	public void OnEndDrag (PointerEventData eventData)
	{
		if (!Movable)
			return;
		dragged = false;
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
		ReturnToParent = transform.parent.GetComponent<RectTransform> ();
	}


}