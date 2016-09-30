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
using System.Threading;

public delegate void VoidDelegate ();
public class BasicLoader : MonoBehaviour
{

	// Use this for initialization
	public ScriptEngine Engine { get; private set; }

	List<ProgressBar> pluginBars = new List<ProgressBar> ();
	System.Random random = new System.Random ();

	public class ExternalFunctions
	{
		public object Provider;
		public string[] Functions;

		public ExternalFunctions (object provider, params string[] functions)
		{
			Provider = provider;
			Functions = functions;
		}
	}

	public List<ExternalFunctions> EFunctions = new List<ExternalFunctions> ();

	public void Log (object log)
	{
		Debug.Log (log);
	}

	void Awake ()
	{

	}




	public delegate bool SelectionDelegate (GameObject go);

	public GameObject SelectFrom (List<GameObject> list, SelectionDelegate checker)
	{
		for (int i = 0; i < list.Count; i++)
			if (checker (list [i]))
				return list [i];
		return null;
	}

	public void Destroy (UnityEngine.Object obj)
	{
		if (obj is GameObject)
		{
			((GameObject)obj).GetComponent<Entity> ().Destroy ();
		} else if (obj is MonoBehaviour)
		{
			UnityEngine.Object.Destroy ((obj as MonoBehaviour).gameObject);
		}
	}

	public float Random (float min, float max)
	{
		return Mathf.Lerp (min, max, (float)random.NextDouble ());
	}

	public GameObject NoOne ()
	{
		return null;
	}

	public bool Has (object obj)
	{
		return !(ReferenceEquals (obj, null) || obj.Equals (null));
	}


	public int Dsix { get { return random.Next (0, 10); } internal set { } }

	public event VoidDelegate Loaded;

	void Start ()
	{
		StartCoroutine (LoadCoroutine ());
		StartCoroutine (UpdateCoroutine ());
	}

	Thread compileThread;

	void OnDestroy ()
	{
		Engine.Working = false;
	}

	IEnumerator LoadCoroutine ()
	{

		List<Assembly> addons = new List<Assembly> ();
		Engine = new ScriptEngine (addons);
		var dirInfo = new DirectoryInfo ("Mods");
		DateTime lastWriteTime = DateTime.MinValue;
		var ExternalFunctions = Engine.GetPlugin<ExternalFunctionsPlugin> ();
		var bars = FindObjectOfType<ProgressBarSet> ();
		genBar = bars.CreateBar (Color.yellow);
		for (int i = 0; i < Engine.PluginsCount; i++)
			pluginBars.Add (bars.CreateBar (Color.blue));
		ExternalFunctions.Load ();
		foreach (var eFunctions in EFunctions)
			ExternalFunctions.AddProvider (eFunctions.Provider, eFunctions.Functions);
		ExternalFunctions.AddProvider (this, "Random", "Dsix", "AbstractCamp", "Has", "GetWorld", "GetEventsController", "SelectFrom", "Log", "String", "GetPlayer", "Destroy", "NoOne");
		foreach (var fileInfo in dirInfo.GetFiles ())
		{
			if (fileInfo.LastWriteTimeUtc > lastWriteTime)
				lastWriteTime = fileInfo.LastWriteTimeUtc;
		}
		var lastBuildString = PlayerPrefs.GetString ("last_build");
		Debug.Log (lastBuildString);
		Debug.Log (lastWriteTime);
		if (String.IsNullOrEmpty (lastBuildString) || (!String.IsNullOrEmpty (lastBuildString) && DateTime.Parse (lastBuildString) < lastWriteTime))
		{
			Debug.Log ("Loading scripts");
			yield return null;
			//loads scripts and set a date

			//		AbstractClassChildren actionsList = new AbstractClassChildren ("Generators", engine){ BaseType = typeof(EventAction) };
			AppDomain.CurrentDomain.AssemblyResolve += Resolver;
			loadedAsms.Add ("ExternalCode");
			loadedAsms.Add ("BlackboardsData");
			bbloader = new BlackboardsLoader (Engine);
			bbloader.Init ();
			eaBar = FindObjectOfType<ProgressBarSet> ().CreateBar (Color.green);
			compileThread = new Thread (() => ExternalFunctions.Setup (OnExternalsCompiled));
			compileThread.Start ();
		} else
		{
			Debug.Log ("Loading dlls");
			yield return null;
			//Load dlls
			var asm = Assembly.LoadFile ("DLLs/ExternalCode.dll");
			ExternalFunctions.OnCompiled (asm);
			asm = Assembly.LoadFile ("DLLs/BlackboardsData.dll");
			Engine.AddAssembly (asm);
			asm = Assembly.LoadFile ("DLLs/Content.dll");
			Engine.AddAssembly (asm);

			yield return null;

			foreach (var bar in this.pluginBars)
				bar.Expire ();
			if (Loaded != null)
				Loaded ();
			//AppDomain.CurrentDomain.Load()

		}




	}

