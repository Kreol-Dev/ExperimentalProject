using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Reflection;
using System.CodeDom;
using InternalDSL;
using Microsoft.CSharp;
using System.IO;
using System.CodeDom.Compiler;

public class EngineInterpreter
{
	protected ScriptEngine Engine { get; private set; }

	protected EngineInterpreter (ScriptEngine engine)
	{
		Engine = engine;
	}

}

public abstract class ScriptInterpreter : EngineInterpreter
{

	protected ScriptInterpreter (ScriptEngine engine) : base (engine)
	{
		
	}

	public abstract void Interpret (Script script);
}

public abstract class EventAction
{
	public abstract bool Filter (GameObject go);

	public virtual void Action (GameObject root)
	{
		
	}


}

public class EventActionsLoader : ScriptInterpreter
{
	List<CodeTypeDeclaration> codeTypes = new List<CodeTypeDeclaration> ();
	FiltersPlugin filters;
	CodeNamespace cNamespace = new CodeNamespace ();

	public EventActionsLoader (string namespaceName, ScriptEngine engine) : base (engine)
	{
		cNamespace.Name = namespaceName;
		filters = engine.GetPlugin<FiltersPlugin> ();
	}

	public override void Interpret (Script script)
	{
		for (int i = 0; i < script.Entries.Count; i++)
		{
			var entry = script.Entries [i];
			CodeTypeDeclaration codeType = new CodeTypeDeclaration ();
			codeType.BaseTypes.Add (new CodeTypeReference (typeof(EventAction)));
			codeType.Name = entry.Identifier as string;
			codeTypes.Add (codeType);

			var ctx = entry.Context as Context;
			if (ctx == null)
				continue;
			for (int j = 0; j < ctx.Entries.Count; j++)
			{
				var op = ctx.Entries [j] as Operator;
				if (op == null)
					continue;
				if (op.Identifier as string == "scope")
				{
					//It's a filter function
//					Debug.Log (op.Context.GetType ());
					CreateFilterFunction (op.Context as Expression, codeType);

				} else if (op.Identifier as string == "action")
				{
					//It's an action function
					CreateEventFunction (op.Identifier as string, op.Context as Context, codeType);
				} else
				{
					//No idea
				}
			}

		}

		foreach (var type in codeTypes)
		{
			cNamespace.Types.Add (type);
		}

		CSharpCodeProvider provider = new CSharpCodeProvider ();
		CodeGeneratorOptions options = new CodeGeneratorOptions ();
		var writer = new StringWriter ();
		provider.GenerateCodeFromNamespace (cNamespace, writer, options);
		Engine.GetPlugin<ScriptCompiler> ().AddSource (writer.ToString ());

	}

	void CreateFilterFunction (Expression expr, CodeTypeDeclaration codeType)
	{
		if (expr.Operands.Length != 1)
		{
			//Something is wrong
			Debug.LogFormat ("Wrong amount of operands in scope function in {0}", codeType.Name);
			return;
		}
		Scope scope = (expr.Operands [0] as ExprAtom).Content as Scope;
		if (scope == null)
		{
			Debug.LogFormat ("Scope function doesn't contain scope function in {0}", codeType.Name);
			return;
		}
		CodeMemberMethod method = new CodeMemberMethod ();
		method.ReturnType = new CodeTypeReference (typeof(bool));
		method.Parameters.Add (new CodeParameterDeclarationExpression (typeof(GameObject), "go"));

		method.Name = "Filter";
		method.Attributes = MemberAttributes.Override | MemberAttributes.Public;
		for (int i = 0; i < scope.Parts.Length; i++)
		{
			var part = scope.Parts [i];
			if (part is FunctionCall)
			{
				var call = part as FunctionCall;
				var filter = filters.GetFilter (call.Name);
				filter.Interpret (call.Args, method);
			} else
			{

				var filter = filters.GetFilter (part as string);
				filter.Interpret (null, method);
			}
		}
		method.Statements.Add (new CodeSnippetStatement ("return true;"));
		codeType.Members.Add (method);
	}

	void CreateEventFunction (string name, Context context, CodeTypeDeclaration codeType)
	{
		
	}
}


public class FiltersPlugin : ScriptEnginePlugin
{
	Dictionary<string, FilterPartInterpreter> filters = new Dictionary<string, FilterPartInterpreter> ();

	public override void Init ()
	{
		
	}

	public void AddFilter (FilterPartInterpreter filter, string name)
	{
		filters.Add (name, filter);
	}


	public FilterPartInterpreter GetFilter (string filterName)
	{
		FilterPartInterpreter filter = null;
		filters.TryGetValue (filterName, out filter);
		return filter;
	}


}

public class ComponentsFiltersPlugin : ScriptEnginePlugin
{
	public override void Init ()
	{
		FiltersPlugin filtersPlugin = Engine.GetPlugin<FiltersPlugin> ();

		var components = Engine.FindTypesCastableTo<MonoBehaviour> ();
		foreach (var cmp in components)
		{
			var cmpName = NameTranslator.ScriptNameFromCSharp (cmp.Name);
			var opName = "has_" + cmpName;
			HasComponentFilter filter = new HasComponentFilter (cmp);
			filtersPlugin.AddFilter (filter, opName);
		}
	}
}

public class FilterPartInterpreterAttribute : Attribute
{
	public string Name { get; set; }

	public FilterPartInterpreterAttribute (string name)
	{
		Name = name;
	}
}


public abstract class FilterPartInterpreter
{
	public abstract void Interpret (Expression[] args, CodeMemberMethod filterFunction);
}

public class HasComponentFilter : FilterPartInterpreter
{
	Type cmpType;
	string checkString;

	public HasComponentFilter (Type cmpType)
	{
		
		this.cmpType = cmpType;
		checkString = String.Format ("if(go.GetComponent<{0}>() == null) return false;", cmpType);
	}

	public override void Interpret (Expression[] args, CodeMemberMethod filterFunction)
	{
		if (args != null)
			Debug.Log ("Somehow has component filter has arguments");
		filterFunction.Statements.Add (new CodeSnippetStatement (checkString));
	}
}