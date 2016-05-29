/*
 * DefAnalyzer.cs
 *
 * THIS FILE HAS BEEN GENERATED AUTOMATICALLY. DO NOT EDIT!
 */

using PerCederberg.Grammatica.Runtime;

namespace InternalDSL
{

	/**
     * <remarks>A class providing callback methods for the
     * parser.</remarks>
     */
	internal abstract class DefAnalyzer : Analyzer
	{

		/**
         * <summary>Called when entering a parse tree node.</summary>
         *
         * <param name='node'>the node being entered</param>
         *
         * <exception cref='ParseException'>if the node analysis
         * discovered errors</exception>
         */
		public override void Enter (Node node)
		{
			switch (node.Id)
			{
			case (int) DefConstants.OPEN_TABLE:
				EnterOpenTable ((Token)node);
				break;
			case (int) DefConstants.CLOSE_TABLE:
				EnterCloseTable ((Token)node);
				break;
			case (int) DefConstants.ASSIGN:
				EnterAssign ((Token)node);
				break;
			case (int) DefConstants.DOT:
				EnterDot ((Token)node);
				break;
			case (int) DefConstants.DELIMITER:
				EnterDelimiter ((Token)node);
				break;
			case (int) DefConstants.OPEN_FUNCTION:
				EnterOpenFunction ((Token)node);
				break;
			case (int) DefConstants.CLOSE_FUNCTION:
				EnterCloseFunction ((Token)node);
				break;
			case (int) DefConstants.NUMBER:
				EnterNumber ((Token)node);
				break;
			case (int) DefConstants.IDENTIFIER:
				EnterIdentifier ((Token)node);
				break;
			case (int) DefConstants.STRING:
				EnterString ((Token)node);
				break;
			case (int) DefConstants.ROOT:
				EnterRoot ((Production)node);
				break;
			case (int) DefConstants.SPECIFIC_ID:
				EnterSpecificId ((Production)node);
				break;
			case (int) DefConstants.TABLE:
				EnterTable ((Production)node);
				break;
			case (int) DefConstants.TABLE_CONTENT:
				EnterTableContent ((Production)node);
				break;
			case (int) DefConstants.EXPRESSION:
				EnterExpression ((Production)node);
				break;
			case (int) DefConstants.EXPR:
				EnterExpr ((Production)node);
				break;
			case (int) DefConstants.FUNCTION:
				EnterFunction ((Production)node);
				break;
			}
		}

		/**
         * <summary>Called when exiting a parse tree node.</summary>
         *
         * <param name='node'>the node being exited</param>
         *
         * <returns>the node to add to the parse tree, or
         *          null if no parse tree should be created</returns>
         *
         * <exception cref='ParseException'>if the node analysis
         * discovered errors</exception>
         */
		public override Node Exit (Node node)
		{
			switch (node.Id)
			{
			case (int) DefConstants.OPEN_TABLE:
				return ExitOpenTable ((Token)node);
			case (int) DefConstants.CLOSE_TABLE:
				return ExitCloseTable ((Token)node);
			case (int) DefConstants.ASSIGN:
				return ExitAssign ((Token)node);
			case (int) DefConstants.DOT:
				return ExitDot ((Token)node);
			case (int) DefConstants.DELIMITER:
				return ExitDelimiter ((Token)node);
			case (int) DefConstants.OPEN_FUNCTION:
				return ExitOpenFunction ((Token)node);
			case (int) DefConstants.CLOSE_FUNCTION:
				return ExitCloseFunction ((Token)node);
			case (int) DefConstants.NUMBER:
				return ExitNumber ((Token)node);
			case (int) DefConstants.IDENTIFIER:
				return ExitIdentifier ((Token)node);
			case (int) DefConstants.STRING:
				return ExitString ((Token)node);
			case (int) DefConstants.ROOT:
				return ExitRoot ((Production)node);
			case (int) DefConstants.SPECIFIC_ID:
				return ExitSpecificId ((Production)node);
			case (int) DefConstants.TABLE:
				return ExitTable ((Production)node);
			case (int) DefConstants.TABLE_CONTENT:
				return ExitTableContent ((Production)node);
			case (int) DefConstants.EXPRESSION:
				return ExitExpression ((Production)node);
			case (int) DefConstants.EXPR:
				return ExitExpr ((Production)node);
			case (int) DefConstants.FUNCTION:
				return ExitFunction ((Production)node);
			}
			return node;
		}

