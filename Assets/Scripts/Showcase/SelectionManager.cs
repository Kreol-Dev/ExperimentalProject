using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SelectionManager : MonoBehaviour
{

    static Generators gens;
    public UiObject ui;
    public SelectableMarker LastSelection;
    void Awake()
    {
        if(gens == null)
            gens = FindObjectOfType<Generators>();
    }

    void Update()
    {
        if(Input.GetMouseButtonUp(1))
        {
            Select(null);
            if(LastSelection != null)
            LastSelection.NotifyAboutDeselection();
            LastSelection = null;
        }
    }
    
    public void Select(GameObject go)
    {
        if(go != null)
        go.GetComponent<Entity>().Destoryed += g => Select(null);
        ui.ShowedObject = go;
        ui.GetComponent<Entity>().ClearSiblings();
        ui.GetComponent<Markers>().ClearUIMarkers();
        if(go != null)
            gens.Generate(ui.gameObject);
    }
}
