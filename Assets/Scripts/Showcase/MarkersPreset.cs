using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MarkersPreset : MonoBehaviour
{

    public List<string> Markers;
    void Awake()
    {
        var ms = GetComponent<Markers>();
        foreach (var marker in Markers)
            ms.SetMarker(marker);
    }

}
