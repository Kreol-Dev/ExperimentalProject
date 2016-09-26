using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class UiObject : MonoBehaviour
{
	[SerializeField]
	GameObject showedObject;


	public GameObject ShowedObject { get { return showedObject; } set { showedObject = value; } }

	void Awake ()
	{
		if (GetComponent<Markers> () == null)
			gameObject.AddComponent<Markers> ();
	}

}

public delegate bool BoolDelegate ();
public class Updated : MonoBehaviour
{
	List<BoolDelegate> delegates = new List<BoolDelegate> ();

	void Update ()
	{
		for (int i = 0; i < delegates.Count; i++)
		{
			bool shouldStop = delegates [i] ();
			if (shouldStop)
			{

				delegates.RemoveAt (i);
				i--;
			}
		}
	}

	public void OnUpdate (BoolDelegate boolDelegate)
	{
		delegates.Add (boolDelegate);
	}
}

