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
using System.Runtime.Serialization.Formatters.Binary;
using System.Reflection.Emit;
using System.Linq;

public delegate void VoidDelegate ();
public class BasicLoader : MonoBehaviour, ILoadable
{

	// Use this for initialization
	public ScriptEngine Engine { get; private set; }

	System.Random random = new System.Random ();

	public int Random (int max)
	{
		return random.Next (0, max);
	}

	public int Dsix { get { return random.Next (0, 10); } internal set { } }

	public event VoidDelegate Loaded;

	void Start ()
	{


		List<Assembly> addons = new List<Assembly> ();
		Engine = new ScriptEngine (addons);
//		AbstractClassChildren actionsList = new AbstractClassChildren ("Generators", engine){ BaseType = typeof(EventAction) };
		AppDomain.CurrentDomain.AssemblyResolve += Resolver;
		loadedAsms.Add ("ExternalCode");
		var extr = Engine.GetPlugin<ExternalFunctionsPlugin> ();
		extr.AddProvider (this, "Random", "Dsix");
		extr.Setup (OnExternalsCompiled);

	}

	void OnExternalsCompiled ()
	{
		
		EventActionsLoader loader = new EventActionsLoader ("generators", Engine);
		Script genScript = new Script ("generators", loader);
		genScript.LoadFile ("Mods/test.def");
		foreach (var entry in genScript.Entries)
			Debug.Log (entry);
		genScript.Interpret ();

		var compiler = Engine.GetPlugin<ScriptCompiler> ();
		compiler.Compile (OnAssemblyCompiled);
	}

	HashSet<string> loadedAsms = new HashSet<string> ();

	StringBuilder builder = new StringBuilder ();

	Assembly Resolver (object sender, ResolveEventArgs args)
	{
		Debug.LogWarning (string.Format ("RESOLVE {0} = {1}", args.Name, loadedAsms.Contains (args.Name)));

		var asms = AppDomain.CurrentDomain.GetAssemblies ();
		builder.Length = 0;
		foreach (var a in asms)
			builder.AppendLine (a.GetName ().Name);
		Debug.LogWarning (builder.ToString ());
		if (loadedAsms.Contains (args.Name))
			return asms.First (x => x.GetName ().Name == args.Name);
		else
			return Assembly.Load (args.Name);
	}



	void OnAssemblyCompiled (Assembly asm)
	{
		if (asm == null)
			return;
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


