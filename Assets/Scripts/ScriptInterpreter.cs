using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Reflection;
using System.CodeDom;
using InternalDSL;
using Microsoft.CSharp;
using System.IO;
using System.CodeDom.Compiler;
using System.Linq;
using System.Text;

public class EngineInterpreter
{
	protected ScriptEngine Engine { get; private set; }

	protected EngineInterpreter (ScriptEngine engine)
	{
		Engine = engine;
	}

}

public abstract class ScriptInterpreter : EngineInterpreter
{

	protected ScriptInterpreter (ScriptEngine engine) : base (engine)
	{
		
	}

	public abstract void Interpret (Script script);
}

//public class ParameterVariableStatement





