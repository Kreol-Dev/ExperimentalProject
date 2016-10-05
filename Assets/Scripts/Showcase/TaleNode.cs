using UnityEngine;
using System.Collections;

public class TaleNode : MonoBehaviour
{

	public bool IsActive { get; set; }

	static Generators gens;

	void Awake ()
	{
		if (gens == null)
			gens = FindObjectOfType<Generators> ();
		IsActive = false;
	}

	void Start ()
	{
		StartCoroutine (GenerateCoroutine ());
	}

	IEnumerator GenerateCoroutine ()
	{
		while (IsActive)
		{
			gens.GenerateMostUseful (gameObject, 0.1f);
			yield return null;

		}
	}


}

