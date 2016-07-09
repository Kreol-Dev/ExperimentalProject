using UnityEngine;
using System.Collections;
using InternalDSL;
using System;
using System.Text;


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

	public Expr InterpretClosure (Expression expression, FunctionBlock block, Type closureType)
	{

		return new Expr (){ ExprString = "10", Type = "int" };
	}

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
