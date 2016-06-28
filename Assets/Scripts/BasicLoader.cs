using UnityEngine;
using System.Collections;
using InternalDSL;
using System.IO;
using System.CodeDom;
using System.Text;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using System;
using Microsoft.CSharp;
using System.Reflection;

public class BasicLoader : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{

		ScriptBundle mainBundle = new ScriptBundle ("Core");
		Script genScript = new Script ("generators", null);
		mainBundle.AddScript (genScript);
		genScript.LoadFile ("Mods/test.def");
		foreach (var entry in genScript.Entries)
			Debug.Log (entry);
		List<object> translators = new List<object> ();
		List<Assembly> addons = new List<Assembly> ();
		ScriptEngine engine = new ScriptEngine (addons);
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}
}
