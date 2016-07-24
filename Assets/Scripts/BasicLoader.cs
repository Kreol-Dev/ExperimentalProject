﻿using UnityEngine;
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
using System.Runtime.Serialization.Formatters.Binary;
using System.Reflection.Emit;

public class BasicLoader : MonoBehaviour
{

	// Use this for initialization
	public ScriptEngine Engine { get; private set; }

	public delegate void VoidDelegate ();

	public event VoidDelegate Loaded;

	void Start ()
	{


		List<Assembly> addons = new List<Assembly> ();
		Engine = new ScriptEngine (addons);
//		AbstractClassChildren actionsList = new AbstractClassChildren ("Generators", engine){ BaseType = typeof(EventAction) };
		EventActionsLoader loader = new EventActionsLoader ("generators", Engine);
		Script genScript = new Script ("generators", loader);
		genScript.LoadFile ("Mods/test.def");
		foreach (var entry in genScript.Entries)
			Debug.Log (entry);
		genScript.Interpret ();
		var compiler = Engine.GetPlugin<ScriptCompiler> ();
		compiler.Compile (OnAssemblyCompiled);
	}

	void OnAssemblyCompiled (Assembly asm)
	{
		Debug.Log ("Success");
		Engine.AddAssembly (asm);
//		byte[] dllAsArray;
//
//		using (MemoryStream stream = new MemoryStream ())
//		{
//			BinaryFormatter formatter = new BinaryFormatter ();
//
//			formatter.Serialize (stream, asm);
//
//			dllAsArray = stream.ToArray ();
//		}
//		File.WriteAllBytes ("MyLibrary.dll", dllAsArray);
		//Debug.Log (asm.CodeBase);
//		var asmtypes = asm.GetTypes ();
//		foreach (var type in asmtypes)
//		{
//			Debug.Log (type);
//		}
		var types = Engine.FindTypesCastableTo<EventAction> ();
		foreach (var type in types)
		{
			Debug.Log (type);
		}
		if (Loaded != null)
			Loaded ();

		//AppDomain.CurrentDomain.Load (asm.Location);
	}
	// Update is called once per frame
	void Update ()
	{
	
	}
}