	BlackboardsLoader bbloader;
	ProgressBar eaBar;
	ProgressBar genBar;

	void OnExternalsCompiled ()
	{
		var loader = new EventActionsLoader ("generators", Engine);
		loader.CurProgressUpdated += x => eaBar.CurValue = x;
		loader.CurProgressUpdated += x => {
			if (x == eaBar.MaxValue)
			{
				eaBar.Expire ();
			}
		};
		loader.MaxProgressResolved += x => eaBar.MaxValue = x;
		Script genScript = new Script ("generators", loader, Engine);
		genScript.Progress.CurProgressUpdated += x => genBar.CurValue = x;
		genScript.Progress.CurProgressUpdated += x => {
			if (x == genBar.MaxValue)
			{
				genBar.Expire ();
			}
		};
		genScript.Progress.MaxProgressResolved += x => genBar.MaxValue = x;
		genScript.LoadFile ("Mods/test.def");

	

		bbloader.AddType (typeof(GameObject), "gameobject");
		bbloader.AddType (typeof(int), "int");
		bbloader.AddType (typeof(float), "float");
		bbloader.AddType (typeof(string), "string");
		bbloader.AddType (typeof(bool), "bool");
		Script blackboardsScript = new Script ("blackboards", bbloader, Engine);
		blackboardsScript.LoadFile ("Mods/blackboards.def");

		foreach (var entry in genScript.Entries)
			Debug.Log (entry);

		blackboardsScript.Interpret ();
		int pluginId = 0;
		foreach (var plugin in Engine.Plugins)
		{
			var bar = pluginBars [pluginId++];
			plugin.CurProgressUpdated += x => bar.CurValue = x;
			plugin.CurProgressUpdated += x => {
				if (x == bar.MaxValue)
				{
					bar.Expire ();
				}
			};
			plugin.MaxProgressResolved += x => bar.MaxValue = x;
			plugin.MaxProgressResolved += x => {
				if (x == -1)
				{
					bar.Expire ();
				}
			};
		}
		Engine.InitPlugins ();

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

	object asmLock = new object ();
	Assembly loadedAsm;

	void OnAssemblyCompiled (Assembly asm)
	{
		lock (asmLock)
		{

			loadedAsm = asm;
		}
	}

	void OnRetrievedAsm ()
	{
		lock (asmLock)
		{
			Debug.Log ("Success");
			Engine.AddAssembly (loadedAsm);
			var types = Engine.FindTypesCastableTo<EventAction> ();
			foreach (var type in types)
			{
				Debug.Log (type);
			}
			if (Loaded != null)
				Loaded ();

			PlayerPrefs.SetString ("last_build", DateTime.UtcNow.ToString ());
			//AppDomain.CurrentDomain.Load (asm.Location);
		}

	}

	IEnumerator UpdateCoroutine ()
	{

		while (true)
		{
			
			yield return null;
			if (loadedAsm == null)
				continue;
			compileThread.Join ();
			OnRetrievedAsm ();
			break;
		}
	}
}

