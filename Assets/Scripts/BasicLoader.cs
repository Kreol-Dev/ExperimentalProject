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
	ScriptEngine engine;

	void Start ()
	{


		List<Assembly> addons = new List<Assembly> ();
		engine = new ScriptEngine (addons);
//		AbstractClassChildren actionsList = new AbstractClassChildren ("Generators", engine){ BaseType = typeof(EventAction) };
		EventActionsLoader loader = new EventActionsLoader ("generators", engine);
		Script genScript = new Script ("generators", loader);
		genScript.LoadFile ("Mods/test.def");
		foreach (var entry in genScript.Entries)
			Debug.Log (entry);
		genScript.Interpret ();
		var compiler = engine.GetPlugin<ScriptCompiler> ();
		compiler.Compile (OnAssemblyCompiled);
	}

	void OnAssemblyCompiled (Assembly asm)
	{
		Debug.Log ("Success");
		engine.AddAssembly (asm);
//		var asmtypes = asm.GetTypes ();
//		foreach (var type in asmtypes)
//		{
//			Debug.Log (type);
//		}
		var types = engine.FindTypesCastableTo<EventAction> ();
		foreach (var type in types)
		{
			Debug.Log (type);
		}
		//AppDomain.CurrentDomain.Load (asm.Location);
	}
	// Update is called once per frame
	void Update ()
	{
	
	}
}


