using UnityEngine;
using System.Collections;
using System.Linq;
using System;

public class AgentsUI : CardsUI<Place>
{
    public Place TargetPlace { get { return TargetContainer; } set { TargetContainer = value; } }
    protected override void Init ()
	{
        var uiObject = GetComponent<UiObject>();
        if(uiObject != null)
            TargetContainer = uiObject.ShowedObject.GetComponent<Place> ();
		Debug.Log (TargetContainer);
	}

	public override System.Collections.Generic.List<GameObject> GetContainer (Place targetContainer)
	{
		return targetContainer.Agents.Select (v => v.gameObject).ToList ();
	}

	public override void SubscribeToAttachementEvent (Place targetContainer, GODelegate del)
	{
		targetContainer.Attached += del;
	}

	public override void SubscribeToDetachmentEvent (Place targetContainer, GODelegate del)
	{
		targetContainer.Detached += del;
	}

    public override void UnSubscribeToAttachementEvent(Place targetContainer, GODelegate del)
    {
        targetContainer.Attached -= del;
    }

    public override void UnSubscribeToDetachmentEvent(Place targetContainer, GODelegate del)
    {
        targetContainer.Detached -= del;
    }
}

