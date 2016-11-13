using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class InteractablesUI : CardsUI<Interactables>
{
    protected override void Init()
    {
        base.Init();
        MovableCards = false;
    }
    public Interactables TargetInteractables {  get { return TargetContainer;  }  set { TargetContainer = value; } }
    public override List<GameObject> GetContainer(Interactables targetContainer)
    {
        return targetContainer.Every;
    }

    public override void SubscribeToAttachementEvent(Interactables targetContainer, GODelegate del)
    {
        targetContainer.GOAttached += del;
    }

    public override void SubscribeToDetachmentEvent(Interactables targetContainer, GODelegate del)
    {
        targetContainer.GODetached += del;
    }

    public override void UnSubscribeToAttachementEvent(Interactables targetContainer, GODelegate del)
    {
        targetContainer.GOAttached -= del;
    }

    public override void UnSubscribeToDetachmentEvent(Interactables targetContainer, GODelegate del)
    {
        targetContainer.GODetached -= del;
    }
}
