using UnityEngine;
using System.Collections;
using System;


public class IfStatement
{
	public string CheckExpression;
	public FunctionBlock TrueBlock;

	public override string ToString ()
	{
		return String.Format ("if({0}){1}", CheckExpression, TrueBlock);
	}
}

public class DeclareVariableStatement
{
	public static int VariableId = 0;
	public Type Type;
	public string Name;
	public string InitExpression;
	public bool IsContext = false;
	public bool IsArg = false;

	public override string ToString ()
	{
		if (IsArg)
			return "";
		return string.Format ("{0} {1} = {2};", Type, Name, InitExpression);
	}

	public string DebugString ()
	{
		return string.Format ("DeclVarStmt: {0} {1} = {2}, IsContext = {3}", Type, Name, InitExpression, IsContext);
	}
}

public class ForStatement
{
	public FunctionBlock RepeatBlock;
	public string InsideExpr;

	public override string ToString ()
	{
		return string.Format ("for ({0}){1}", InsideExpr, RepeatBlock);
	}
}


