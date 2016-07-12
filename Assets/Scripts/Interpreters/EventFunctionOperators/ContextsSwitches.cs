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
			Debug.Log ("context engine " + inter.Engine);
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
		DeclareVariableStatement declareVar = new DeclareVariableStatement ();
		declareVar.Type = contextType;
		declareVar.Name = "subContext" + DeclareVariableStatement.VariableId++;
		declareVar.IsContext = true;
		DeclareVariableStatement contextVar = block.FindStatement<DeclareVariableStatement> (v => v.IsContext);

		if (contextVar == null)
			declareVar.InitExpression = String.Format ("root.GetComponent<{0}>()", contextType);
		else
			declareVar.InitExpression = String.Format ("{1}.GetComponent<{0}>()", contextType, contextVar.Name);
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

	FunctionOperatorInterpreter InterpretInContext (Operator op, FunctionBlock block)
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

	Type contextType;

	Dictionary<string, FunctionOperatorInterpreter> contextSwitches = new Dictionary<string, FunctionOperatorInterpreter> ();
	Dictionary<string, FunctionOperatorInterpreter> functions = new Dictionary<string, FunctionOperatorInterpreter> ();
	Dictionary<string, FunctionOperatorInterpreter> properties = new Dictionary<string, FunctionOperatorInterpreter> ();
	Dictionary<string, FunctionOperatorInterpreter> other = new Dictionary<string, FunctionOperatorInterpreter> ();

	public ContextSwitchInterpreter (Type type, ScriptEngine engine)
	{
		this.Engine = engine;
		Debug.Log ("Context switch " + type);
		contextType = type;
		var props = type.GetProperties (BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
		var methods = type.GetMethods (BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);

		foreach (var prop in props)
		{
			//Debug.Log (prop.Name);
			if (prop.PropertyType != typeof(string) && (prop.PropertyType.IsClass || (prop.PropertyType.IsValueType && !prop.PropertyType.IsEnum &&
			    prop.PropertyType != typeof(bool) && prop.PropertyType != typeof(float) && prop.PropertyType != typeof(int))))
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
			ContextFunctionCallInterpreter inter = new ContextFunctionCallInterpreter (method);
			inter.Engine = Engine;
			functions.Add (NameTranslator.ScriptNameFromCSharp (method.Name), inter);
		}
	}


}




public class ContextFunctionCallInterpreter : FunctionOperatorInterpreter
{
	ParameterInfo[] argsDef;
	string funcName;
	ExpressionInterpreter exprInter;

	public ContextFunctionCallInterpreter (MethodInfo method)
	{
		funcName = method.Name;
		argsDef = method.GetParameters ();
	}

	public override void Interpret (Operator op, FunctionBlock block)
	{
		if (exprInter == null)
			exprInter = Engine.GetPlugin<ExpressionInterpreter> ();
		var contextVar = block.FindStatement<DeclareVariableStatement> (v => v.IsContext);
		StringBuilder argsBuilder = new StringBuilder ();
		if (op.Args.Count + 1 != argsDef.Length)
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
		if (argsDef [op.Args.Count - 1].ParameterType.IsSubclassOf (typeof(Delegate)))
			argsBuilder.Append (exprInter.InterpretClosure (op.Context as Expression, block, argsDef [op.Args.Count - 1].ParameterType).ExprString).Append (",");
		else
			argsBuilder.Append (exprInter.InterpretExpression (op.Context as Expression, block).ExprString).Append (",");
		
		if (contextVar == null)
			block.Statements.Add (string.Format ("root.{0}({1})", funcName, argsBuilder));
	}

	public override bool Match (Operator op, FunctionBlock block)
	{
		return false;
	}

}

public class ContextPropertyInterpreter : FunctionOperatorInterpreter
{
	ExpressionInterpreter exprInter;

	public override void Interpret (Operator op, FunctionBlock block)
	{
		if (exprInter == null)
			exprInter = Engine.GetPlugin<ExpressionInterpreter> ();
		var context = block.FindStatement<DeclareVariableStatement> (v => v.IsContext);
		if (context == null)
			block.Statements.Add (String.Format ("root.{0} = {1};", propName, exprInter.InterpretExpression (op.Context as Expression, block).ExprString));
		else
			block.Statements.Add (String.Format ("{2}.{0} = {1};", propName, exprInter.InterpretExpression (op.Context as Expression, block).ExprString, context.Name));
	}

	public override bool Match (Operator op, FunctionBlock block)
	{
		return false;
	}

	Type propType;
	string propName;

	public ContextPropertyInterpreter (string propName, Type type)
	{
		this.propName = propName;
		propType = type;
	}
}

public class ContextPropertySwitchInterpreter : FunctionOperatorInterpreter
{
	Type propType;
	string propName;

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

	public ContextPropertySwitchInterpreter (string propName, Type type, ScriptEngine engine)
	{
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
				ContextFunctionCallInterpreter inter = new ContextFunctionCallInterpreter (method);
				inter.Engine = Engine;
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
		if (ops == null)
			ops = Engine.GetPlugin<EventFunctionOperators> ();
		FunctionBlock contextBlock = new FunctionBlock (block, block.Method, block.Type);
		block.Statements.Add (contextBlock);
		DeclareVariableStatement declareVar = new DeclareVariableStatement ();
		declareVar.Type = propType;
		declareVar.Name = "subContext" + DeclareVariableStatement.VariableId++;
		declareVar.IsContext = true;
		DeclareVariableStatement contextVar = block.FindStatement<DeclareVariableStatement> (v => v.IsContext);

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

	FunctionOperatorInterpreter InterpretInContext (Operator op, FunctionBlock block)
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