		/**
         * <summary>Called when adding a child to a parse tree
         * node.</summary>
         *
         * <param name='node'>the parent node</param>
         * <param name='child'>the child node, or null</param>
         *
         * <exception cref='ParseException'>if the node analysis
         * discovered errors</exception>
         */
		public override void Child (Production node, Node child)
		{
			switch (node.Id)
			{
			case (int) DefConstants.ROOT:
				ChildRoot (node, child);
				break;
			case (int) DefConstants.SPECIFIC_ID:
				ChildSpecificId (node, child);
				break;
			case (int) DefConstants.TABLE:
				ChildTable (node, child);
				break;
			case (int) DefConstants.TABLE_CONTENT:
				ChildTableContent (node, child);
				break;
			case (int) DefConstants.EXPRESSION:
				ChildExpression (node, child);
				break;
			case (int) DefConstants.EXPR:
				ChildExpr (node, child);
				break;
			case (int) DefConstants.FUNCTION:
				ChildFunction (node, child);
				break;
			}
		}

		/**
         * <summary>Called when entering a parse tree node.</summary>
         *
         * <param name='node'>the node being entered</param>
         *
         * <exception cref='ParseException'>if the node analysis
         * discovered errors</exception>
         */
		public virtual void EnterOpenTable (Token node)
		{
		}

		/**
         * <summary>Called when exiting a parse tree node.</summary>
         *
         * <param name='node'>the node being exited</param>
         *
         * <returns>the node to add to the parse tree, or
         *          null if no parse tree should be created</returns>
         *
         * <exception cref='ParseException'>if the node analysis
         * discovered errors</exception>
         */
		public virtual Node ExitOpenTable (Token node)
		{
			return node;
		}

		/**
         * <summary>Called when entering a parse tree node.</summary>
         *
         * <param name='node'>the node being entered</param>
         *
         * <exception cref='ParseException'>if the node analysis
         * discovered errors</exception>
         */
		public virtual void EnterCloseTable (Token node)
		{
		}

		/**
         * <summary>Called when exiting a parse tree node.</summary>
         *
         * <param name='node'>the node being exited</param>
         *
         * <returns>the node to add to the parse tree, or
         *          null if no parse tree should be created</returns>
         *
         * <exception cref='ParseException'>if the node analysis
         * discovered errors</exception>
         */
		public virtual Node ExitCloseTable (Token node)
		{
			return node;
		}

		/**
         * <summary>Called when entering a parse tree node.</summary>
         *
         * <param name='node'>the node being entered</param>
         *
         * <exception cref='ParseException'>if the node analysis
         * discovered errors</exception>
         */
		public virtual void EnterAssign (Token node)
		{
		}

		/**
         * <summary>Called when exiting a parse tree node.</summary>
         *
         * <param name='node'>the node being exited</param>
         *
         * <returns>the node to add to the parse tree, or
         *          null if no parse tree should be created</returns>
         *
         * <exception cref='ParseException'>if the node analysis
         * discovered errors</exception>
         */
		public virtual Node ExitAssign (Token node)
		{
			return node;
		}

		/**
         * <summary>Called when entering a parse tree node.</summary>
         *
         * <param name='node'>the node being entered</param>
         *
         * <exception cref='ParseException'>if the node analysis
         * discovered errors</exception>
         */
		public virtual void EnterDot (Token node)
		{
		}

