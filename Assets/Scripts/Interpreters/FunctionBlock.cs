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

	public FunctionBlock (FunctionBlock parent, CodeMemberMethod method)
	{
		Parent = parent;
		Method = method;
	}

	public override string ToString ()
	{
		StringBuilder builder = new StringBuilder (Statements.Count * 100);
		builder.Append ("{");
		foreach (var st in Statements)
			builder.Append (st.ToString ());
		builder.Append ("}");
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
			foreach (var stmt in curBlock.Statements)
			{
				statement = stmt as T;
				if (statement == null)
					continue;
				if (predicate (statement))
					break;
			}
			curBlock = curBlock.Parent;
		}
		return statement;
	}
}
