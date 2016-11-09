using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class People : MonoBehaviour
{
    public List<GameObject> Everyone { get; set; }

    void Awake()
    {
        Everyone = new List<GameObject>();
    }

}
