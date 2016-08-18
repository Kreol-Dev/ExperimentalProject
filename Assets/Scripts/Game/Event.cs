using UnityEngine;
using System.Collections;

public class Event : MonoBehaviour
{

	public Actor Actor { get; set; }

	public MonoBehaviour Action { get; set; }

	public Event Result { get; set; }


	void Start ()
	{
		string eventDesc = string.Format ("{0} {1} {2}", Actor, Action, Result);
		FindObjectOfType<EventsController> ().EventDescription (eventDesc);
	}
}

