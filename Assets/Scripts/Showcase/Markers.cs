using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Markers : MonoBehaviour
{
	public List<string> Flags { get { return markers; } set { markers = value; } }

	public List<string> markers;
	List<string> uiMarkers = new List<string> ();
    public void ClearUIMarkers()
    {
        uiMarkers.Clear();
    }
	void Awake ()
	{
		if (markers == null)
			markers = new List<string> ();
		
	}

	public bool HasMarker (string marker)
	{
		bool found = false;
		if (markers != null)
			found = markers.FindIndex (x => x == marker) >= 0;
		if (!found)
			found = uiMarkers.FindIndex (x => x == marker) >= 0;
		return found;
	}

	public void SetMarker (string marker)
	{
		markers.Add (marker);
	}

	public void SetUiMarker (string marker)
	{
		uiMarkers.Add (marker);
	}
}

