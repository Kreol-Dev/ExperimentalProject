using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SelectionManager : MonoBehaviour
{

    static Generators gens;
    public UiObject ui;

    void Awake()
    {
        if(gens == null)
            gens = FindObjectOfType<Generators>();
    }
    
    public void Select(GameObject go)
    {
        ui.ShowedObject = go;
        ui.GetComponent<Entity>().ClearSiblings();
        ui.GetComponent<Markers>().ClearUIMarkers();
        gens.Generate(ui.gameObject);
    }
}
