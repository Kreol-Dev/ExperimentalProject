using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class World : MonoBehaviour
{
	public List<GameObject> Objects { get; internal set; }

	public string Name { get; set; }

	void Awake ()
	{
		Objects = new List<GameObject> ();
	}

	public void Attach (GameObject go)
	{
		Objects.Add (go);
		Debug.Log (Objects.Count);
	}

	public void Detach (GameObject go)
	{
		Objects.Remove (go);
		Debug.Log (Objects.Count);
	}
}