		/**
         * <summary>Called when exiting a parse tree node.</summary>
         *
         * <param name='node'>the node being exited</param>
         *
         * <returns>the node to add to the parse tree, or
         *          null if no parse tree should be created</returns>
         *
         * <exception cref='ParseException'>if the node analysis
         * discovered errors</exception>
         */
		public virtual Node ExitDot (Token node)
		{
			return node;
		}

		/**
         * <summary>Called when entering a parse tree node.</summary>
         *
         * <param name='node'>the node being entered</param>
         *
         * <exception cref='ParseException'>if the node analysis
         * discovered errors</exception>
         */
		public virtual void EnterDelimiter (Token node)
		{
		}

		/**
         * <summary>Called when exiting a parse tree node.</summary>
         *
         * <param name='node'>the node being exited</param>
         *
         * <returns>the node to add to the parse tree, or
         *          null if no parse tree should be created</returns>
         *
         * <exception cref='ParseException'>if the node analysis
         * discovered errors</exception>
         */
		public virtual Node ExitDelimiter (Token node)
		{
			return node;
		}

		/**
         * <summary>Called when entering a parse tree node.</summary>
         *
         * <param name='node'>the node being entered</param>
         *
         * <exception cref='ParseException'>if the node analysis
         * discovered errors</exception>
         */
		public virtual void EnterOpenFunction (Token node)
		{
		}

		/**
         * <summary>Called when exiting a parse tree node.</summary>
         *
         * <param name='node'>the node being exited</param>
         *
         * <returns>the node to add to the parse tree, or
         *          null if no parse tree should be created</returns>
         *
         * <exception cref='ParseException'>if the node analysis
         * discovered errors</exception>
         */
		public virtual Node ExitOpenFunction (Token node)
		{
			return node;
		}

		/**
         * <summary>Called when entering a parse tree node.</summary>
         *
         * <param name='node'>the node being entered</param>
         *
         * <exception cref='ParseException'>if the node analysis
         * discovered errors</exception>
         */
		public virtual void EnterCloseFunction (Token node)
		{
		}

		/**
         * <summary>Called when exiting a parse tree node.</summary>
         *
         * <param name='node'>the node being exited</param>
         *
         * <returns>the node to add to the parse tree, or
         *          null if no parse tree should be created</returns>
         *
         * <exception cref='ParseException'>if the node analysis
         * discovered errors</exception>
         */
		public virtual Node ExitCloseFunction (Token node)
		{
			return node;
		}

		/**
         * <summary>Called when entering a parse tree node.</summary>
         *
         * <param name='node'>the node being entered</param>
         *
         * <exception cref='ParseException'>if the node analysis
         * discovered errors</exception>
         */
		public virtual void EnterNumber (Token node)
		{
		}

		/**
         * <summary>Called when exiting a parse tree node.</summary>
         *
         * <param name='node'>the node being exited</param>
         *
         * <returns>the node to add to the parse tree, or
         *          null if no parse tree should be created</returns>
         *
         * <exception cref='ParseException'>if the node analysis
         * discovered errors</exception>
         */
		public virtual Node ExitNumber (Token node)
		{
			return node;
		}

		/**
         * <summary>Called when entering a parse tree node.</summary>
         *
         * <param name='node'>the node being entered</param>
         *
         * <exception cref='ParseException'>if the node analysis
         * discovered errors</exception>
         */
		public virtual void EnterIdentifier (Token node)
		{
		}

		/**
         * <summary>Called when exiting a parse tree node.</summary>
         *
         * <param name='node'>the node being exited</param>
         *
         * <returns>the node to add to the parse tree, or
         *          null if no parse tree should be created</returns>
         *
         * <exception cref='ParseException'>if the node analysis
         * discovered errors</exception>
         */
		public virtual Node ExitIdentifier (Token node)
		{
			return node;
		}

		/**
         * <summary>Called when entering a parse tree node.</summary>
         *
         * <param name='node'>the node being entered</param>
         *
         * <exception cref='ParseException'>if the node analysis
         * discovered errors</exception>
         */
		public virtual void EnterString (Token node)
		{
		}

