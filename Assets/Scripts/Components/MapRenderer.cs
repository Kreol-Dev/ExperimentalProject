using UnityEngine;
using System.Collections;

public class MapRenderer : MonoBehaviour, ILoadable
{
	public event VoidDelegate Loaded;

	Map map;

	void Awake ()
	{
		map = GetComponent<Map> ();

	}
	// Use this for initialization
	void Start ()
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}

