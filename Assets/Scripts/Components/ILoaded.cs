using UnityEngine;
using System.Collections;
using System;

public interface ILoadable
{
	event VoidDelegate Loaded;
}


public class DependencyWaiter
{
	int counter;
	Action onLoad;
	ILoadable[] loadables;

	public DependencyWaiter (Action onLoad, params ILoadable[] loadables)
	{
		counter = loadables.Length;
		this.onLoad = onLoad;
		for (int i = 0; i < loadables.Length; i++)
			loadables [i].Loaded += OnLoaded;
		this.loadables = loadables;
	}

	void OnLoaded ()
	{
		counter--;
		if (counter == 0)
		{
			for (int i = 0; i < loadables.Length; i++)
				loadables [i].Loaded -= OnLoaded;
			onLoad ();
		}	
		
	}


}