		/**
         * <summary>Called when exiting a parse tree node.</summary>
         *
         * <param name='node'>the node being exited</param>
         *
         * <returns>the node to add to the parse tree, or
         *          null if no parse tree should be created</returns>
         *
         * <exception cref='ParseException'>if the node analysis
         * discovered errors</exception>
         */
		public virtual Node ExitString (Token node)
		{
			return node;
		}

		/**
         * <summary>Called when entering a parse tree node.</summary>
         *
         * <param name='node'>the node being entered</param>
         *
         * <exception cref='ParseException'>if the node analysis
         * discovered errors</exception>
         */
		public virtual void EnterRoot (Production node)
		{
		}

		/**
         * <summary>Called when exiting a parse tree node.</summary>
         *
         * <param name='node'>the node being exited</param>
         *
         * <returns>the node to add to the parse tree, or
         *          null if no parse tree should be created</returns>
         *
         * <exception cref='ParseException'>if the node analysis
         * discovered errors</exception>
         */
		public virtual Node ExitRoot (Production node)
		{
			return node;
		}

		/**
         * <summary>Called when adding a child to a parse tree
         * node.</summary>
         *
         * <param name='node'>the parent node</param>
         * <param name='child'>the child node, or null</param>
         *
         * <exception cref='ParseException'>if the node analysis
         * discovered errors</exception>
         */
		public virtual void ChildRoot (Production node, Node child)
		{
			node.AddChild (child);
		}

		/**
         * <summary>Called when entering a parse tree node.</summary>
         *
         * <param name='node'>the node being entered</param>
         *
         * <exception cref='ParseException'>if the node analysis
         * discovered errors</exception>
         */
		public virtual void EnterSpecificId (Production node)
		{
		}

		/**
         * <summary>Called when exiting a parse tree node.</summary>
         *
         * <param name='node'>the node being exited</param>
         *
         * <returns>the node to add to the parse tree, or
         *          null if no parse tree should be created</returns>
         *
         * <exception cref='ParseException'>if the node analysis
         * discovered errors</exception>
         */
		public virtual Node ExitSpecificId (Production node)
		{
			return node;
		}

		/**
         * <summary>Called when adding a child to a parse tree
         * node.</summary>
         *
         * <param name='node'>the parent node</param>
         * <param name='child'>the child node, or null</param>
         *
         * <exception cref='ParseException'>if the node analysis
         * discovered errors</exception>
         */
		public virtual void ChildSpecificId (Production node, Node child)
		{
			node.AddChild (child);
		}

		/**
         * <summary>Called when entering a parse tree node.</summary>
         *
         * <param name='node'>the node being entered</param>
         *
         * <exception cref='ParseException'>if the node analysis
         * discovered errors</exception>
         */
		public virtual void EnterTable (Production node)
		{
		}

		/**
         * <summary>Called when exiting a parse tree node.</summary>
         *
         * <param name='node'>the node being exited</param>
         *
         * <returns>the node to add to the parse tree, or
         *          null if no parse tree should be created</returns>
         *
         * <exception cref='ParseException'>if the node analysis
         * discovered errors</exception>
         */
		public virtual Node ExitTable (Production node)
		{
			return node;
		}

		/**
         * <summary>Called when adding a child to a parse tree
         * node.</summary>
         *
         * <param name='node'>the parent node</param>
         * <param name='child'>the child node, or null</param>
         *
         * <exception cref='ParseException'>if the node analysis
         * discovered errors</exception>
         */
		public virtual void ChildTable (Production node, Node child)
		{
			node.AddChild (child);
		}

		/**
         * <summary>Called when entering a parse tree node.</summary>
         *
         * <param name='node'>the node being entered</param>
         *
         * <exception cref='ParseException'>if the node analysis
         * discovered errors</exception>
         */
		public virtual void EnterTableContent (Production node)
		{
		}

