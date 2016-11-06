using UnityEngine;
using System.Collections;

public class GenerateMarker : MonoBehaviour
{

	Generators gens;
	SavingLoading saver;

	void Awake ()
	{
		gens = FindObjectOfType<Generators> ();
		saver = FindObjectOfType<SavingLoading> ();
        //wait = Random.Range(1, 4);
	}
	void Update ()
	{
		if (gens.Loaded && !saver.IsLoading)
		{
			gens.Generate (gameObject);
			Destroy (this);
		}
	}
}

