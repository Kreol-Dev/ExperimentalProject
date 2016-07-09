using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using InternalDSL;
using System;

public abstract class FunctionOperatorInterpreter
{
	public ScriptEngine Engine;

	public abstract void Interpret (Operator op, FunctionBlock block);

	public abstract bool Match (Operator op, FunctionBlock block);
}

public class EventFunctionOperators : ScriptEnginePlugin
{
	Dictionary<string, FunctionOperatorInterpreter> interpreters = new Dictionary<string, FunctionOperatorInterpreter> ();

	public override void Init ()
	{

	}

	public void AddInterpreter (string name, FunctionOperatorInterpreter inter)
	{
		inter.Engine = Engine;
		interpreters.Add (name, inter);
	}

	public FunctionOperatorInterpreter GetInterpreter (Operator op, FunctionBlock block)
	{
		FunctionOperatorInterpreter inter = null;
		interpreters.TryGetValue (op.Identifier as string, out inter);
		if (inter == null)
		{
			foreach (var interPair in interpreters)
			{
				if (interPair.Value.Match (op, block))
					return interPair.Value;
			}
			var context = block.FindStatement<ContextStatement> ();
			if (context != null)
				inter = context.InterpretInContext (op, block);
		}
		return inter;
	}

}

public class CommonOperatorInterpretators : ScriptEnginePlugin
{
	public override void Init ()
	{
		var types = Engine.FindTypesWithAttribute<CommonFunctionOperatorAttribute> ();
		var operators = Engine.GetPlugin<EventFunctionOperators> ();
		foreach (var type in types)
		{
			operators.AddInterpreter (type.Attribute.Name, Activator.CreateInstance (type.Type) as FunctionOperatorInterpreter);
		}
	}
}


public class CommonFunctionOperatorAttribute : Attribute
{
	public string Name { get; internal set; }

	public CommonFunctionOperatorAttribute (string name)
	{
		Name = name;
	}
}
