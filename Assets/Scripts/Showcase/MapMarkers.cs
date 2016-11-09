using UnityEngine;
using System.Collections;

public class MapMarkers : MonoBehaviour
{
	public GameObject Marker;
    public GameObject DetailedMarker;
	void Awake ()
	{
		FindObjectOfType<BasicLoader> ().EFunctions.Add (new BasicLoader.ExternalFunctions (this, "MapEnlist", "MapEnlistDetailed"));
	}

    public void MapEnlistDetailed(GameObject go)
    {
        Enlist(go, DetailedMarker);
    }
	public void MapEnlist (GameObject go)
	{
        Enlist(go, Marker);

	}

    void Enlist(GameObject go, GameObject markerPrefab)
    {
        var markerGo = Instantiate(markerPrefab) as GameObject;
        markerGo.transform.SetParent(transform, false);
        var mapMarker = markerGo.GetComponent<MapMarker>();
        var mapAnchor = markerGo.GetComponent<AnchoredUI>();
        mapAnchor.Anchor = go;
        //markerGo.transform.SetParent (go.transform, false);
        //markerGo.GetComponent<RectTransform> ().position = Vector3.zero;
        markerGo.GetComponent<UiObject>().ShowedObject = go;

        var named = go.GetComponent<Named>();
        if (named != null)
        {
            VoidDelegate del = () => mapMarker.Text = named.Get("main_name");
            named.Updated += del;
            go.GetComponent<Entity>().Destoryed += g => named.Updated -= del;
            mapMarker.Text = named.Get("main_name");
        }

        var portrait = go.GetComponent<Portrait>();
        if (portrait != null)
        {
            mapMarker.Portrait = portrait;
        }
    }


}

