using UnityEngine;
using System.Collections;

public class UiAttached : MonoBehaviour {

    public RectTransform AttachedTo;
    Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }
    void Update()
    {
        if (AttachedTo.gameObject.activeInHierarchy)
        {
            var t = transform;
            var v = transform.position;
            v.y = AttachedTo.sizeDelta.y;
            transform.position = v;
        }
        else
            transform.position = startPos;
    }
}
