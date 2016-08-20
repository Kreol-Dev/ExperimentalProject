using UnityEngine;
using System.Collections;

public class Event : MonoBehaviour
{

	public Actor Involved { get; set; }

	public MonoBehaviour Action { get; set; }

	public Event Result { get; set; }

	void Start ()
	{
		FindObjectOfType<Generators> ().Generate (gameObject);
	}

}

