using UnityEngine;
using System.Collections;

public class GlobalData : MonoBehaviour
{
    public GameObject Global {  get { return gameObject; } }
    void Awake()
    {
        FindObjectOfType<BasicLoader>().EFunctions.Add(new BasicLoader.ExternalFunctions(this, "Global"));
    }

}
