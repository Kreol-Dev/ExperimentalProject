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
	ExpressionInterpreter exprInter;

	public override void Init ()
	{
		exprInter = Engine.GetPlugin<ExpressionInterpreter> ();
	}

	public void AddInterpreter (string name, FunctionOperatorInterpreter inter)
	{
		if (interpreters.ContainsKey (name))
		{
			Debug.LogWarning ("Already has an interpreter " + name);
			return;
		}
		inter.Engine = Engine;
		interpreters.Add (name, inter);
	}

	public FunctionOperatorInterpreter GetInterpreter (Operator op, FunctionBlock block)
	{
		FunctionOperatorInterpreter inter = null;
		if (op.Identifier as string == null)
		{
			exprInter.TransformScopedOperator (op, block);
			Debug.Log ("Transformed op " + op.ToString ());
		}
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
				Debug.LogWarningFormat ("{0} is not an operator of context, found one {1}", op.Identifier, context);
			else
				Debug.LogWarningFormat ("{0} is not an operator of context, not found one", op.Identifier);
			if (context != null)
				inter = context.InterpretInContext (op, block);
		}
		Debug.LogFormat ("{0} - {1}", op.Identifier, inter);
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
