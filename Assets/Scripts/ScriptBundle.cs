using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

public class ScriptBundle
{
	List<Script> scripts = new List<Script> ();
	List<ScriptBundle> dependencies = new List<ScriptBundle> ();
	List<string> sources = new List<string> ();

	public Assembly Assembly { get; internal set; }

	public IEnumerable<ScriptBundle> Dependencies { get { return dependencies; } }

	public string[] CShapCode {
		get
		{
			return sources.ToArray ();
		}
	}

	public bool Compiled { get; internal set; }

	public string Name { get; internal set; }

	public ScriptBundle (string name)
	{
		Name = name;
		Compiled = false;
	}

	public void AddScript (Script script)
	{
		scripts.Add (script);
	}

	public void AddDependency (ScriptBundle bundle)
	{
		dependencies.Add (bundle);
	}

	public void OnCompiled (Assembly asm)
	{
		Compiled = true;
		Assembly = asm;
	}
}
