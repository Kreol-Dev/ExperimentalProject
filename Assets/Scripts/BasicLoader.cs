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

	World world;
	EventsController eventsController;
	Player player;

	public void Log (object log)
	{
		Debug.Log (log);
	}

	void Awake ()
	{
		world = UnityEngine.Object.FindObjectOfType<World> ();
		eventsController = UnityEngine.Object.FindObjectOfType<EventsController> ();
		player = UnityEngine.Object.FindObjectOfType<Player> ();
	}

	public World GetWorld ()
	{
		return world;
	}

	public EventsController GetEventsController ()
	{
		return eventsController;
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
			UnityEngine.Object.Destroy (obj);
		else if (obj is MonoBehaviour)
		{
			UnityEngine.Object.Destroy ((obj as MonoBehaviour).gameObject);
		}
	}

	public float Random (float min, float max)
	{
		return Mathf.Lerp (min, max, (float)random.NextDouble ());
	}

	public bool Has (object obj)
	{
		return obj != null;
	}

	public Player GetPlayer ()
	{
		return player;
	}

	public Camp AbstractCamp ()
	{
		return GetComponent<Camp> ();
	}

	public int Dsix { get { return random.Next (0, 10); } internal set { } }

	public event VoidDelegate Loaded;

	void Start ()
	{
		
		List<Assembly> addons = new List<Assembly> ();
		Engine = new ScriptEngine (addons);
		var dirInfo = new DirectoryInfo ("Mods");
		DateTime lastWriteTime = DateTime.MinValue;
		var extr = Engine.GetPlugin<ExternalFunctionsPlugin> ();
		extr.AddProvider (this, "Random", "Dsix", "AbstractCamp", "Has", "GetWorld", "GetEventsController", "SelectFrom", "Log", "String", "GetPlayer", "Destroy");
		foreach (var fileInfo in dirInfo.GetFiles ())
		{
			if (fileInfo.LastWriteTimeUtc > lastWriteTime)
				lastWriteTime = fileInfo.LastWriteTimeUtc;
		}
		var lastBuildString = PlayerPrefs.GetString ("last_build", DateTime.MinValue.ToLongTimeString ());
		if (lastBuildString == null || DateTime.Parse (lastBuildString) < lastWriteTime)
		{
			//loads scripts and set a date

			//		AbstractClassChildren actionsList = new AbstractClassChildren ("Generators", engine){ BaseType = typeof(EventAction) };
			AppDomain.CurrentDomain.AssemblyResolve += Resolver;
			loadedAsms.Add ("ExternalCode");
			loadedAsms.Add ("BlackboardsData");
			extr.Setup (OnExternalsCompiled);
		} else
		{
			//Load dlls
			var asm = Assembly.LoadFile ("DLLs/ExternalCode.dll");
			extr.OnCompiled (asm);
			asm = Assembly.LoadFile ("DLLs/BlackboardsData.dll");
			Engine.AddAssembly (asm);
			asm = Assembly.LoadFile ("DLLs/Content.dll");
			Engine.AddAssembly (asm);


			if (Loaded != null)
				Loaded ();
			//AppDomain.CurrentDomain.Load()

		}




	}

	void OnExternalsCompiled ()
	{
		
		EventActionsLoader loader = new EventActionsLoader ("generators", Engine);
		Script genScript = new Script ("generators", loader);
		genScript.LoadFile ("Mods/test.def");

		BlackboardsLoader bbloader = new BlackboardsLoader (Engine);

		bbloader.AddType (typeof(GameObject), "gameobject");
		bbloader.AddType (typeof(int), "int");
		bbloader.AddType (typeof(float), "float");
		bbloader.AddType (typeof(string), "string");
		bbloader.AddType (typeof(bool), "bool");
		Script blackboardsScript = new Script ("blackboards", bbloader);
		blackboardsScript.LoadFile ("Mods/blackboards.def");

		foreach (var entry in genScript.Entries)
			Debug.Log (entry);

		blackboardsScript.Interpret ();
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

		PlayerPrefs.SetString ("last_build", DateTime.UtcNow.ToLongTimeString ());
		//AppDomain.CurrentDomain.Load (asm.Location);
	}
	// Update is called once per frame
	void Update ()
	{
	
	}
}


