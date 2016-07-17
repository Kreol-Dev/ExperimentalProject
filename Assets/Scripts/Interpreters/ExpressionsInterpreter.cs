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
	Dictionary<string, ScopeInterpreter> scopeInterpreters = new Dictionary<string, ScopeInterpreter> ();

	public override void Init ()
	{
		var cmpTypes = Engine.FindTypesCastableTo<MonoBehaviour> ();
		foreach (var cmp in cmpTypes)
		{
			string scriptName = NameTranslator.ScriptNameFromCSharp (cmp.Name);
			components.Add (scriptName, cmp);
			HasComponentScope scope = new HasComponentScope ();
			scope.Type = cmp;
			scope.ExprInter = this;
			scopeInterpreters.Add ("has_" + scriptName, scope);
		}


		//string closure = InterpretClosure ();
	}

	public struct Expr
	{
		public string ExprString;
		public Type Type;
	}

	public Operator InterpretScope (Scope scope, FunctionBlock block)
	{
		Operator op = new Operator ();
		op.Identifier = scope;
		op.Context = new Context ();

		return op;
	}

	public List<DeclareVariableStatement> CleanUpContextes = new List<DeclareVariableStatement> ();

	public Expr InterpretScopedList (Scope scope, FunctionBlock block)
	{
		FunctionBlock listBlock = new FunctionBlock (block, block.Method, block.Type);
		block.Statements.Add (listBlock);
		var listVar = new DeclareVariableStatement ();
		listVar.Name = "scopedList" + DeclareVariableStatement.VariableId++;
		//listVar.InitExpression = 



		return new Expr ();
	}

	public void TransformScopedOperator (Operator op, FunctionBlock block)
	{
		var scope = op.Identifier as Scope;
		var endContext = op.Context;
		Operator curOp = null;
		for (int i = 0; i < scope.Parts.Length; i++)
		{
			var part = scope.Parts [i];
			Operator subOp = new Operator ();
			if (part is string)
			{
				var opId = part as string;
				subOp.Identifier = opId;
			} else
			{
				var call = part as FunctionCall;
				subOp.Identifier = call.Name;
				subOp.Args = new List<Expression> ();
				for (int j = 0; j < call.Args.Length; j++)
				{
					subOp.Args.Add (call.Args [j]);
				}
			}
			if (curOp == null)
			{
				op.Args = subOp.Args;
				op.Context = subOp.Context;
				op.Identifier = subOp.Identifier;
				curOp = op;
			} else
			{
				var ctx = new Context ();
				curOp.Context = ctx;
				ctx.Entries.Add (subOp);
				curOp = subOp;
			}

				

			subOp.Init ();
		}
		curOp.Context = endContext;
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

	public Expr InterpretExpression (Expression expression, FunctionBlock block, bool isBool = false)
	{
		CleanUpContextes.Clear ();
		StringBuilder builder = new StringBuilder ();
		builder.Length = 0;
		Expr res;
		if (expression.Operands.Length == 1)
		{
			//ProcessOperand (expression.Operands [0], builder);
			res = ProcessOperand (expression.Operands [0], block, isBool);
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
				isBool = true;
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
				builder.Append (ProcessOperand (expression.Operands [i], block, isBool).ExprString);
				builder.Append (")");
				if (i + 1 < expression.Operands.Length)
					builder.Append (expression.OpToString ((Expression.BinaryOp)expression.Operands [i + 1]));
			}
			res = new Expr (){ ExprString = builder.ToString (), Type = exprType };
		}

		for (int i = 0; i < CleanUpContextes.Count; i++)
		{
			CleanUpContextes [i].IsContext = false;
		}
		CleanUpContextes.Clear ();
		return res;
	}



	public Expr ProcessOperand (object operand, FunctionBlock block, bool isInsideBoolean = false)
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
			//bool exprIsResultVar = false;
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
			bool firstTimeList = true;
			FunctionBlock curBlock = block;
			for (int i = contextVariable ? 0 : 1; i < scope.Length; i++)
			{

				//Debug.LogFormat ("scope part {0} {1} {2}", scope [i], contextType.IsGenericType, contextType.IsGenericType ? (contextType.GetGenericTypeDefinition () == typeof(List<>)).ToString () : "null");
				if (contextType.IsGenericType && contextType.GetGenericTypeDefinition () == typeof(List<>))
				{
					if (firstTimeList)
					{
						DeclareVariableStatement resultVar = new DeclareVariableStatement ();
						CleanUpContextes.Add (resultVar);
						resultVar.Name = "result" + DeclareVariableStatement.VariableId++;
						block.Statements.Add (resultVar);
						resultVar.IsResult = true;
						//resultList.Type = contextType;
						//exprIsResultVar = true;
						firstTimeList = false;
					}
					Debug.Log ("scope list " + scope [i]);
					DeclareVariableStatement declVar = new DeclareVariableStatement ();
					CleanUpContextes.Add (declVar);
					declVar.Name = "list" + DeclareVariableStatement.VariableId++;
					declVar.Type = contextType;
					if (exprBuilder [exprBuilder.Length - 1] == '.')
						exprBuilder.Length -= 1;
					if (hasSign)
					{
						declVar.InitExpression = exprBuilder.ToString (1, exprBuilder.Length - 1);
						exprBuilder.Length = 1;
						//exprBuilder.Append (declVar.Name).Append ('.');
					} else
					{

						declVar.InitExpression = exprBuilder.ToString ();
						exprBuilder.Length = 0;
						//exprBuilder.Append (declVar.Name).Append ('.');
					}
					curBlock.Statements.Add (declVar);
					ForStatement forStatement = new ForStatement ();
					forStatement.RepeatBlock = new FunctionBlock (block, block.Method, block.Type);
					var repeatContext = new DeclareVariableStatement ();
					CleanUpContextes.Add (repeatContext);
					forStatement.RepeatBlock.Statements.Add (repeatContext);
					curBlock.Statements.Add (forStatement);
					curBlock = forStatement.RepeatBlock;
					var iterName = "i" + DeclareVariableStatement.VariableId++;
					forStatement.InsideExpr = String.Format (@"int {0} = 0; {0} < {1}.Count; {0}++", iterName, declVar.Name);

					contextType = contextType.GetGenericArguments () [0];
					repeatContext.Name = "SubContext" + DeclareVariableStatement.VariableId++;
					repeatContext.Type = contextType;
					repeatContext.IsContext = true;
					repeatContext.InitExpression = String.Format (@"{0}[{1}]", declVar.Name, iterName);

				}
				if (scope [i] is FunctionCall)
				{
//					var callOp = ProcessOperand (scope [i], block);
					var call = scope [i] as FunctionCall;
					if (scopeInterpreters.ContainsKey (call.Name))
					{
						var interpreter = scopeInterpreters [call.Name];
						string outExpr = null;
						interpreter.Interpret (call.Args, curBlock, contextType, exprBuilder.ToString (), out outExpr, out curBlock, out contextType, i == scope.Length - 1);
						if (hasSign)
						{
							exprBuilder.Length = 1;
							exprBuilder.Append (outExpr).Append ('.');
						} else
						{

							exprBuilder.Length = 0;
							exprBuilder.Append (outExpr).Append ('.');
						}
					} else
					{
						
						var method = contextType.GetMethod (NameTranslator.CSharpNameFromScript (call.Name));
						if (method == null)
						{
							Debug.LogFormat ("Can't find {0} in {1}", method.Name, contextType);
							break;
						}
						exprBuilder.Append (method.Name).Append ("(");
						var argsDef = method.GetParameters ();
						if (call.Args != null)
						{
							for (int j = 0; j < call.Args.Length; j++)
							{
								if (argsDef [j].ParameterType.IsSubclassOf (typeof(Delegate)))
									exprBuilder.Append (InterpretClosure (call.Args [j], curBlock, argsDef [j].ParameterType).ExprString).Append (",");
								else
									exprBuilder.Append (InterpretExpression (call.Args [j], curBlock).ExprString).Append (",");
							}
						}
						exprBuilder.Append (")");
						contextType = method.ReturnType;


						var declVar = new DeclareVariableStatement ();
						CleanUpContextes.Add (declVar);
						declVar.Name = "prop" + DeclareVariableStatement.VariableId++;
						declVar.IsContext = true;
						if (exprBuilder.Length > 0 && exprBuilder [exprBuilder.Length - 1] == '.')
							exprBuilder.Length -= 1;
						if (hasSign)
						{
							declVar.InitExpression = exprBuilder.ToString (1, exprBuilder.Length - 1);
							exprBuilder.Length = 1;
							exprBuilder.Append (declVar.Name).Append ('.');
						} else
						{

							declVar.InitExpression = exprBuilder.ToString ();
							exprBuilder.Length = 0;
							exprBuilder.Append (declVar.Name).Append ('.');
						}
						declVar.Type = contextType;
						curBlock.Statements.Add (declVar);
					}

				} else
				{
					var propName = NameTranslator.CSharpNameFromScript (scope [i] as string);

					var prop = contextType.GetProperty (propName);
					if (prop == null && components.ContainsKey (scope [i] as string))
					{
						var type = components [scope [i] as string];
						var storedVar = curBlock.FindStatement<DeclareVariableStatement> (v => v.Type == type);
						contextType = type;
						if (storedVar == null)
						{
							storedVar = new DeclareVariableStatement ();
							CleanUpContextes.Add (storedVar);
							curBlock.Statements.Add (storedVar);//block.FindStatement<DeclareVariableStatement> (v => !v.IsContext && v.Type == type);
							storedVar.Name = "StoredVariable" + DeclareVariableStatement.VariableId++;
							storedVar.Type = type;
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
						}
						if (hasSign)
						{
							exprBuilder.Length = 1;
							exprBuilder.Append (storedVar.Name).Append ('.');
						} else
						{

							exprBuilder.Length = 0;
							exprBuilder.Append (storedVar.Name).Append ('.');
						}


					} else if (scopeInterpreters.ContainsKey (scope [i] as string))
					{
						var interpreter = scopeInterpreters [scope [i] as string];
						string outExpr = null;
						interpreter.Interpret (null, curBlock, contextType, exprBuilder.ToString (), out outExpr, out curBlock, out contextType, i == scope.Length - 1);
						if (hasSign)
						{
							exprBuilder.Length = 1;
							exprBuilder.Append (outExpr).Append ('.');
						} else
						{

							exprBuilder.Length = 0;
							exprBuilder.Append (outExpr).Append ('.');
						}

					} else if (prop == null)
					{
						Debug.LogFormat ("Can't find {0} in {1}", propName, contextType);
						break;
					} else
					{
						contextType = prop.PropertyType;
						exprBuilder.Append (propName).Append ('.');
						var declVar = new DeclareVariableStatement ();
						CleanUpContextes.Add (declVar);
						declVar.IsContext = true;
						declVar.Name = "prop" + DeclareVariableStatement.VariableId++;
						if (exprBuilder.Length > 0 && exprBuilder [exprBuilder.Length - 1] == '.')
							exprBuilder.Length -= 1;
						if (hasSign)
						{
							declVar.InitExpression = exprBuilder.ToString (1, exprBuilder.Length - 1);
							exprBuilder.Length = 1;
							exprBuilder.Append (declVar.Name).Append ('.');
						} else
						{

							declVar.InitExpression = exprBuilder.ToString ();
							exprBuilder.Length = 0;
							exprBuilder.Append (declVar.Name).Append ('.');
						}
						declVar.Type = contextType;
						curBlock.Statements.Add (declVar);
					}
				}

			}
			var res = block.FindStatement<DeclareVariableStatement> (v => v.IsResult);
			if (res != null)
			{
				var list = curBlock.FindStatement<DeclareVariableStatement> (v => v.Type.IsGenericType && v.Type.GetGenericTypeDefinition () == typeof(List<>));
				var lasVar = curBlock.FindStatement<DeclareVariableStatement> (v => v.IsContext);
				if (list != null && !firstTimeList)
				{
					curBlock.Statements.Add (String.Format (@"{0}.Add({1});", res.Name, lasVar.Name));
					res.Type = typeof(List<>).MakeGenericType (lasVar.Type);
					res.InitExpression = String.Format ("new {0}();", TypeName.NameOf (res.Type));
				} else
				{
					res.Type = lasVar.Type;
					curBlock.Statements.Add (String.Format (@"{0} = {1}", res.Name, lasVar.Name));
				}
				if (hasSign)
				{
					exprBuilder.Length = 1;
					exprBuilder.Append (res.Name).Append ('.');
				} else
				{

					exprBuilder.Length = 0;
					exprBuilder.Append (res.Name).Append ('.');
				}
			}
			if (res != null && res.Type != null)
			{
				var resType = res.Type;
				res.IsResult = false;
				Debug.Log (isInsideBoolean);
				if (isInsideBoolean && resType.IsGenericType && resType.GetGenericTypeDefinition () == typeof(List<>))
				{
					exprBuilder.Append ("Count");
				}
			} 
			if (exprBuilder.Length > 0 && exprBuilder [exprBuilder.Length - 1] == '.')
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
			var ex = InterpretExpression (operand as Expression, block, isInsideBoolean);
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


