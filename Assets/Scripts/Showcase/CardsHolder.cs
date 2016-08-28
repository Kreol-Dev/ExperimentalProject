using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System.Collections.Generic;

public class CardsHolder : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
	HashSet<GameObject> cards = new HashSet<GameObject> ();
	public Transform DragOverZone;

	public void OnPointerExit (PointerEventData eventData)
	{
	}


	public void OnPointerEnter (PointerEventData eventData)
	{
	}

	public class AcceptanceHandler
	{
		public bool Accepted = false;
	}

	AcceptanceHandler aH = new AcceptanceHandler ();

	public void OnDrop (PointerEventData eventData)
	{
		aH.Accepted = false;
		//Card c = eventData.pointerDrag.GetComponent<Card> ();
		if (CardDropped != null)
			CardDropped (eventData.pointerDrag, aH);
		if (aH.Accepted)
		{
			cards.Add (eventData.pointerDrag);
			eventData.pointerDrag.transform.SetParent (transform);

			eventData.pointerDrag.GetComponent<Card> ().AcceptDrag (this);
		} else
		{
			eventData.pointerDrag.GetComponent<Card> ().CancelDrag ();
		}
	}

	public void CardRemove (Card card)
	{
		if (CardRemoved != null)
			CardRemoved (card.gameObject);
	}

	public delegate void CardAcceptance (GameObject go, AcceptanceHandler acceptance);

	public event CardAcceptance CardDropped;

	public event GODelegate CardRemoved;
}

