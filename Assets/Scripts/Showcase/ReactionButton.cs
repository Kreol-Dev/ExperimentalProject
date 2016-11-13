using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ReactionButton : MonoBehaviour
{
	public GameObject Proto { get; set; }
	static Generators gens;

	void Start ()
	{
		if (gens == null)
			gens = FindObjectOfType<Generators> ();
		gameObject.GetComponent<Button> ().onClick.AddListener (OnClick);
	}

	void OnClick ()
	{
        if(Proto != null)
		    gens.Generate (Proto);
        GetComponentInParent<EncounterUi>().Reacted();
	}
}

