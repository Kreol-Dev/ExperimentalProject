using UnityEngine;
using System.Collections;
using InternalDSL;

[CommonFunctionOperator ("generate")]
public class GenerateOperator : FunctionOperatorInterpreter
{
	public override void Interpret (Operator op, FunctionBlock block)
	{

	}

	public override bool Match (Operator op, FunctionBlock block)
	{
		return false;
	}
}


