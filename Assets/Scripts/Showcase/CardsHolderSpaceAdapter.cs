using UnityEngine;
using System.Collections;

public class CardsHolderSpaceAdapter : CardsHolderAdapter<Space>
{
	
	protected override bool OnCardDropped (Card card)
	{
		Debug.LogFormat ("{0} OnCardDropped {1}", this, card);
		var place = card.ShowedObject.GetComponent<Place> ();
		if (place != null)
		{
			return Container.Attach (place);
		}
		return false;
	}

	protected override void OnCardRemoved (Card card)
	{

		Container.Detach (card.ShowedObject.GetComponent<Place> ());
	}
}

