using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using InternalDSL;
using System.Reflection;
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;
using System.Text;



public class ContextSwitchesPlugin : ScriptEnginePlugin
{
	//Dictionary<string, ContextSwitchInterpreter> inters = new Dictionary<string, ContextSwitchInterpreter> ();
	Dictionary<string, Type> components = new Dictionary<string, Type> ();
	Dictionary<Type, FunctionOperatorInterpreter> intersByType = new Dictionary<Type, FunctionOperatorInterpreter> ();

	public void AddInterToType (Type type, FunctionOperatorInterpreter inter)
	{
		if (!intersByType.ContainsKey (type))
			intersByType.Add (type, inter);
	}

	public FunctionOperatorInterpreter GetInterByType (Type type)
	{
		if (intersByType.ContainsKey (type))
			return intersByType [type];
		return null;
	}

	public Type GetContext (string name)
	{
		Type contextType = null;
		components.TryGetValue (name, out contextType);
		return contextType;
	}

	public override void Init ()
	{
		EventFunctionOperators ops = Engine.GetPlugin<EventFunctionOperators> ();
		var components = Engine.FindTypesCastableTo<MonoBehaviour> ();
		foreach (var cmp in components)
		{
			ContextSwitchInterpreter inter = new ContextSwitchInterpreter (cmp, Engine);
			Debug.Log ("context " + inter.Engine);
			ops.AddInterpreter (NameTranslator.ScriptNameFromCSharp (cmp.Name), inter);
		}
	}
}

public class ContextStatement
{
	public DeclareVariableStatement ContextVar;
	public Func<Operator, FunctionBlock, FunctionOperatorInterpreter> InterpretInContext;

	public override string ToString ()
	{
		return "";
	}
}

public class ContextSwitchInterpreter : FunctionOperatorInterpreter
{
	EventFunctionOperators ops;

	public override void Interpret (Operator op, FunctionBlock block)
	{
		if (ops == null)
			ops = Engine.GetPlugin<EventFunctionOperators> ();
		FunctionBlock contextBlock = new FunctionBlock (block, block.Method, block.Type);
		block.Statements.Add (contextBlock);
		DeclareVariableStatement addVar = block.FindStatement<DeclareVariableStatement> (v => v.Name == op.Identifier as string);
		if (addVar == null)
			block.FindStatement<DeclareVariableStatement> (v => v.IsContext && v.Type == contextType);
		DeclareVariableStatement contextVar = block.FindStatement<DeclareVariableStatement> (v => v.IsContext && v != addVar);
		DeclareVariableStatement declareVar = null;
		if (addVar == null)
		{
			declareVar = new DeclareVariableStatement ();
			declareVar.Type = contextType;
			declareVar.Name = "subContext" + DeclareVariableStatement.VariableId++;
			declareVar.IsContext = true;

			if (contextVar == null)
				declareVar.InitExpression = String.Format ("root.GetComponent<{0}>()", contextType);
			else
				declareVar.InitExpression = String.Format ("{1}.GetComponent<{0}>()", contextType, contextVar.Name);
			contextBlock.Statements.Add (declareVar);

		} else
			declareVar = addVar;

		contextBlock.Statements.Add (new ContextStatement () {
			ContextVar = contextVar,
			InterpretInContext = InterpretInContext
		});
		foreach (var entry in (op.Context as Context).Entries)
		{
			var subOp = entry as Operator;
			if (subOp == null)
				continue;
			FunctionOperatorInterpreter opInter = null;
			if (!contextSwitches.TryGetValue (subOp.Identifier as string, out opInter))
			if (!functions.TryGetValue (subOp.Identifier as string, out opInter))
			if (!properties.TryGetValue (subOp.Identifier as string, out opInter))
			if ((opInter = ops.GetInterpreter (subOp, contextBlock)) == null)
			{
				Debug.LogWarningFormat ("Can't interpret context operator {1} in {0}", block.Method.Name, subOp.Identifier);
				continue;
			}
			Debug.LogFormat ("Interpret {0} via {1}", subOp.Identifier, opInter);
			opInter.Interpret (subOp, contextBlock);
		}

	}

