using UnityEngine;
using System.Collections;

public class CardsHolderSpaceAdapter : MonoBehaviour
{
	CardsHolder holder;
	public Space Space;

	void Awake ()
	{
		holder = GetComponent<CardsHolder> ();
		holder.CardDropped = OnCardDropped;
		holder.CardRemoved += OnCardRemoved;

	}

	bool OnCardDropped (Card card)
	{
		Debug.LogFormat ("{0} OnCardDropped {1}", this, card);
		var place = card.ShowedObject.GetComponent<Place> ();
		if (place != null)
		{
			Space.Attach (place);
			return true;
		}
		return false;
	}

	void OnCardRemoved (Card card)
	{

		Debug.LogFormat ("{0} OnCardRemoved {1}", this, card);
		Space.Detach (card.ShowedObject.GetComponent<Place> ());
	}
}

