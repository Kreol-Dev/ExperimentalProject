using UnityEngine;
using System.Collections;
using InternalDSL;
using System;

[CommonFunctionOperator ("generate")]
public class GenerateOperator : FunctionOperatorInterpreter
{


	public override void Interpret (Operator op, FunctionBlock block)
	{
		var varName = ((op.Args [0].Operands [0] as ExprAtom).Content as Scope).Parts [0] as string;
		block.Statements.Add (new DeclareVariableStatement () {
			Name = varName,
			InitExpression = String.Format ("new {1}(\"{0}\")", varName, typeof(GameObject)),
			Type = typeof(GameObject),
			IsContext = false
		});
	}

	public override bool Match (Operator op, FunctionBlock block)
	{
		return false;
	}
}


