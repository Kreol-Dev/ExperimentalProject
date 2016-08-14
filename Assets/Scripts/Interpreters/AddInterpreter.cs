using UnityEngine;
using System.Collections;
using InternalDSL;

[CommonFunctionOperator ("add")]
public class AddInterpreter : FunctionOperatorInterpreter
{
	EventFunctionOperators ops;
	ContextSwitchesPlugin switches;

	public override void Interpret (Operator op, FunctionBlock block)
	{

		DeclareVariableStatement stmt = new DeclareVariableStatement ();
		stmt.Name = "New" + DeclareVariableStatement.VariableId++;
		stmt.IsNew = true;

		if (op.Context is Context)
		{

			FunctionBlock subBlock = new FunctionBlock (block, block.Method, block.Type);
			block.Statements.Add (subBlock);
			subBlock.Statements.Add (stmt);
			stmt.IsContext = true;

			foreach (var entry in (op.Context as Context).Entries)
			{
				var subOp = entry as Operator;

			}
		}


	}

	public override bool Match (InternalDSL.Operator op, FunctionBlock block)
	{
		return false;
	}
}

