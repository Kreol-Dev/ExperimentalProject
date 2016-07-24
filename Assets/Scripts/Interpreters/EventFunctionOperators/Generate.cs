using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using InternalDSL;
using System;
using System.Reflection;

[CommonFunctionOperator ("generate")]
public class GenerateOperator : FunctionOperatorInterpreter
{

	Dictionary<string, Type> components = new Dictionary<string, Type> ();
	EventFunctionOperators ops;

	public override void Interpret (Operator op, FunctionBlock block)
	{
		if (components.Count == 0)
		{
			ops = Engine.GetPlugin<EventFunctionOperators> ();
			var cmpTypes = Engine.FindTypesCastableTo<MonoBehaviour> ();
			foreach (var type in cmpTypes)
				components.Add (NameTranslator.ScriptNameFromCSharp (type.Name), type);
		}
		var varName = ((op.Args [0].Operands [0] as ExprAtom).Content as Scope).Parts [0] as string;
		block.Statements.Add (new DeclareVariableStatement () {
			Name = varName,
			InitExpression = String.Format ("new {1}(\"{0}\")", varName, typeof(GameObject)),
			Type = typeof(GameObject),
			IsContext = false
		});

		var ctx = op.Context as Context;
		FunctionBlock subBlock = new FunctionBlock (block, block.Method, block.Type);
		block.Statements.Add (subBlock);
		foreach (var entry in ctx.Entries)
		{
			var subOp = entry as Operator;
			var subContext = subOp.Context as Context;
			Debug.LogWarning (subOp.Identifier.GetType ());
			if (subOp.Identifier is string)
			{

				Type cmpType = null;
				if (components.TryGetValue (subOp.Identifier as string, out cmpType))
				{
					DeclareVariableStatement addVar = new DeclareVariableStatement ();
					addVar.Name = "AddContext" + DeclareVariableStatement.VariableId++;
					addVar.IsNew = true;
					addVar.InitExpression = String.Format ("{0}.AddComponent<{1}>()", varName, cmpType);
					addVar.IsContext = true;
					addVar.Type = cmpType;
					subBlock.Statements.Add (addVar);
				}
			}
			if (!IsYes (subOp.Context as Expression))
			{
				var inter = ops.GetInterpreter (subOp, subBlock);
				if (inter != null)
					inter.Interpret (subOp, subBlock);
			}
		}
	}


	bool IsYes (Expression expr)
	{
		if (expr == null)
			return false;
		if (expr.Operands.Length != 1)
			return false;
		var operand = expr.Operands [0];
		if (operand is ExprAtom)
			try
			{
				return (bool)(operand as ExprAtom).Content;
			} catch
			{
				return false;
			}
		return false;
	}

	public override bool Match (Operator op, FunctionBlock block)
	{
		return false;
	}
}