	public FunctionOperatorInterpreter InterpretInContext (Operator op, FunctionBlock block)
	{
		Debug.Log ("interpret in context");
		FunctionOperatorInterpreter opInter = null;
		if (!contextSwitches.TryGetValue (op.Identifier as string, out opInter))
		if (!functions.TryGetValue (op.Identifier as string, out opInter))
		if (!properties.TryGetValue (op.Identifier as string, out opInter))
		{
			Debug.LogWarningFormat ("Can't interpret context operator {1} in {0}", block.Method.Name, op.Identifier);
			return null;
		}
		return opInter;
	}

	public override bool Match (Operator op, FunctionBlock block)
	{
		return false;
	}

	Type contextType;

	Dictionary<string, FunctionOperatorInterpreter> contextSwitches = new Dictionary<string, FunctionOperatorInterpreter> ();
	Dictionary<string, FunctionOperatorInterpreter> functions = new Dictionary<string, FunctionOperatorInterpreter> ();
	Dictionary<string, FunctionOperatorInterpreter> properties = new Dictionary<string, FunctionOperatorInterpreter> ();
	Dictionary<string, FunctionOperatorInterpreter> other = new Dictionary<string, FunctionOperatorInterpreter> ();

	public ContextSwitchInterpreter (Type type, ScriptEngine engine)
	{
		this.Engine = engine;
		engine.GetPlugin<ContextSwitchesPlugin> ().AddInterToType (type, this);
		Debug.Log ("Context switch " + type);
		contextType = type;
		var props = type.GetProperties (BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly);
		var methods = type.GetMethods (BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly);

		foreach (var prop in props)
		{
			//Debug.Log (prop.Name);
			if (prop.PropertyType != typeof(string) && (prop.PropertyType.IsClass || (prop.PropertyType.IsValueType && !prop.PropertyType.IsEnum &&
			    prop.PropertyType != typeof(bool) && prop.PropertyType != typeof(float) && prop.PropertyType != typeof(int))) &&
			    !(prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition () == typeof(List<>)))
			{
				ContextPropertySwitchInterpreter inter = new ContextPropertySwitchInterpreter (prop.Name, prop.PropertyType, engine);
				contextSwitches.Add (NameTranslator.ScriptNameFromCSharp (prop.Name), inter);

				inter.Engine = Engine;
				Debug.Log ("SubContext " + NameTranslator.ScriptNameFromCSharp (prop.Name));
			} else
			{
				ContextPropertyInterpreter inter = new ContextPropertyInterpreter (prop.Name, prop.PropertyType);
				inter.Engine = Engine;
				Debug.Log (inter.Engine);
				properties.Add (NameTranslator.ScriptNameFromCSharp (prop.Name), inter);
				Debug.Log (NameTranslator.ScriptNameFromCSharp (prop.Name));
			}

		}

		foreach (var method in methods)
		{
			if (method.GetCustomAttributes (typeof(CompilerGeneratedAttribute), false).Length > 0)
				continue;
			Debug.Log ("Context method " + method.Name);
			ContextFunctionCallInterpreter inter = new ContextFunctionCallInterpreter (method, Engine);
			functions.Add (NameTranslator.ScriptNameFromCSharp (method.Name), inter);
		}
	}


}




public class ContextFunctionCallInterpreter : FunctionOperatorInterpreter
{
	ParameterInfo[] argsDef;
	string funcName;
	ExpressionInterpreter exprInter;
	Type returnType;
	ContextPropertySwitchInterpreter ctxInter;

	public ContextFunctionCallInterpreter (MethodInfo method, ScriptEngine engine)
	{
		Engine = engine;
		returnType = method.ReturnType;
		if (returnType != typeof(string) && (returnType.IsClass || (returnType.IsValueType && !returnType.IsEnum &&
		    returnType != typeof(bool) && returnType != typeof(float) && returnType != typeof(int))) &&
		    !(returnType.IsGenericType && returnType.GetGenericTypeDefinition () == typeof(List<>)))
		{
			ctxInter = new ContextPropertySwitchInterpreter ("", returnType, engine);
		}
		funcName = method.Name;
		argsDef = method.GetParameters ();
	}

