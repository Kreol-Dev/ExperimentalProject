using UnityEngine;
using System.Collections;

public class CardsHolderAgentsAdapter : CardsHolderAdapter<Place>
{
    public Place TargetPlace { get { return Container; } set { Container = value; } }
    protected override void Init ()
	{
        var ui = GetComponent<UiObject>();
        if (ui != null)
		    this.Container = ui.ShowedObject.GetComponent<Place> ();
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

