using UnityEngine;
using System.Collections;

public class UiAttached : MonoBehaviour {

    public RectTransform AttachedTo;
    Vector3 startPos;
    public bool OnTop = true;
    void Start()
    {
        startPos = transform.position;
    }
    void Update()
    {
        if (AttachedTo.gameObject.activeInHierarchy)
        {
            var t = GetComponent<RectTransform>();
            var v = t.position;
            
            if(OnTop)
                v.y = AttachedTo.sizeDelta.y + AttachedTo.position.y;
            else
                v.y = AttachedTo.position.y - AttachedTo.sizeDelta.y;

            t.position = v;
        }
        else
            transform.position = startPos;
    }
}
