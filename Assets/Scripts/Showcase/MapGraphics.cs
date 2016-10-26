using UnityEngine;
using System.Collections;

public class MapGraphics : MonoBehaviour
{

	public Map Map;

	void Awake ()
	{
		var rect = GetComponent<RectTransform> ();
		rect.sizeDelta = new Vector2 (Map.MapX (), Map.MapY ());
	}
}

