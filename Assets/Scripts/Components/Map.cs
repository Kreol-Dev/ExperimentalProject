using UnityEngine;
using System.Collections;

public class Map : MonoBehaviour, ILoadable
{
	public event VoidDelegate Loaded;

	Space space;

	public int SizeX { get { return (int)space.Size.x; } }

	public int SizeY { get { return (int)space.Size.y; } }

	DependencyWaiter waiter;

	void Awake ()
	{
		space = GetComponent<Space> ();
		waiter = new DependencyWaiter (OnLoad, space);
	}


	void OnLoad ()
	{


		if (Loaded != null)
			Loaded ();
	}
}

