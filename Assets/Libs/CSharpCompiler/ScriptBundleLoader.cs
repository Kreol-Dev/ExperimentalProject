using System.Collections.Generic;
using System.Reflection;
using System.CodeDom.Compiler;
using System.IO;
using System.ComponentModel;
using System.Linq;
using System;

namespace CSharpCompiler
{
	public class ScriptBundleLoader
	{

		public TextWriter logWriter = Console.Out;

		ISynchronizeInvoke synchronizedInvoke;
		List<ScriptBundle> allFilesBundle = new List<ScriptBundle> ();

		public ScriptBundleLoader (ISynchronizeInvoke synchronizedInvoke)
		{
			this.synchronizedInvoke = synchronizedInvoke;
		}

		public ScriptBundle LoadScriptsBundle (IEnumerable<string> sources)
		{
			var bundle = new ScriptBundle (this, sources);
			allFilesBundle.Add (bundle);
			return bundle;
		}

		/// <summary>
		/// Manages a bundle of files which form one assembly, if one file changes entire assembly is recompiled.
		/// </summary>
		public class ScriptBundle
		{
			public Assembly assembly;
			IEnumerable<string> sources;
			ScriptBundleLoader manager;

			string[] assemblyReferences;

			public ScriptBundle (ScriptBundleLoader manager, IEnumerable<string> sources)
			{
				this.sources = sources;
				this.manager = manager;


				var domain = System.AppDomain.CurrentDomain;
				this.assemblyReferences = domain.GetAssemblies ().Select (a => a.Location).ToArray ();

//				manager.logWriter.WriteLine ("loading " + string.Join (", ", sources.ToArray ()));
				CompileFiles ();
			}

			void CompileFiles ()
			{

				var options = new CompilerParameters ();
				options.GenerateExecutable = false;
				options.GenerateInMemory = true;
				options.ReferencedAssemblies.AddRange (assemblyReferences);

				var compiler = new CodeCompiler ();
				var result = compiler.CompileAssemblyFromSourceBatch (options, sources.ToArray ());

				foreach (var err in result.Errors)
				{
					manager.logWriter.WriteLine (err);
				}

				this.assembly = result.CompiledAssembly;
			}


		}


	}

}