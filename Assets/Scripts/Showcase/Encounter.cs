using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Encounter : MonoBehaviour
{
    
    public GameObject Context { get; set; }
	public List<GameObject> reactProtos = new List<GameObject> ();

	public event GODelegate NewReaction;

	public void Reaction (GameObject reactProto)
	{
		reactProtos.Add (reactProto);
		if (NewReaction != null)
			NewReaction (reactProto);
	}

    void Awake()
    {
        var e = GetComponent<Event>();
        if(e != null)
            e.ShouldBeDestroyed = false;
    }
}

