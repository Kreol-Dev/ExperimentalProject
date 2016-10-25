using UnityEngine;
using System.Collections;

public class Billboard : MonoBehaviour
{

	void Update ()
	{
		var camT = Camera.main.transform;
		transform.LookAt (camT, Vector3.up);
		transform.Rotate (new Vector3 (0, 180, 0));
	}
}

