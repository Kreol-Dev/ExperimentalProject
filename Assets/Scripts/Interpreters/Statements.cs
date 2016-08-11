using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public static class TypeName
{
	public static string NameOf (Type type)
	{
		if (type == null)
			return "NullType";
		Type genType;
		Debug.Log ("NameOf " + type);
		if (type.IsGenericType && (genType = type.GetGenericTypeDefinition ()) == typeof(List<>))
		{
			return String.Format ("System.Collections.Generic.List<{0}>", type.GetGenericArguments () [0]);
		}
		return type.FullName;
	}
}

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
	public bool IsNew = false;
	public bool IsContext = false;
	public bool IsArg = false;
	public bool IsResult = false;
	public bool IsTemp = false;
	public bool IsReturn = false;
	public bool IsDeclaration = true;

	public override string ToString ()
	{
		if (IsArg)
			return "";
		if (!IsDeclaration)
		{
			if (InitExpression == null)
				return string.Format ("{0} {1};", "", Name);
			else
				return string.Format ("{0} {1} = {2};", "", Name, InitExpression);
		}
		if (InitExpression == null)
			return string.Format ("{0} {1};", TypeName.NameOf (Type), Name);
		else
			return string.Format ("{0} {1} = {2};", TypeName.NameOf (Type), Name, InitExpression);
	}

	public string DebugString ()
	{
		return string.Format ("DeclVarStmt: {0} {1} = {2}, IsContext = {3}", TypeName.NameOf (Type), Name, InitExpression, IsContext);
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


