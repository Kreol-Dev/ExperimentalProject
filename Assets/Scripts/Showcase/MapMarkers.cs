using UnityEngine;
using System.Collections;

public class MapMarkers : MonoBehaviour
{
	public GameObject Marker;

	void Awake ()
	{
		FindObjectOfType<BasicLoader> ().EFunctions.Add (new BasicLoader.ExternalFunctions (this, "MapEnlist"));
	}

	public void MapEnlist (GameObject go)
	{
		var markerGo = Instantiate (Marker) as GameObject;
		markerGo.transform.SetParent (transform, false);
		var mapMarker = markerGo.GetComponent<MapMarker> ();
		var mapAnchor = markerGo.GetComponent<AnchoredUI> ();
		mapAnchor.Anchor = go;
		//markerGo.transform.SetParent (go.transform, false);
		//markerGo.GetComponent<RectTransform> ().position = Vector3.zero;
		mapMarker.ShowedObject = go;

		var named = go.GetComponent<Named> ();
		if (named != null)
		{
			VoidDelegate del = () => mapMarker.Text = named.Get ("main_name");
			named.Updated += del;
			go.GetComponent<Entity> ().Destoryed += g => named.Updated -= del;
			mapMarker.Text = named.Get ("main_name");
		}

		var portrait = go.GetComponent<Portrait> ();
		if (portrait != null)
		{
			mapMarker.Portrait = portrait;
		}

	}
}

