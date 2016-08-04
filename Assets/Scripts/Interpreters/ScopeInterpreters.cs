using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using InternalDSL;
using System;

public class HasComponentScope : ScopeInterpreter
{
	public Type Type;

	public override void Interpret (Expression[] args, FunctionBlock block, Type contextType, string exprVal, out string newExprVal, out FunctionBlock newCurBlock, out Type newContextType, bool isLast)
	{
		Debug.Log ("Has component scope");
		IfStatement ifStatement = new IfStatement ();
		DeclareVariableStatement cmpStmt = new DeclareVariableStatement ();
		cmpStmt.IsTemp = true;
		cmpStmt.IsContext = true;
		ExprInter.CleanUpContextes.Add (cmpStmt);
		cmpStmt.Name = "cmp" + DeclareVariableStatement.VariableId++;
		cmpStmt.Type = Type;
		//cmpStmt.IsContext = true;
		string varName = block.FindStatement<DeclareVariableStatement> (v => v.IsContext).Name;
		cmpStmt.InitExpression = String.Format ("{0}.GetComponent<{1}>()", varName, Type);
		ifStatement.CheckExpression = String.Format ("{0} != null", cmpStmt.Name);
		FunctionBlock newBlock = new FunctionBlock (block, block.Method, block.Type);
		ifStatement.TrueBlock = newBlock;
		block.Statements.Add (cmpStmt);
		block.Statements.Add (ifStatement);
		newCurBlock = newBlock;
		newExprVal = exprVal;
		newContextType = contextType;
		if (isLast)
		{

			var res = block.FindStatement<DeclareVariableStatement> (v => v.IsResult);
			res.Type = typeof(List<>).MakeGenericType (contextType);
			res.InitExpression = String.Format ("new {0}()", TypeName.NameOf (res.Type));
			newExprVal = res.Name;
			newBlock.Statements.Add (String.Format ("{0}.Add({1});", res.Name, varName));
		}

		//ifStatement.CheckExpression = String.Format("{0}.GetComponen")
		//ifStatement.CheckExpression = 
	}
}

[ScopeInterpreter ("fit")]
public class FitScopeInterpreter : ScopeInterpreter
{
	public Type Type;

	public override void Interpret (Expression[] args, FunctionBlock block, Type contextType, string exprVal, out string newExprVal, out FunctionBlock newCurBlock, out Type newContextType, bool isLast)
	{
		Debug.Log ("fit scope");
		IfStatement ifStatement = new IfStatement ();
//		DeclareVariableStatement cmpStmt = new DeclareVariableStatement ();
//		ExprInter.CleanUpContextes.Add (cmpStmt);
//		cmpStmt.Name = "cmp" + DeclareVariableStatement.VariableId++;
//		cmpStmt.Type = Type;
		//cmpStmt.IsContext = true;
		string varName = block.FindStatement<DeclareVariableStatement> (v => v.IsContext).Name;
//		cmpStmt.InitExpression = String.Format ("{0}.GetComponent<{1}>()", varName, Type);
//		ifStatement.CheckExpression = String.Format ("{0} != null", cmpStmt.Name);
		FunctionBlock newBlock = new FunctionBlock (block, block.Method, block.Type);
		ifStatement.CheckExpression = ExprInter.InterpretExpression (args [0], block).ExprString;
		ifStatement.TrueBlock = newBlock;
		//block.Statements.Add (cmpStmt);
		block.Statements.Add (ifStatement);
		newCurBlock = newBlock;
		newExprVal = exprVal;
		newContextType = contextType;
		if (isLast)
		{

			var res = block.FindStatement<DeclareVariableStatement> (v => v.IsResult);
			res.Type = typeof(List<>).MakeGenericType (contextType);
			res.InitExpression = String.Format ("new {0}()", TypeName.NameOf (res.Type));
			newExprVal = res.Name;
			newBlock.Statements.Add (String.Format ("{0}.Add({1});", res.Name, varName));
		}

		//ifStatement.CheckExpression = String.Format("{0}.GetComponen")
		//ifStatement.CheckExpression = 
	}
}

[ScopeInterpreter ("average")]
public class AverageInterpreter : ScopeInterpreter
{
	public override void Interpret (Expression[] args, FunctionBlock block, Type contextType, string exprVal, out string newExprVal, out FunctionBlock newCurBlock, out Type newContextType, bool isLast)
	{

		throw new NotImplementedException ();
	}
}