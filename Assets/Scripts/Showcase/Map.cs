using UnityEngine;
using System.Collections;

public class Map : MonoBehaviour
{
	public int MapSizeX;
	public int MapSizeY;

	public int MapX ()
	{
		return MapSizeX;
	}

	public int MapY ()
	{
		return MapSizeY;
	}

	void Awake ()
	{
		FindObjectOfType<BasicLoader> ().EFunctions.Add (new BasicLoader.ExternalFunctions (this, "MapX", "MapY"));
	}
}

