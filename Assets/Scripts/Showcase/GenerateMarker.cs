using UnityEngine;
using System.Collections;

public class GenerateMarker : MonoBehaviour
{

	Generators gens;

	void Awake ()
	{
		gens = FindObjectOfType<Generators> ();
	}

	void Update ()
	{
		if (gens.Loaded)
		{
			gens.Generate (gameObject);
			Destroy (this);
		}
	}
}