	public override void Interpret (Operator op, FunctionBlock block)
	{
		Debug.LogWarning ("Context function " + op.Identifier);
		if (exprInter == null)
			exprInter = Engine.GetPlugin<ExpressionInterpreter> ();
		var any = BindingFlags.Instance | BindingFlags.Public | BindingFlags.Static;

		var contextVar = block.FindStatement<DeclareVariableStatement> (v => (v.IsContext || v.IsArg) && v.Type.GetMethod (funcName, any) != null);

		StringBuilder argsBuilder = new StringBuilder ();
		if (((op.Context is Expression) && op.Args.Count + 1 != argsDef.Length) ||
		    ((op.Context is Context) && op.Args.Count != argsDef.Length))
		{
			Debug.Log ("Wrong amount of arguments");
			return;
		}
		for (int i = 0; i < op.Args.Count; i++)
		{
			if (argsDef [i].ParameterType.IsSubclassOf (typeof(Delegate)))
				argsBuilder.Append (exprInter.InterpretClosure (op.Args [i], block, argsDef [i].ParameterType).ExprString).Append (",");
			else
				argsBuilder.Append (exprInter.InterpretExpression (op.Args [i], block).ExprString).Append (",");
			
		}
		if (op.Context is Expression)
		{
			if (argsDef [argsDef.Length - 1].ParameterType.IsSubclassOf (typeof(Delegate)))
				argsBuilder.Append (exprInter.InterpretClosure (op.Context as Expression, block, argsDef [argsDef.Length - 1].ParameterType).ExprString);
			else
				argsBuilder.Append (exprInter.InterpretExpression (op.Context as Expression, block).ExprString);
			if (contextVar == null)
				block.Statements.Add (string.Format ("root.{0}({1});", funcName, argsBuilder));
			else
				block.Statements.Add (string.Format ("{2}.{0}({1});", funcName, argsBuilder, contextVar.Name));
		} else if (ctxInter != null)
		{
			if (op.Args.Count > 0)
				argsBuilder.Length -= 1;
			var ctx = op.Context as Context;
			DeclareVariableStatement ctxVar = new DeclareVariableStatement ();
			ctxVar.Name = "FuncCtx" + DeclareVariableStatement.VariableId++;
			ctxVar.InitExpression = contextVar == null ? string.Format ("root.{0}({1});", funcName, argsBuilder) : string.Format ("{2}.{0}({1});", funcName, argsBuilder, contextVar.Name);
			ctxVar.Type = returnType;
			ctxVar.IsContext = true;

			ContextStatement stmt = new ContextStatement ();
			stmt.ContextVar = ctxVar;
			stmt.InterpretInContext = ctxInter.InterpretInContext;
			block.Statements.Add (ctxVar);
			block.Statements.Add (stmt);
			for (int i = 0; i < ctx.Entries.Count; i++)
			{
				ctxInter.InterpretInContext (ctx.Entries [i] as Operator, block).Interpret (ctx.Entries [i] as Operator, block);
			}
		}
			


		
	
	}

	public override bool Match (Operator op, FunctionBlock block)
	{
		return false;
	}

}

public class ContextPropertyInterpreter : FunctionOperatorInterpreter
{
	ExpressionInterpreter exprInter;
	EventFunctionOperators ops;

	public override void Interpret (Operator op, FunctionBlock block)
	{
		if (exprInter == null)
		{
			ops = Engine.GetPlugin<EventFunctionOperators> ();
			exprInter = Engine.GetPlugin<ExpressionInterpreter> ();
		}
		if (!(op.Context is Expression))
			return;
			
		var varName = op.Identifier as string;

		var context = block.FindStatement<DeclareVariableStatement> (v => v.IsContext);
		if (listT == null)
		{
			if (context == null)
				block.Statements.Add (String.Format ("root.{0} = {1};", propName, exprInter.InterpretExpression (op.Context as Expression, block).ExprString));
			else
				block.Statements.Add (String.Format ("{2}.{0} = {1};", propName, exprInter.InterpretExpression (op.Context as Expression, block).ExprString, context.Name));
			
		} else
		{
			ForStatement statement = new ForStatement ();
			string listVarName = context == null ? "root." + propName : context.Name + "." + propName;
			string iterName = "i" + DeclareVariableStatement.VariableId++;
			statement.InsideExpr = String.Format ("int {0} = 0; {0} < {1}.Count; {0}++", iterName,
			                                      listVarName);
			FunctionBlock repeatBlock = new FunctionBlock (block, block.Method, block.Type);
			statement.RepeatBlock = repeatBlock;
			block.Statements.Add (statement);
			Operator listVarOp = new Operator ();
			listVarOp.Identifier = NameTranslator.ScriptNameFromCSharp (listT.Name);
			listVarOp.Context = op.Context;

			DeclareVariableStatement listVar = new DeclareVariableStatement ();
			listVar.Name = "iter" + DeclareVariableStatement.VariableId++;
			listVar.IsContext = true;
			listVar.IsNew = true;
			listVar.Type = listT;
			listVar.InitExpression = String.Format ("{0}[{1}]", listVarName, iterName);

			statement.RepeatBlock.Statements.Add (listVar);
			var inter = ops.GetInterpreter (listVarOp, repeatBlock);
			inter.Interpret (listVarOp, repeatBlock);
		}
		interpret = true;
	}

