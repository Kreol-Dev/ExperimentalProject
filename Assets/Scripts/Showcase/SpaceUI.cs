using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class SpaceUI : CardsUI<Space>
{

	public override List<GameObject> GetContainer (Space targetContainer)
	{
		return targetContainer.Places.Select (p => p.gameObject).ToList ();
	}

	public override void SubscribeToAttachementEvent (Space targetContainer, GODelegate del)
	{
		targetContainer.PlaceAttached += place => del (place.gameObject);
	}

	public override void SubscribeToDetachmentEvent (Space targetContainer, GODelegate del)
	{
		targetContainer.PlaceDetached += place => del (place.gameObject);
	}
}

