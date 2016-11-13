using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InteractableUI : MonoBehaviour
{

    Dictionary<EventAction, GameObject> eaToUi = new Dictionary<EventAction, GameObject>();
    static ObjectPool<GameObject> pool = new ObjectPool<GameObject>();
    public GameObject InteractionButtonProto;
    Interactable inter;
    
    void OnEnable()
    {
        eaToUi.Clear();
    }
    public Interactable TargetInteractable {  get { return inter; }
        set
        {
            if(inter != null)
            {
                inter.OptionAdded -= OnInteractionAdded;
                inter.OptionRemoved -= OnInteractionRemoved;
                foreach (var ea in inter.Options)
                    OnInteractionRemoved(ea);
            }

            inter = value;
            inter.OptionAdded += OnInteractionAdded;
            inter.OptionRemoved += OnInteractionRemoved;
            foreach (var ea in inter.Options)
                OnInteractionAdded(ea);
        }
    }

    void OnInteractionAdded(EventAction ea)
    {
        GameObject interButton;
        if (pool.HasFreeObjects)
            interButton = pool.Get();
        else
            interButton = GameObject.Instantiate(InteractionButtonProto);
        Debug.Log(interButton);
        interButton.transform.SetParent(transform);
        interButton.GetComponent<InteractionButton>().EventAction = ea;
        eaToUi.Add(ea, interButton);
        interButton.SetActive(true);
    }
    
    void OnInteractionRemoved(EventAction ea)
    {

        var interButton = eaToUi[ea];
        eaToUi.Remove(ea);
        interButton.transform.SetParent(null);
        interButton.SetActive(false);
        pool.Return(interButton);
    }

    void OnDestroy()
    {
        inter.OptionAdded -= OnInteractionAdded;
        inter.OptionRemoved -= OnInteractionRemoved;

        foreach(var ui in eaToUi.Values)
        {
            ui.transform.SetParent(null);
            ui.SetActive(false);
        }
        eaToUi.Clear();
    }
}
