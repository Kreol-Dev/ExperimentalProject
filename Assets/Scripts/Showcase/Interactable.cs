using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Interactable : MonoBehaviour
{
    public List<EventAction> Options = new List<EventAction>();

    public delegate void EADelegate(EventAction a);

    public event EADelegate OptionAdded;
    public event EADelegate OptionRemoved;
    public void AddOption(EventAction a)
    {
        a.Root = gameObject;
        if (OptionAdded != null)
            OptionAdded(a);
        Options.Add(a);
    }

    public void RemoveOption(EventAction a)
    {
        if (OptionRemoved != null)
            OptionRemoved(a);
        Options.Remove(a);
    }
}
