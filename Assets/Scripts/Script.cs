using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using InternalDSL;
using System;

public class Script
{
	public string Name { get; internal set; }

	public List<Operator> Entries { get; internal set; }

	ScriptInterpreter interpreter;

	public Script (string name, ScriptInterpreter interpreter)
	{
		Name = name;
		Entries = new List<Operator> ();
		this.interpreter = interpreter;
	}

	public void LoadFile (string filepath)
	{
		string source = File.ReadAllText (filepath);
		if (source == null)
		{
			Debug.Log ("Can't find file " + filepath);
			return;
		}
		LoadSource (source);

	}

	public void LoadSource (string source)
	{
		DefParser parser = new DefParser (new StringReader (source));
		try
		{
			var rootNode = parser.Parse ();
			Root root = new Root (rootNode);
			for (int i = 0; i < root.Operators.Count; i++)
				Entries.Add (root.Operators [i]);
		} catch (Exception e)
		{
			Debug.Log (e);
		}
	}

	public void Interpret ()
	{
		interpreter.Interpret (this);
	}
}