public abstract class ScopeInterpreter
{
	public abstract void Interpret (Expression[] args, FunctionBlock block, Type contextType, string exprVal, out string newExprVal, out FunctionBlock newCurBlock, out Type newContextType, bool isLast);

}

public class HasComponentScope : ScopeInterpreter
{
	public Type Type;
	public ExpressionInterpreter ExprInter;

	public override void Interpret (Expression[] args, FunctionBlock block, Type contextType, string exprVal, out string newExprVal, out FunctionBlock newCurBlock, out Type newContextType, bool isLast)
	{
		Debug.Log ("Has component scope");
		IfStatement ifStatement = new IfStatement ();
		DeclareVariableStatement cmpStmt = new DeclareVariableStatement ();
		ExprInter.CleanUpContextes.Add (cmpStmt);
		cmpStmt.Name = "cmp" + DeclareVariableStatement.VariableId++;
		cmpStmt.Type = Type;
		//cmpStmt.IsContext = true;
		string varName = block.FindStatement<DeclareVariableStatement> (v => v.IsContext).Name;
		cmpStmt.InitExpression = String.Format ("{0}.GetComponent<{1}>()", varName, Type);
		ifStatement.CheckExpression = String.Format ("{0} != null", cmpStmt.Name);
		FunctionBlock newBlock = new FunctionBlock (block, block.Method, block.Type);
		ifStatement.TrueBlock = newBlock;
		block.Statements.Add (cmpStmt);
		block.Statements.Add (ifStatement);
		newCurBlock = newBlock;
		newExprVal = exprVal;
		newContextType = contextType;
		if (isLast)
		{
			
			var res = block.FindStatement<DeclareVariableStatement> (v => v.IsResult);
			res.Type = typeof(List<>).MakeGenericType (contextType);
			res.InitExpression = String.Format ("new {0}()", TypeName.NameOf (res.Type));
			newExprVal = res.Name;
			newBlock.Statements.Add (String.Format ("{0}.Add({1});", res.Name, varName));
		}

		//ifStatement.CheckExpression = String.Format("{0}.GetComponen")
		//ifStatement.CheckExpression = 
	}
}

public class ScopeInterpreterAttribute : Attribute
{
	public string Name { get; internal set; }

	public ScopeInterpreterAttribute (string name)
	{
		Name = name;
	}
}

[ScopeInterpreter ("fit")]
public class FitScopeInterpreter : ScopeInterpreter
{
	public override void Interpret (Expression[] args, FunctionBlock block, Type contextType, string exprVal, out string newExprVal, out FunctionBlock newCurBlock, out Type newContextType, bool isLast)
	{
		throw new NotImplementedException ();
	}
}

[ScopeInterpreter ("average")]
public class AverageInterpreter : ScopeInterpreter
{
	public override void Interpret (Expression[] args, FunctionBlock block, Type contextType, string exprVal, out string newExprVal, out FunctionBlock newCurBlock, out Type newContextType, bool isLast)
	{

		throw new NotImplementedException ();
	}
}