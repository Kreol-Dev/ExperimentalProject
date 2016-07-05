using System;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using System.Reflection;




namespace CSharpCompiler
{

	public class ScriptsLoader : MonoBehaviour
	{

		DeferredSynchronizeInvoke synchronizedInvoke;
		CSharpCompiler.ScriptBundleLoader loader;

		void Start ()
		{
			synchronizedInvoke = new DeferredSynchronizeInvoke ();

			loader = new CSharpCompiler.ScriptBundleLoader (synchronizedInvoke);

			loader.logWriter = new UnityLogTextWriter ();
		}

		void Update ()
		{
			synchronizedInvoke.ProcessQueue ();
			if (bundle.assembly != null)
			{
				onAssemblyCompiled (bundle.assembly);
				bundle.assembly = null;
				Destroy (this);
			}
		}

		Action<Assembly> onAssemblyCompiled;
		ScriptBundleLoader.ScriptBundle bundle;

		public void Load (string[] sources, Action<Assembly> onAssemblyCompiled)
		{
			this.onAssemblyCompiled = onAssemblyCompiled;
			bundle = loader.LoadScriptsBundle (sources);
		

		}



	}
}

