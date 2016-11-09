using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System;

public class SpaceUI : CardsUI<Space>
{
    protected override void Init()
    {
        base.Init();
        MovableCards = false;
    }

    Dictionary<GODelegate, Space.PlaceDelegate> lambdas = new Dictionary<GODelegate, Space.PlaceDelegate>();
    public override List<GameObject> GetContainer (Space targetContainer)
	{
		return targetContainer.Places.Select (p => p.gameObject).ToList ();
	}

	public override void SubscribeToAttachementEvent (Space targetContainer, GODelegate del)
	{
        Space.PlaceDelegate l = place => del(place.gameObject);
        lambdas.Add(del, l);
        targetContainer.PlaceAttached += l;
	}

	public override void SubscribeToDetachmentEvent (Space targetContainer, GODelegate del)
	{
        Space.PlaceDelegate l = place => del(place.gameObject);
        lambdas.Add(del, l);
        targetContainer.PlaceDetached += l;
	}

    public override void UnSubscribeToAttachementEvent(Space targetContainer, GODelegate del)
    {
        targetContainer.PlaceAttached -= lambdas[del];
        lambdas.Remove(del);
    }

    public override void UnSubscribeToDetachmentEvent(Space targetContainer, GODelegate del)
    {
        targetContainer.PlaceDetached -= lambdas[del];
        lambdas.Remove(del);
    }
}