		/**
         * <summary>Called when exiting a parse tree node.</summary>
         *
         * <param name='node'>the node being exited</param>
         *
         * <returns>the node to add to the parse tree, or
         *          null if no parse tree should be created</returns>
         *
         * <exception cref='ParseException'>if the node analysis
         * discovered errors</exception>
         */
		public virtual Node ExitTableContent (Production node)
		{
			return node;
		}

		/**
         * <summary>Called when adding a child to a parse tree
         * node.</summary>
         *
         * <param name='node'>the parent node</param>
         * <param name='child'>the child node, or null</param>
         *
         * <exception cref='ParseException'>if the node analysis
         * discovered errors</exception>
         */
		public virtual void ChildTableContent (Production node, Node child)
		{
			node.AddChild (child);
		}

		/**
         * <summary>Called when entering a parse tree node.</summary>
         *
         * <param name='node'>the node being entered</param>
         *
         * <exception cref='ParseException'>if the node analysis
         * discovered errors</exception>
         */
		public virtual void EnterExpression (Production node)
		{
		}

		/**
         * <summary>Called when exiting a parse tree node.</summary>
         *
         * <param name='node'>the node being exited</param>
         *
         * <returns>the node to add to the parse tree, or
         *          null if no parse tree should be created</returns>
         *
         * <exception cref='ParseException'>if the node analysis
         * discovered errors</exception>
         */
		public virtual Node ExitExpression (Production node)
		{
			return node;
		}

		/**
         * <summary>Called when adding a child to a parse tree
         * node.</summary>
         *
         * <param name='node'>the parent node</param>
         * <param name='child'>the child node, or null</param>
         *
         * <exception cref='ParseException'>if the node analysis
         * discovered errors</exception>
         */
		public virtual void ChildExpression (Production node, Node child)
		{
			node.AddChild (child);
		}

		/**
         * <summary>Called when entering a parse tree node.</summary>
         *
         * <param name='node'>the node being entered</param>
         *
         * <exception cref='ParseException'>if the node analysis
         * discovered errors</exception>
         */
		public virtual void EnterExpr (Production node)
		{
		}

		/**
         * <summary>Called when exiting a parse tree node.</summary>
         *
         * <param name='node'>the node being exited</param>
         *
         * <returns>the node to add to the parse tree, or
         *          null if no parse tree should be created</returns>
         *
         * <exception cref='ParseException'>if the node analysis
         * discovered errors</exception>
         */
		public virtual Node ExitExpr (Production node)
		{
			return node;
		}

		/**
         * <summary>Called when adding a child to a parse tree
         * node.</summary>
         *
         * <param name='node'>the parent node</param>
         * <param name='child'>the child node, or null</param>
         *
         * <exception cref='ParseException'>if the node analysis
         * discovered errors</exception>
         */
		public virtual void ChildExpr (Production node, Node child)
		{
			node.AddChild (child);
		}

		/**
         * <summary>Called when entering a parse tree node.</summary>
         *
         * <param name='node'>the node being entered</param>
         *
         * <exception cref='ParseException'>if the node analysis
         * discovered errors</exception>
         */
		public virtual void EnterFunction (Production node)
		{
		}

		/**
         * <summary>Called when exiting a parse tree node.</summary>
         *
         * <param name='node'>the node being exited</param>
         *
         * <returns>the node to add to the parse tree, or
         *          null if no parse tree should be created</returns>
         *
         * <exception cref='ParseException'>if the node analysis
         * discovered errors</exception>
         */
		public virtual Node ExitFunction (Production node)
		{
			return node;
		}

		/**
         * <summary>Called when adding a child to a parse tree
         * node.</summary>
         *
         * <param name='node'>the parent node</param>
         * <param name='child'>the child node, or null</param>
         *
         * <exception cref='ParseException'>if the node analysis
         * discovered errors</exception>
         */
		public virtual void ChildFunction (Production node, Node child)
		{
			node.AddChild (child);
		}
	}
}
