using UnityEngine;
using System.Collections;

public class EntityKiller : MonoBehaviour
{

	void Start ()
	{
		GetComponent<Entity> ().Destroy ();
	}
}

