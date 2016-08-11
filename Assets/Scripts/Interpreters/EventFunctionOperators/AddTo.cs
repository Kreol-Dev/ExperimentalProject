﻿using UnityEngine;
using System.Collections;
using InternalDSL;
using System;


[CommonFunctionOperator ("add_to")]
public class AddToListOperator : FunctionOperatorInterpreter
{
	ExpressionInterpreter exprInter;

	public override void Interpret (Operator op, FunctionBlock block)
	{

		if (exprInter == null)
			exprInter = Engine.GetPlugin<ExpressionInterpreter> ();
		if (op.Args.Count > 0 && op.Args [0].Operands [0] is ExprAtom &&
		    (op.Args [0].Operands [0] as ExprAtom).Content is Scope &&
		    ((op.Args [0].Operands [0] as ExprAtom).Content as Scope).Parts.Count == 1)
		{
			var part = ((op.Args [0].Operands [0] as ExprAtom).Content as Scope).Parts [0];
			if (!(part is string))
			{
				Debug.Log ("Wrong add_to definition");
				return;
			}
			var listName = NameTranslator.CSharpNameFromScript (part as string);
			DeclareVariableStatement declareVar = block.FindStatement<DeclareVariableStatement> (v => v.IsContext);
			//Debug.Log (declareVar.DebugString ());
			if (declareVar == null)
			{
				Debug.Log ("add_to operator can't find context variable");
			} else
			{
				if (op.Context is Expression)
				{
					block.Statements.Add (String.Format ("{0}.{1}.Add({2});", declareVar.Name, listName, exprInter.InterpretExpression (op.Context as Expression, block).ExprString));
				} 
			}

		} else
		{
			Debug.Log ("Wrong add_to definition");
		}

	}

	public override bool Match (Operator op, FunctionBlock block)
	{
		return false;
	}
}