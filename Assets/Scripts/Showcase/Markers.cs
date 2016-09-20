using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Markers : MonoBehaviour
{

	public List<string> markers;

	public bool HasMarker (string marker)
	{
		bool found = false;
		if (markers != null)
			found = markers.FindIndex (x => x == marker) >= 0;
		return found;
	}
}

