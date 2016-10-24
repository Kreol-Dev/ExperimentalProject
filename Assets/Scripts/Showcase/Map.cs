using UnityEngine;
using System.Collections;

public class Map : MonoBehaviour
{
	public GameObject Marker;

	void Awake ()
	{
		FindObjectOfType<BasicLoader> ().EFunctions.Add (new BasicLoader.ExternalFunctions (this, "MapEnlist"));
	}

	public void MapEnlist (GameObject go)
	{
		var markerGo = Instantiate (Marker) as GameObject;
		markerGo.transform.SetParent (transform);
		var ancUI = markerGo.GetComponent<AnchoredUI> ();
		var mapMarker = markerGo.GetComponent<MapMarker> ();

		ancUI.Anchor = go;
		mapMarker.ShowedObject = go;

		var named = go.GetComponent<Named> ();
		if (named != null)
		{
			VoidDelegate del = () => mapMarker.Text = named.FullName;
			named.Updated += del;
			go.GetComponent<Entity> ().Destoryed += g => named.Updated -= del;
			mapMarker.Text = named.FullName;
		}

		var portrait = go.GetComponent<Portrait> ();
		if (portrait != null)
		{
			mapMarker.Portrait = portrait;
		}

	}
}

