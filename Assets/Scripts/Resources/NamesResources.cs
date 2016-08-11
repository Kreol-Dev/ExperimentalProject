using UnityEngine;
using System.Collections;

using System.Collections.Generic;
using System.IO;

public class NamesResources : MonoBehaviour
{

	List<string> firstNames = new List<string> ();
	List<string> secondNames = new List<string> ();

	void Awake ()
	{
		var names = File.ReadAllLines ("Mods/names.txt");
		foreach (var name in names)
			firstNames.Add (name);

		names = File.ReadAllLines ("Mods/second_names.txt");
		foreach (var name in names)
			secondNames.Add (name);
	}
}

