using UnityEngine;
using System.Collections;
using InternalDSL;
using System.IO;

public class BasicLoader : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		var openedFile = File.OpenText ("Mods/test.def");

		DefTokenizer tokenizer = new DefTokenizer (openedFile);
		var node = tokenizer.Next ();
//		while (node != null)
//		{
//			Debug.Log (node);
//			node = tokenizer.Next ();
//		}
		openedFile.Close ();
		openedFile = File.OpenText ("Mods/test.def");
		DefParser parser = new DefParser (openedFile);
		var parseNode = parser.Parse ();
		openedFile.Close ();
		Root root = new Root (parseNode);
		root.Show ();
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
