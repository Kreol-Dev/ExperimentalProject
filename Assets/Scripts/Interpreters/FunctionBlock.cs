using UnityEngine;
using System.Collections;
using System.Text;
using System.CodeDom;
using System.Collections.Generic;
using System;

public class FunctionBlock
{
	public FunctionBlock Parent { get; internal set; }

	public List<object> Statements = new List<object> ();

	public CodeMemberMethod Method { get; internal set; }

	public int Ident { get; internal set; }

	public FunctionBlock (FunctionBlock parent, CodeMemberMethod method)
	{
		if (parent == null)
			Ident = 3;
		else
			Ident = parent.Ident + 1;
		Parent = parent;
		Method = method;
	}

	public override string ToString ()
	{
		StringBuilder builder = new StringBuilder (Statements.Count * 100);
		builder.Append (Environment.NewLine).Append ('\t', Ident - 1).Append ("{").Append (Environment.NewLine);
		foreach (var st in Statements)
			builder.Append ('\t', Ident).Append (st.ToString ()).Append (Environment.NewLine);
		builder.Append ('\t', Ident - 1).Append ("}");
		return builder.ToString ();
	}

	public T FindStatement<T> () where T : class
	{
		T statement = null;
		FunctionBlock curBlock = this;
		while (curBlock != null && statement == null)
		{
			foreach (var stmt in curBlock.Statements)
			{
				statement = stmt as T;
				if (statement == null)
					continue;
				break;
			}
			curBlock = curBlock.Parent;
		}
		return statement;
	}

	public T FindStatement<T> (Func<T, bool> predicate) where T : class
	{
		T statement = null;
		FunctionBlock curBlock = this;
		while (curBlock != null && statement == null)
		{
			bool found = false;
			foreach (var stmt in curBlock.Statements)
			{
				statement = stmt as T;
				if (statement == null)
					continue;
				if (predicate (statement))
				{
					found = true;
					break;
				}
			}
			if (!found)
				statement = null;
			curBlock = curBlock.Parent;
		}
		return statement;
	}
}