	public override bool Match (Operator op, FunctionBlock block)
	{
		return false;
	}

	protected Type propType;
	protected string propName;
	Type listT = null;

	public ContextPropertyInterpreter (string propName, Type type)
	{
		
		if (type.IsGenericType && type.GetGenericTypeDefinition () == typeof(List<>))
			listT = type.GetGenericArguments () [0];
		
		this.propName = propName;
		propType = type;
	}
}

public class ContextPropertySwitchInterpreter : ContextPropertyInterpreter
{
	struct PropKey
	{
		public Type Type;
		public string Name;

		public PropKey (Type type, string name)
		{
			Type = type;
			Name = name;
		}

		public override int GetHashCode ()
		{
			return Type.GetHashCode () + Name.GetHashCode ();
		}

		public override bool Equals (object obj)
		{
			try
			{
				var key = (PropKey)obj;
				return key.Type == this.Type && key.Name == this.Name;
			} catch
			{
				return false;
			}
		}
	}

	static Dictionary<PropKey, ContextPropertySwitchInterpreter> allPropSwitches = new Dictionary<PropKey, ContextPropertySwitchInterpreter> ();
	//	static Dictionary<Type, ContextPropertySwitchInterpreter> switchesByType = new Dictionary<Type, ContextPropertySwitchInterpreter> ();
	//
	//	public static ContextPropertySwitchInterpreter GetSwitch (Type t)
	//	{
	//		ContextPropertySwitchInterpreter inter = null;
	//		if (!switchesByType.TryGetValue (t, out inter))
	//		{
	//
	//
	//		}
	//		return inter;
	//	}

