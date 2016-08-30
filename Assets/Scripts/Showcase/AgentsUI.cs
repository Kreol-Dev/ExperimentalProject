using UnityEngine;
using System.Collections;
using System.Linq;

public class AgentsUI : CardsUI<Place>
{
	protected override void Init ()
	{
		TargetContainer = GetComponent<UiObject> ().ShowedObject.GetComponent<Place> ();
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
}

