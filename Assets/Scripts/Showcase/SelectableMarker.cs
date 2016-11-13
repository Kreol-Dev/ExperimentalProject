using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;

public class SelectableMarker : MonoBehaviour, IPointerClickHandler, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField]
    SelectionManager selectionManager;
    public event VoidDelegate Selected;
    public event VoidDelegate Deselected;
    public UiObject uiObject;
    public string TargetManager;
    void Awake()
    {
        if (selectionManager == null)
            selectionManager = GameObject.Find(TargetManager).GetComponent<SelectionManager>();
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
        if(selectionManager.LastSelection != this)
        {
            if(selectionManager.LastSelection != null)
                selectionManager.LastSelection.NotifyAboutDeselection();
            selectionManager.LastSelection = this;
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
