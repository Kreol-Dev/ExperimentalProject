using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System;

public class InteractionButton : MonoBehaviour
{

    public EventAction EventAction;

    public Button Button;
    static int count = 0;
    bool increasedCount = false;
    static int nextId = 0;
    static Stack<int> freeIDs = new Stack<int>(); 

    int id = -1;
    void Awake()
    {
        if (freeIDs.Count > 0)
            id = freeIDs.Pop();
        else
            id = nextId++;
        count++;
    }

    void OnEnable()
    {
        GetComponent<HoverTooltip>().Text = EventAction.Meta.Tooltip;
        Button.GetComponentInChildren<Text>().text = EventAction.GetType().Name;
        Button.onClick.AddListener( OnClick);
        StartCoroutine(UpdateCoroutine());
    }
    
    void OnClick()
    {
        if(EventAction.Utility() > 0)
        EventAction.Action();
    }

    IEnumerator UpdateCoroutine()
    {
        int counter = 0;
        while(true)
        {
            if (counter == count)
                counter = 0;
            if(counter == id)
            {
                UpdateActionState();
            }
            counter++;
            yield return null;
        }
    }

    private void UpdateActionState()
    {
        var ut = EventAction.Utility();
        if (ut > 0)
        {
            Button.enabled = true;
        }
        else
        {
            Button.enabled = false;
        }
    }

    void OnDestroy()
    {
        if (id >= 0)
        {
            count--;
            freeIDs.Push(id);
        }
    }
}
