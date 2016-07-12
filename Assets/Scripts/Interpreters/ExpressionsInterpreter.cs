using UnityEngine;
using System.Collections;
using InternalDSL;
using System;
using System.Text;
using System.Collections.Generic;
using System.Reflection;


public class ExpressionInterpreter : ScriptEnginePlugin
{
	Dictionary<string, Type> components = new Dictionary<string, Type> ();


	public override void Init ()
	{
		var cmpTypes = Engine.FindTypesCastableTo<MonoBehaviour> ();
		foreach (var cmp in cmpTypes)
		{
			string scriptName = NameTranslator.ScriptNameFromCSharp (cmp.Name);
			components.Add (scriptName, cmp);
		}
		//string closure = InterpretClosure ();
	}

	public struct Expr
	{
		public string ExprString;
		public Type Type;
	}



	public Expr InterpretClosure (Expression expression, FunctionBlock block, Type closureType)
	{
		StringBuilder closureBuilder = new StringBuilder ();
		var methodInfo = closureType.GetMethod ("Invoke");
		var args = methodInfo.GetParameters ();
		FunctionBlock lambdaBlock = new FunctionBlock (block, block.Method, block.Type);
		lambdaBlock.DefaultScope = args [0].Name;

		closureBuilder.Append ("(");
		foreach (var param in args)
		{
			var argVar = new DeclareVariableStatement ();
			argVar.Name = param.Name;
			argVar.IsArg = true;
			argVar.Type = param.ParameterType;
			lambdaBlock.Statements.Add (argVar);
			closureBuilder.Append (param.ParameterType).Append (" ").Append (param.Name).Append (",");
		}
		if (closureBuilder [closureBuilder.Length - 1] == ',')
			closureBuilder.Length -= 1;
		closureBuilder.Append (")=>{");
		foreach (var statement in lambdaBlock.Statements)
			closureBuilder.Append (statement).Append (";");
		if (methodInfo.ReturnType != null)
			closureBuilder.Append ("return ");
		var internals = InterpretExpression (expression, lambdaBlock);
		closureBuilder.Append (internals.ExprString).Append (";");
		closureBuilder.Append ("}");


		return new Expr ();
		//return InterpretExpression (expression, block);
	}

	public Expr InterpretExpression (Expression expression, FunctionBlock block)
	{
		StringBuilder builder = new StringBuilder ();
		builder.Length = 0;
		if (expression.Operands.Length == 1)
		{
			//ProcessOperand (expression.Operands [0], builder);
			return ProcessOperand (expression.Operands [0], block);
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
			Debug.Log (expression);
			for (int i = 0; i < expression.Operands.Length; i += 2)
			{
				Debug.Log ("OPERAND " + expression.Operands [i]);
				builder.Append ("(");
				builder.Append (ProcessOperand (expression.Operands [i], block).ExprString);
				builder.Append (")");
				if (i + 1 < expression.Operands.Length)
					builder.Append (expression.OpToString ((Expression.BinaryOp)expression.Operands [i + 1]));
			}
			return new Expr (){ ExprString = builder.ToString (), Type = exprType };
		}
	}



	public Expr ProcessOperand (object operand, FunctionBlock block)
	{
		Expr returnExpr = new Expr ();
		StringBuilder exprBuilder = new StringBuilder ();
		bool hasSign = false;
		if (operand is ExprAtom)
		{
			if ((operand as ExprAtom).Op == ExprAtom.UnaryOp.Inverse)
			{

				exprBuilder.Append ("!");
				hasSign = true;
			} else if ((operand as ExprAtom).Op == ExprAtom.UnaryOp.Not)
			{
				hasSign = true;
				exprBuilder.Append ("-");
			}
			operand = (operand as ExprAtom).Content;
		}


		if (operand is Scope)
		{
			var scope = (operand as Scope).Parts;
			bool contextVariable = true;
			var contextVar = block.FindStatement<DeclareVariableStatement> (v => v.Name == scope [0] as string);
			if (contextVariable = (contextVar == null))
				contextVar = block.FindStatement<DeclareVariableStatement> (v => v.IsContext);
			string contextName = null; //!contextVariable ? "root" : contextVar.Name;
			Type contextType = null; //!contextVariable ? typeof(GameObject) : contextVar.Type;
			if (contextVar == null)
			{
				contextName = block.DefaultScope;
				contextType = typeof(GameObject);
			} else
			{
				contextName = contextVar.Name;
				contextType = contextVar.Type;
			}

			exprBuilder.Append (contextName).Append (".");
			for (int i = contextVariable ? 0 : 1; i < scope.Length; i++)
			{
				if (scope [i] is FunctionCall)
				{
//					var callOp = ProcessOperand (scope [i], block);
					var call = scope [i] as FunctionCall;
					var method = contextType.GetMethod (NameTranslator.CSharpNameFromScript (call.Name));
					if (method == null)
					{
						Debug.LogFormat ("Can't find {0} in {1}", method.Name, contextType);
						break;
					}
					var argsDef = method.GetParameters ();
					for (int j = 0; j < call.Args.Length; j++)
					{
						if (argsDef [j].ParameterType.IsSubclassOf (typeof(Delegate)))
							exprBuilder.Append (InterpretClosure (call.Args [j], block, argsDef [j].ParameterType).ExprString).Append (",");
						else
							exprBuilder.Append (InterpretExpression (call.Args [j], block).ExprString).Append (",");
					}
					contextType = method.ReturnType;
				} else
				{
					var propName = NameTranslator.CSharpNameFromScript (scope [i] as string);

					if (components.ContainsKey (scope [i] as string))
					{
						var type = components [scope [i] as string];
						var storedVar = new DeclareVariableStatement ();
						block.Statements.Add (storedVar);//block.FindStatement<DeclareVariableStatement> (v => !v.IsContext && v.Type == type);
						storedVar.Name = "StoredVariable" + DeclareVariableStatement.VariableId++;
						storedVar.Type = type;
						contextType = type;
						exprBuilder.Append (String.Format ("GetComponent<{0}>()", type));
						if (hasSign)
						{
							storedVar.InitExpression = exprBuilder.ToString (1, exprBuilder.Length - 1);
							exprBuilder.Length = 1;
							exprBuilder.Append (storedVar.Name).Append ('.');
						} else
						{

							storedVar.InitExpression = exprBuilder.ToString ();
							exprBuilder.Length = 0;
							exprBuilder.Append (storedVar.Name).Append ('.');
						}

					} else
					{
						var prop = contextType.GetProperty (propName);

						if (prop != null)
							contextType = prop.PropertyType;
						else
						{
							Debug.LogFormat ("Can't find {0} in {1}", propName, contextType);
							break;
						}
						exprBuilder.Append (propName).Append ('.');
					}
				}
			}
			if (exprBuilder [exprBuilder.Length - 1] == '.')
				exprBuilder.Length -= 1;
			
		} else if (operand is FunctionCall)
		{

//			var call = operand as FunctionCall;
//			for (int i = 0; i < call.Args.Length; i++)
//			{
//				
//			}

		} else if (operand is Expression)
		{
			var ex = InterpretExpression (operand as Expression, block);
			exprBuilder.Append (ex.ExprString);
			returnExpr.Type = ex.Type;
		} else
		{
			returnExpr.Type = operand.GetType ();
			exprBuilder.Append (operand);
		}
		returnExpr.ExprString = exprBuilder.ToString ();
		return returnExpr;
	}

}


