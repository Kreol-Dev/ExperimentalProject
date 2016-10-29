using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;

public class SelectableMarker : MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler
{
    static SelectionManager selectionManager;
    static SelectableMarker previousSelection;
    public event VoidDelegate Selected;
    public event VoidDelegate Deselected;
    public UiObject uiObject;

    void Awake()
    {
        if (selectionManager == null)
            selectionManager = FindObjectOfType<SelectionManager>();
    }
    public void NotifyAboutDeselection()
    {
        if(Deselected != null)
            Deselected();
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("click!");
        if (eventData.button != PointerEventData.InputButton.Left)
            return;
        if(previousSelection != this)
        {
            if(previousSelection != null)
                previousSelection.NotifyAboutDeselection();
            previousSelection = this;
            if (Selected != null)
                Selected();
            selectionManager.Select(uiObject.ShowedObject);
        }
       

    }

    public void OnPointerDown(PointerEventData eventData)
    {
    }

    public void OnPointerUp(PointerEventData eventData)
    {
    }
}