	public ContextPropertySwitchInterpreter (string propName, Type type, ScriptEngine engine) : base (propName, type)
	{
		engine.GetPlugin<ContextSwitchesPlugin> ().AddInterToType (type, this);
		this.propName = propName;
		propType = type;
		this.Engine = engine;
		Debug.Log ("Context switch " + type);
		var props = type.GetProperties (BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
		var methods = type.GetMethods (BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

		var thisKey = new PropKey (type, propName);
		if (!allPropSwitches.ContainsKey (thisKey))
			allPropSwitches.Add (thisKey, this);
		if (typeof(MonoBehaviour).IsAssignableFrom (type))
		{
			foreach (var prop in props)
			{
				//Debug.Log (prop.Name);
				if (prop.PropertyType != typeof(string) && (prop.PropertyType.IsClass || (prop.PropertyType.IsValueType && !prop.PropertyType.IsEnum &&
				    prop.PropertyType != typeof(bool) && prop.PropertyType != typeof(float) && prop.PropertyType != typeof(int))))
				{
					var key = new PropKey (prop.PropertyType, prop.Name);
					if (allPropSwitches.ContainsKey (key))
						contextSwitches.Add (NameTranslator.ScriptNameFromCSharp (prop.Name), allPropSwitches [key]);
					else
					{
						ContextPropertySwitchInterpreter inter = new ContextPropertySwitchInterpreter (prop.Name, prop.PropertyType, engine);
						contextSwitches.Add (NameTranslator.ScriptNameFromCSharp (prop.Name), inter);

						inter.Engine = Engine;
					}

					Debug.Log ("SubContext " + NameTranslator.ScriptNameFromCSharp (prop.Name));
				} else
				{
					ContextPropertyInterpreter inter = new ContextPropertyInterpreter (prop.Name, prop.PropertyType);
					inter.Engine = Engine;
					Debug.Log (inter.Engine);
					properties.Add (NameTranslator.ScriptNameFromCSharp (prop.Name), inter);
					Debug.Log (NameTranslator.ScriptNameFromCSharp (prop.Name));
				}

			}

			foreach (var method in methods)
			{
				if (method.GetCustomAttributes (typeof(CompilerGeneratedAttribute), false).Length > 0)
					continue;
				Debug.Log ("Context method " + method.Name);
				ContextFunctionCallInterpreter inter = new ContextFunctionCallInterpreter (method, Engine);
				functions.Add (NameTranslator.ScriptNameFromCSharp (method.Name), inter);
			}
		}

	}

	EventFunctionOperators ops;
	Dictionary<string, FunctionOperatorInterpreter> contextSwitches = new Dictionary<string, FunctionOperatorInterpreter> ();
	Dictionary<string, FunctionOperatorInterpreter> functions = new Dictionary<string, FunctionOperatorInterpreter> ();
	Dictionary<string, FunctionOperatorInterpreter> properties = new Dictionary<string, FunctionOperatorInterpreter> ();
	Dictionary<string, FunctionOperatorInterpreter> other = new Dictionary<string, FunctionOperatorInterpreter> ();

	public override void Interpret (Operator op, FunctionBlock block)
	{
		base.Interpret (op, block);
		if (interpret)
			return;
		if (!(op.Context is Context))
			return;
		if (ops == null)
			ops = Engine.GetPlugin<EventFunctionOperators> ();
		var varName = op.Identifier as string;

		FunctionBlock contextBlock = new FunctionBlock (block, block.Method, block.Type);
		block.Statements.Add (contextBlock);
		DeclareVariableStatement declareVar = new DeclareVariableStatement ();
		declareVar.Type = propType;
		declareVar.Name = "subContext" + DeclareVariableStatement.VariableId++;
		declareVar.IsContext = true;

		DeclareVariableStatement contextVar = block.FindStatement<DeclareVariableStatement> (v => v.Name == varName);
		if (contextVar == null)
			contextVar = block.FindStatement<DeclareVariableStatement> (v => v.IsContext);

		if (contextVar == null)
			declareVar.InitExpression = String.Format ("root.{0}", propName);
		else
			declareVar.InitExpression = String.Format ("{1}.{0}", propName, contextVar.Name);
		contextBlock.Statements.Add (declareVar);
		contextBlock.Statements.Add (new ContextStatement () {
			ContextVar = contextVar,
			InterpretInContext = InterpretInContext
		});
		foreach (var entry in (op.Context as Context).Entries)
		{
			var subOp = entry as Operator;
			if (subOp == null)
				continue;
			FunctionOperatorInterpreter opInter = null;
			if (!contextSwitches.TryGetValue (subOp.Identifier as string, out opInter))
			if (!functions.TryGetValue (subOp.Identifier as string, out opInter))
			if (!properties.TryGetValue (subOp.Identifier as string, out opInter))
			if ((opInter = ops.GetInterpreter (subOp, contextBlock)) == null)
			{
				Debug.LogFormat ("Can't interpret context operator {1} in {0}", block.Method.Name, subOp.Identifier);
				continue;
			}
			opInter.Interpret (subOp, contextBlock);
		}

	}

	public FunctionOperatorInterpreter InterpretInContext (Operator op, FunctionBlock block)
	{
		Debug.Log ("interpret in context");
		FunctionOperatorInterpreter opInter = null;
		if (!contextSwitches.TryGetValue (op.Identifier as string, out opInter))
		if (!functions.TryGetValue (op.Identifier as string, out opInter))
		if (!properties.TryGetValue (op.Identifier as string, out opInter))
		{
			Debug.LogFormat ("Can't interpret context operator {1} in {0}", block.Method.Name, op.Identifier);
			return null;
		}
		return opInter;
	}

	public override bool Match (Operator op, FunctionBlock block)
	{
		return false;
	}
	
}