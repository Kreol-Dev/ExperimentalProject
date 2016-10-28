using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;
using UnityEngine.Events;

public class CardsHolder : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
	public RectTransform DragOverZone;
	public bool Closed;

	void Start ()
	{
		if (DragOverZone == null)
			DragOverZone = GameObject.Find ("Canvas").GetComponent<RectTransform> ();
	}

	public void OnPointerExit (PointerEventData eventData)
	{
	}


	public void OnPointerEnter (PointerEventData eventData)
	{
	}


	public void OnDrop (PointerEventData eventData)
	{
		Debug.LogFormat ("UI:{0}.OnDrop {1}", this.gameObject, eventData.pointerDrag);
		bool accepted = false;
		//Card c = eventData.pointerDrag.GetComponent<Card> ();
		var card = eventData.pointerDrag.GetComponent<Card> ();
        if (card == null)
            return;
		if (!card.Movable)
			return;
		card.transform.SetParent (transform);
		Debug.LogFormat ("{0} parent is {1}, cards count = {2}", card, transform.gameObject, 
		                 transform.GetComponentsInChildren<Card> ().Length);
		if (card.currentHolder != this)
		if (CardDropped != null)
			accepted = CardDropped (card);
		if (!Closed && accepted)
		{

			Debug.LogFormat ("UI:{0}.OnDrop - AcceptedDrop {1}", this.gameObject, eventData.pointerDrag);
			card.AcceptDrag (this);
		} else
		{
			Debug.LogFormat ("UI:{0}.OnDrop - DeclinedDrop {1}", this.gameObject, eventData.pointerDrag);
			card.CancelDrag ();
		}
	}

	public void CardRemove (Card card)
	{
		if (CardRemoved != null)
			CardRemoved (card);
	}

	public delegate bool CardAcceptance (Card card);

	public delegate void CardDelegate (Card card);

	public CardAcceptance CardDropped;

	public event CardDelegate CardAccepted;
	public event CardDelegate CardRemoved;
}

