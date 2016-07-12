using UnityEngine;
using System.Collections;
using System.CodeDom;
using System.Collections.Generic;
using InternalDSL;
using Microsoft.CSharp;
using System.IO;
using System.CodeDom.Compiler;
using System.Reflection;


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
	EventFunctionOperators functionOperators;

	public EventActionsLoader (string namespaceName, ScriptEngine engine) : base (engine)
	{
		cNamespace.Name = namespaceName;
		filters = engine.GetPlugin<FiltersPlugin> ();
		functionOperators = engine.GetPlugin<EventFunctionOperators> ();
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
			var actionMethod = typeof(EventAction).GetMethod ("Action");
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
					CreateEventFunction (op.Identifier as string, op.Context as Context, codeType, actionMethod);
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

	void CreateEventFunction (string name, Context context, CodeTypeDeclaration codeType, MethodInfo baseMethod)
	{
		CodeMemberMethod method = new CodeMemberMethod ();
		method.Name = NameTranslator.CSharpNameFromScript (name);
		method.Attributes = MemberAttributes.Override | MemberAttributes.Public;
		method.ReturnType = new CodeTypeReference (typeof(void));
		var args = baseMethod.GetParameters ();
		FunctionBlock block = new FunctionBlock (null, method, codeType);
		bool hasRoot = false;
		foreach (var arg in args)
		{
			if (arg.Name == "root")
				hasRoot = true;
			method.Parameters.Add (new CodeParameterDeclarationExpression (arg.ParameterType, arg.Name));
			var paramVar = new DeclareVariableStatement ();
			paramVar.Name = arg.Name;
			paramVar.Type = arg.ParameterType;
			paramVar.IsArg = true;
			block.Statements.Add (paramVar);
		}
		if (!hasRoot)
		{
			Debug.LogFormat ("Method {0} in {1} has no root arg", baseMethod.Name, codeType.Name);
			return;
		}

		codeType.Members.Add (method);

		foreach (var entry in context.Entries)
		{
			Operator op = entry as Operator;
			var inter = functionOperators.GetInterpreter (op, block);
			if (inter == null)
			{
				Debug.LogFormat ("Can't find interpreter for operator {0} in {1} of {2}", op.Identifier, baseMethod.Name, codeType.Name);
				continue;
			}
			inter.Interpret (op, block);
		}	

		method.Statements.Add (new CodeSnippetStatement (block.ToString ()));
	}
}
