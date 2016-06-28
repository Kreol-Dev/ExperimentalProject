using UnityEngine;
using System.Collections;
using System;

public abstract class ScriptInterpreter
{
	public abstract void Interpret (Script script);
}

public class TypesListInterpreter : ScriptInterpreter
{
	Type baseType;

	public TypesListInterpreter (Type baseType, ScriptEngine engine)
	{
		this.baseType = baseType;
	}

	public override void Interpret (Script script)
	{
		
	}
}