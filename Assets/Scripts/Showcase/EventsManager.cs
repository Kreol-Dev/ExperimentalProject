using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class EventsManager : MonoBehaviour
{
    public GameObject EncounterUIProto;
    void Awake()
    {
        FindObjectOfType<BasicLoader>().EFunctions.Add(new BasicLoader.ExternalFunctions(this, "EnlistEncounter"));
    }

    public void EnlistEncounter(GameObject encounterGO)
    {
        var uiInstance = GameObject.Instantiate(EncounterUIProto);
        var uiCmp = uiInstance.GetComponent<EncounterUI>();
        uiCmp.Encounter = encounterGO.GetComponent<Encounter>();
        uiInstance.transform.SetParent(transform, false);
        
    }
}