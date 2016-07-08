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
using System.Linq;
using System.Text;

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
		FunctionBlock block = new FunctionBlock (null, method);
		bool hasRoot = false;
		foreach (var arg in args)
		{
			if (arg.Name == "root")
				hasRoot = true;
			method.Parameters.Add (new CodeParameterDeclarationExpression (arg.ParameterType, arg.Name));
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

//public class ParameterVariableStatement

public class FiltersPlugin : ScriptEnginePlugin
{
	Dictionary<string, FilterPartInterpreter> filters = new Dictionary<string, FilterPartInterpreter> ();

	public override void Init ()
	{
		
	}

	public void AddFilter (FilterPartInterpreter filter, string name)
	{
		filter.Engine = Engine;
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
	public ScriptEngine Engine;

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


public class EventFunctionOperators : ScriptEnginePlugin
{
	Dictionary<string, FunctionOperatorInterpreter> interpreters = new Dictionary<string, FunctionOperatorInterpreter> ();

	public override void Init ()
	{
		
	}

	public void AddInterpreter (string name, FunctionOperatorInterpreter inter)
	{
		inter.Engine = Engine;
		interpreters.Add (name, inter);
	}

	public FunctionOperatorInterpreter GetInterpreter (Operator op, FunctionBlock block)
	{
		FunctionOperatorInterpreter inter = null;
		interpreters.TryGetValue (op.Identifier as string, out inter);
		if (inter == null)
		{
			foreach (var interPair in interpreters)
			{
				if (interPair.Value.Match (op, block))
					return interPair.Value;
			}
		}
		return inter;
	}

}

public class CommonOperatorInterpretators : ScriptEnginePlugin
{
	public override void Init ()
	{
		var types = Engine.FindTypesWithAttribute<CommonFunctionOperatorAttribute> ();
		var operators = Engine.GetPlugin<EventFunctionOperators> ();
		foreach (var type in types)
		{
			operators.AddInterpreter (type.Attribute.Name, Activator.CreateInstance (type.Type) as FunctionOperatorInterpreter);
		}
	}
}

public class ContextSwitchesPlugin : ScriptEnginePlugin
{
	//Dictionary<string, ContextSwitchInterpreter> inters = new Dictionary<string, ContextSwitchInterpreter> ();

	public override void Init ()
	{
		EventFunctionOperators ops = Engine.GetPlugin<EventFunctionOperators> ();
		var components = Engine.FindTypesCastableTo<MonoBehaviour> ();
		foreach (var cmp in components)
		{
			ContextSwitchInterpreter inter = new ContextSwitchInterpreter (cmp);
			ops.AddInterpreter (NameTranslator.ScriptNameFromCSharp (cmp.Name), inter);
		}
	}
}

public class ContextFunctionCallInterpreter : FunctionOperatorInterpreter
{
	public override void Interpret (Operator op, FunctionBlock block)
	{

	}

	public override bool Match (Operator op, FunctionBlock block)
	{
		return false;
	}
	
}

public class ContextPropertyInterpreter : FunctionOperatorInterpreter
{
	public override void Interpret (Operator op, FunctionBlock block)
	{

	}

	public override bool Match (Operator op, FunctionBlock block)
	{
		return false;
	}

	Type propType;

	public ContextPropertyInterpreter (Type type)
	{
		propType = type;
	}
}

public abstract class FunctionOperatorInterpreter
{
	public ScriptEngine Engine;

	public abstract void Interpret (Operator op, FunctionBlock block);

	public abstract bool Match (Operator op, FunctionBlock block);
}

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
}

public class IfStatement
{
	public string CheckExpression;
	public FunctionBlock TrueBlock;

	public override string ToString ()
	{
		return String.Format ("if({0})\r\n{{\r\n{1}\r\n}}", CheckExpression, TrueBlock);
	}
}

public class DeclareVariableStatement
{
	public static int VariableId = 0;
	public Type Type;
	public string Name;
	public string InitExpression;

	public override string ToString ()
	{
		return string.Format ("{0} {1} = {2};", Type, Name, InitExpression);
	}
}

public class CommonFunctionOperatorAttribute : Attribute
{
	public string Name { get; internal set; }

	public CommonFunctionOperatorAttribute (string name)
	{
		Name = name;
	}
}

public class ExpressionInterpreter : ScriptEnginePlugin
{
	public override void Init ()
	{
		
	}

	public struct Expr
	{
		public string ExprString;
		public string Type;
	}

	StringBuilder builder = new StringBuilder ();

	public Expr InterpretExpression (Expression expression, FunctionBlock block)
	{
		builder.Length = 0;
		if (expression.Operands.Length == 1)
		{
			ProcessOperand (expression.Operands [0], builder);
			var type = DetermineOperandType (expression.Operands [0]);
			return new Expr (){ ExprString = "10", Type = type };
		} else
		{
			Expression.BinaryOp binOp = (Expression.BinaryOp)expression.Operands [1];
			Type exprType = null;
			switch (binOp)
			{
			case Expression.BinaryOp.Add:
			case Expression.BinaryOp.Sub:
			case Expression.BinaryOp.Div:
			case Expression.BinaryOp.Mul:
				exprType = typeof(float);
				break;
			case Expression.BinaryOp.Equals:
			case Expression.BinaryOp.More:
			case Expression.BinaryOp.Less:
			case Expression.BinaryOp.NotEquals:
			case Expression.BinaryOp.MoreOrEquals:
			case Expression.BinaryOp.LessOrEquals:
			case Expression.BinaryOp.And:
			case Expression.BinaryOp.Or:
				exprType = typeof(bool);
				break;
			case Expression.BinaryOp.Undefined:
				break;
			default:
				throw new ArgumentOutOfRangeException ();
			}
			for (int i = 0; i < expression.Operands.Length; i += 2)
			{
				builder.Append ("(");
				ProcessOperand (expression.Operands [i], builder);
				builder.Append (")");
				if (i + 1 < expression.Operands.Length)
					builder.Append (expression.OpToString ((Expression.BinaryOp)expression.Operands [i + 1]));
			}
			return new Expr (){ ExprString = builder.ToString (), Type = exprType.ToString () };
		}
	}

	public void ProcessOperand (object operand, StringBuilder exprBuilder)
	{
		exprBuilder.Append ("true");
		return;
		if (operand is string || operand is float || operand is bool)
			exprBuilder.Append (operand);
		//if(operand is float)
	}

	public string DetermineOperandType (object operand)
	{
		return null;
	}
}

[CommonFunctionOperator ("if")]
public class IfOperator : FunctionOperatorInterpreter
{
	ExpressionInterpreter exprInterpreter;
	EventFunctionOperators ops;

	public override bool Match (Operator op, FunctionBlock block)
	{
		return false;
	}

	public override void Interpret (Operator op, FunctionBlock block)
	{
		if (exprInterpreter == null)
		{

			exprInterpreter = Engine.GetPlugin<ExpressionInterpreter> ();
			ops = Engine.GetPlugin<EventFunctionOperators> ();
		}
		if (op.Args.Count == 1)
		{
			//Shouldn't declare variable
			IfStatement ifStatement = new IfStatement ();
			ifStatement.CheckExpression = exprInterpreter.InterpretExpression (op.Args [0], block).ExprString;
			ifStatement.TrueBlock = new FunctionBlock (block, block.Method);
			
			block.Statements.Add (ifStatement);
			foreach (var entry in (op.Context as Context).Entries)
			{
				var subOp = entry as Operator;
				if (subOp == null)
					continue;
				var subInter = ops.GetInterpreter (subOp, ifStatement.TrueBlock);
				if (subInter == null)
				{
					Debug.LogFormat ("Can't interpret operator {0} in {1}", subOp.Identifier, block.Method.Name);
					continue;
				}
				subInter.Interpret (subOp, ifStatement.TrueBlock);
			}

		} else if (op.Args.Count == 2)
		{
			DeclareVariableStatement declareVar = new DeclareVariableStatement ();
			if (op.Args [1].Operands [0] is IdWrapper)
			{

				var id = (IdWrapper)op.Args [1].Operands [0] as string;
				declareVar.Name = id;
				declareVar.Type = typeof(bool);
				declareVar.InitExpression = "false";
			} else
			{
				Debug.Log ("Wrong definition of an if operator with a variable - variable is not an identifier");
				return;
			}

			block.Statements.Add (declareVar);
				
			//Should declare variable

		}
	}
}

public class ForStatement
{
	public FunctionBlock RepeatBlock;
	public string InsideExpr;

	public override string ToString ()
	{
		return string.Format ("for ({0}) {{ {1} }}", InsideExpr, RepeatBlock);
	}
}

[CommonFunctionOperator ("repeat")]
public class RepeatOperator : FunctionOperatorInterpreter
{
	ExpressionInterpreter exprInterpreter;
	EventFunctionOperators ops;

	public override bool Match (Operator op, FunctionBlock block)
	{
		return false;
	}

	public override void Interpret (Operator op, FunctionBlock block)
	{
		if (exprInterpreter == null)
		{

			exprInterpreter = Engine.GetPlugin<ExpressionInterpreter> ();
			ops = Engine.GetPlugin<EventFunctionOperators> ();
		}
		if (op.Args.Count == 1)
		{
			ForStatement stmt = new ForStatement ();
			stmt.RepeatBlock = new FunctionBlock (block, block.Method);
			stmt.InsideExpr = String.Format ("int i = 0; i < {0}; i++", exprInterpreter.InterpretExpression (op.Args [0], block).ExprString);

			block.Statements.Add (stmt);
			foreach (var entry in (op.Context as Context).Entries)
			{
				var subOp = entry as Operator;
				if (subOp == null)
					continue;
				var subInter = ops.GetInterpreter (subOp, stmt.RepeatBlock);
				if (subInter == null)
				{
					Debug.LogFormat ("Can't interpret operator {0} in {1}", subOp.Identifier, block.Method.Name);
					continue;
				}
				//Debug.Log (subOp.Identifier);
				subInter.Interpret (subOp, stmt.RepeatBlock);
			}

		} else
		{
			Debug.Log ("Error in repeat definion - more or less than one argument");

		}
	}
}

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

[CommonFunctionOperator ("add_to")]
public class AddToListOperator : FunctionOperatorInterpreter
{
	ExpressionInterpreter exprInter;

	public override void Interpret (Operator op, FunctionBlock block)
	{
		if (exprInter == null)
			exprInter = Engine.GetPlugin<ExpressionInterpreter> ();
		if (op.Args.Count > 0 && op.Args [0].Operands [0] is IdWrapper)
		{
			var listName = ((IdWrapper)op.Args [0].Operands [9]) as string;
			DeclareVariableStatement declareVar = null;
			FunctionBlock curBlock = block;
			while (curBlock != null && declareVar == null)
			{
				foreach (var stmt in block.Statements)
				{
					declareVar = stmt as DeclareVariableStatement;
					if (declareVar == null)
						continue;
					break;
				}
				curBlock = curBlock.Parent;
			}
			if (declareVar == null)
			{
				Debug.Log ("add_to operator can't find context variable");
			} else
			{
				if (op.Context is Expression)
					block.Statements.Add (String.Format ("{0}.{1}.Add({2});", declareVar.Name, listName, exprInter.InterpretExpression (op.Context as Expression, block)));
			}

		}
	}

	public override bool Match (Operator op, FunctionBlock block)
	{
		return false;
	}
}



public class ContextSwitchInterpreter : FunctionOperatorInterpreter
{
	EventFunctionOperators ops;

	public override void Interpret (Operator op, FunctionBlock block)
	{
		if (ops == null)
			ops = Engine.GetPlugin<EventFunctionOperators> ();
		FunctionBlock contextBlock = new FunctionBlock (block, block.Method);
		block.Statements.Add (contextBlock);
		DeclareVariableStatement declareVar = new DeclareVariableStatement ();
		declareVar.Type = contextType;
		declareVar.Name = "subContext" + DeclareVariableStatement.VariableId++;

		declareVar.InitExpression = String.Format ("root.GetComponent<{0}>()", contextType);
		contextBlock.Statements.Add (declareVar);

		foreach (var entry in (op.Context as Context).Entries)
		{
			var subOp = entry as Operator;
			if (subOp == null)
				continue;
			
			
		}

	}

	public override bool Match (Operator op, FunctionBlock block)
	{
		return false;
	}

	Type contextType;

	Dictionary<string, ContextSwitchInterpreter> contextSwitches = new Dictionary<string, ContextSwitchInterpreter> ();
	Dictionary<string, ContextFunctionCallInterpreter> functions = new Dictionary<string, ContextFunctionCallInterpreter> ();
	Dictionary<string, ContextPropertyInterpreter> properties = new Dictionary<string, ContextPropertyInterpreter> ();
	Dictionary<string, FunctionOperatorInterpreter> other = new Dictionary<string, FunctionOperatorInterpreter> ();

	public ContextSwitchInterpreter (Type type)
	{
		Debug.Log ("Context switch " + type);
		contextType = type;
		var props = type.GetProperties (BindingFlags.Public | BindingFlags.DeclaredOnly);
		var methods = type.GetMethods (BindingFlags.Public | BindingFlags.DeclaredOnly);

		foreach (var prop in props)
		{
			if (prop.PropertyType.IsClass || (prop.PropertyType.IsValueType && !prop.PropertyType.IsEnum))
			{
				ContextSwitchInterpreter inter = new ContextSwitchInterpreter (prop.PropertyType);
				contextSwitches.Add (NameTranslator.ScriptNameFromCSharp (prop.Name), inter);
			} else
			{
				ContextPropertyInterpreter inter = new ContextPropertyInterpreter (prop.PropertyType);
				properties.Add (NameTranslator.ScriptNameFromCSharp (prop.Name), inter);
			}

		}

		foreach (var method in methods)
		{
			Debug.Log ("Context switch method " + method.Name);
			ContextFunctionCallInterpreter inter = new ContextFunctionCallInterpreter ();
			functions.Add (NameTranslator.ScriptNameFromCSharp (method.Name), inter);
		}
	}


}