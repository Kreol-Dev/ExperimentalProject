using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Space : MonoBehaviour
{
	public List<Place> Places { get; internal set; }
	public int size;
    public bool SceneSpace = false;
    static Dictionary<string, Space> hardcodedSpaces = new Dictionary<string, Space>();

	public int Size { get { return size; } set { size = value; } }

    public static Space GetSpace(string name)
    {
        Space space = null;
        hardcodedSpaces.TryGetValue(name, out space);
        return space;
    }
    static bool provided = false;
	void Awake ()
	{
        if(!provided)
        {
            FindObjectOfType<BasicLoader>().EFunctions.Add(new BasicLoader.ExternalFunctions(this, "GetSpace"));
            provided = true;
        }
        if (SceneSpace)
            hardcodedSpaces.Add(NameTranslator.ScriptNameFromCSharp(gameObject.name), this);
		Places = new List<Place> ();
	}


	public delegate void PlaceDelegate (Place place);

	public event PlaceDelegate PlaceAttached;
	public event PlaceDelegate PlaceDetached;

	public bool Attach (Place place)
	{
		if (Size <= Places.Count)
			return false;
		if (PlaceAttached != null)
			PlaceAttached (place);
		var marker = place.GetComponent<SpaceMarker> ();
		if (marker == null)
			marker = place.gameObject.AddComponent<SpaceMarker> ();
		marker.CurrentSpace = this;
		Places.Add (place);
		return true;
	}

	public void Detach (Place place)
	{
		if (PlaceDetached != null)
			PlaceDetached (place);
		Places.Remove (place);
	}

}

public class SpaceMarker : MonoBehaviour
{
	public Space CurrentSpace { get; set; }

	void OnDestroy ()
	{
		if (CurrentSpace != null)
			CurrentSpace.Detach (GetComponent<Place> ());
	}

	void Start ()
	{
		var place = GetComponent<Place> ();
		if (!CurrentSpace.Places.Contains (place))
		if (!CurrentSpace.Attach (place))
		{
			CurrentSpace = null;
			var ent = GetComponent<Entity> ();
			if (ent != null)
				ent.Destroy ();
			else
				Destroy (gameObject);
		}
	}
}