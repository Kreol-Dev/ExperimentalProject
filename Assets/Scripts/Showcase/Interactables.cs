using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Interactables : MonoBehaviour
{
    public List<GameObject> Every { get; set; }
    public event GODelegate GOAttached;
    public event GODelegate GODetached;
    void Awake()
    {
        Every = new List<GameObject>();
    }

    public void Attach(GameObject go)
    {
        Every.Add(go);
        var marker = go.GetComponent<InteractablesMarker>();
        if (marker == null)
            marker = go.AddComponent<InteractablesMarker>();
        marker.AttachedTo = this;
        if (GOAttached != null)
            GOAttached(go);
    }

    public void Detach(GameObject go)
    {
        Every.Remove(go);
        if (GODetached != null)
            GODetached(go);
    }

}

public class InteractablesMarker : MonoBehaviour
{
    public Interactables AttachedTo { get; set; }

    void Start()
    {
        if (AttachedTo != null && !AttachedTo.Every.Contains(gameObject))
            AttachedTo.Attach(gameObject);
    }
}