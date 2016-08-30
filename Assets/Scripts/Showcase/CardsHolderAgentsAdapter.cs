using UnityEngine;
using System.Collections;

public class CardsHolderAgentsAdapter : CardsHolderAdapter<Place>
{
	protected override void Init ()
	{
		this.Container = GetComponent<UiObject> ().ShowedObject.GetComponent<Place> ();
	}

	protected override bool OnCardDropped (Card card)
	{
		var agent = card.ShowedObject.GetComponent<Agent> ();
		if (agent != null)
		{
			return Container.Attach (agent);
		}
		return false;
	}

	protected override void OnCardRemoved (Card card)
	{
		var agent = card.ShowedObject.GetComponent<Agent> ();
		if (agent != null)
		{
			Container.Detach (agent);
		}
	}

}

