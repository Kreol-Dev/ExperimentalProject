using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Card : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
	public GameObject ShowedObject { get; set; }

	public Transform ReturnToParent;
	RectTransform transform;
	public CardsHolder currentHolder;

	void Awake ()
	{
		transform = gameObject.GetComponent<RectTransform> ();
	}

	void Start ()
	{
		if (currentHolder == null)
			currentHolder = GetComponentInParent<CardsHolder> ();
	}

	public void OnBeginDrag (PointerEventData eventData)
	{
		ReturnToParent = transform.parent;
		transform.SetParent (currentHolder.DragOverZone);
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