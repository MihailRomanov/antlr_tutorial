//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 3.4.1.9004
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// $ANTLR 3.4.1.9004 Simple.g 2012-03-31 12:20:27

// The variable 'variable' is assigned but its value is never used.
#pragma warning disable 219
// Unreachable code detected.
#pragma warning disable 162
// Missing XML comment for publicly visible type or member 'Type_or_Member'
#pragma warning disable 1591
// CLS compliance checking will not be performed on 'type' because it is not visible from outside this assembly.
#pragma warning disable 3019


using System.Collections.Generic;
using Antlr.Runtime;
using Antlr.Runtime.Misc;


using Antlr.Runtime.Tree;
using RewriteRuleITokenStream = Antlr.Runtime.Tree.RewriteRuleTokenStream;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.4.1.9004")]
[System.CLSCompliant(false)]
public partial class SimpleParser : Antlr.Runtime.Parser
{
	internal static readonly string[] tokenNames = new string[] {
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "DIGIT", "DIV", "IDENT", "LETTER", "MINUS", "MUL", "NUMBER", "PLUS", "PROGRAM", "STMT_ASSIGN", "STMT_INPUT", "STMT_PRINT", "WS", "'('", "')'", "','", "';'", "'='", "'input'", "'print'"
	};
	public const int EOF=-1;
	public const int DIGIT=4;
	public const int DIV=5;
	public const int IDENT=6;
	public const int LETTER=7;
	public const int MINUS=8;
	public const int MUL=9;
	public const int NUMBER=10;
	public const int PLUS=11;
	public const int PROGRAM=12;
	public const int STMT_ASSIGN=13;
	public const int STMT_INPUT=14;
	public const int STMT_PRINT=15;
	public const int WS=16;
	public const int T__17=17;
	public const int T__18=18;
	public const int T__19=19;
	public const int T__20=20;
	public const int T__21=21;
	public const int T__22=22;
	public const int T__23=23;

	public SimpleParser(ITokenStream input)
		: this(input, new RecognizerSharedState())
	{
	}
	public SimpleParser(ITokenStream input, RecognizerSharedState state)
		: base(input, state)
	{
		ITreeAdaptor treeAdaptor = default(ITreeAdaptor);
		CreateTreeAdaptor(ref treeAdaptor);
		TreeAdaptor = treeAdaptor ?? new CommonTreeAdaptor();
		OnCreated();
	}
	// Implement this function in your helper file to use a custom tree adaptor
	partial void CreateTreeAdaptor(ref ITreeAdaptor adaptor);

	private ITreeAdaptor adaptor;

	public ITreeAdaptor TreeAdaptor
	{
		get
		{
			return adaptor;
		}

		set
		{
			this.adaptor = value;
		}
	}

	public override string[] TokenNames { get { return SimpleParser.tokenNames; } }
	public override string GrammarFileName { get { return "Simple.g"; } }


	partial void OnCreated();
	partial void EnterRule(string ruleName, int ruleIndex);
	partial void LeaveRule(string ruleName, int ruleIndex);

	#region Rules
	partial void EnterRule_program();
	partial void LeaveRule_program();
	// $ANTLR start "program"
	// Simple.g:21:1: public program : ( stmt ';' )+ -> ^( PROGRAM ( stmt )+ ) ;
	[GrammarRule("program")]
	public AstParserRuleReturnScope<object, IToken> program()
	{
		EnterRule_program();
		EnterRule("program", 1);
		TraceIn("program", 1);
		AstParserRuleReturnScope<object, IToken> retval = new AstParserRuleReturnScope<object, IToken>();
		retval.Start = (IToken)input.LT(1);

		object root_0 = default(object);

		IToken char_literal2 = default(IToken);
		AstParserRuleReturnScope<object, IToken> stmt1 = default(AstParserRuleReturnScope<object, IToken>);

		object char_literal2_tree = default(object);
		RewriteRuleITokenStream stream_20=new RewriteRuleITokenStream(adaptor,"token 20");
		RewriteRuleSubtreeStream stream_stmt=new RewriteRuleSubtreeStream(adaptor,"rule stmt");
		try { DebugEnterRule(GrammarFileName, "program");
		DebugLocation(21, 2);
		try
		{
			// Simple.g:22:2: ( ( stmt ';' )+ -> ^( PROGRAM ( stmt )+ ) )
			DebugEnterAlt(1);
			// Simple.g:22:4: ( stmt ';' )+
			{
			DebugLocation(22, 4);
			// Simple.g:22:4: ( stmt ';' )+
			int cnt1=0;
			try { DebugEnterSubRule(1);
			while (true)
			{
				int alt1=2;
				try { DebugEnterDecision(1, false);
				int LA1_1 = input.LA(1);

				if ((LA1_1==IDENT||(LA1_1>=22 && LA1_1<=23)))
				{
					alt1 = 1;
				}


				} finally { DebugExitDecision(1); }
				switch (alt1)
				{
				case 1:
					DebugEnterAlt(1);
					// Simple.g:22:5: stmt ';'
					{
					DebugLocation(22, 5);
					PushFollow(Follow._stmt_in_program82);
					stmt1=stmt();
					PopFollow();

					stream_stmt.Add(stmt1.Tree);
					DebugLocation(22, 10);
					char_literal2=(IToken)Match(input,20,Follow._20_in_program84);  
					stream_20.Add(char_literal2);


					}
					break;

				default:
					if (cnt1 >= 1)
						goto loop1;

					EarlyExitException eee1 = new EarlyExitException( 1, input );
					DebugRecognitionException(eee1);
					throw eee1;
				}
				cnt1++;
			}
			loop1:
				;

			} finally { DebugExitSubRule(1); }



			{
			// AST REWRITE
			// elements: stmt
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 22:17: -> ^( PROGRAM ( stmt )+ )
			{
				DebugLocation(22, 20);
				// Simple.g:22:20: ^( PROGRAM ( stmt )+ )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(22, 22);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(PROGRAM, "PROGRAM"), root_1);

				DebugLocation(22, 30);
				if (!(stream_stmt.HasNext))
				{
					throw new RewriteEarlyExitException();
				}
				while ( stream_stmt.HasNext )
				{
					DebugLocation(22, 30);
					adaptor.AddChild(root_1, stream_stmt.NextTree());

				}
				stream_stmt.Reset();

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("program", 1);
			LeaveRule("program", 1);
			LeaveRule_program();
		}
		DebugLocation(23, 2);
		} finally { DebugExitRule(GrammarFileName, "program"); }
		return retval;

	}
	// $ANTLR end "program"

	partial void EnterRule_stmt();
	partial void LeaveRule_stmt();
	// $ANTLR start "stmt"
	// Simple.g:25:1: stmt : ( input_stmt | print_stmt | assign_stmt );
	[GrammarRule("stmt")]
	private AstParserRuleReturnScope<object, IToken> stmt()
	{
		EnterRule_stmt();
		EnterRule("stmt", 2);
		TraceIn("stmt", 2);
		AstParserRuleReturnScope<object, IToken> retval = new AstParserRuleReturnScope<object, IToken>();
		retval.Start = (IToken)input.LT(1);

		object root_0 = default(object);

		AstParserRuleReturnScope<object, IToken> input_stmt3 = default(AstParserRuleReturnScope<object, IToken>);
		AstParserRuleReturnScope<object, IToken> print_stmt4 = default(AstParserRuleReturnScope<object, IToken>);
		AstParserRuleReturnScope<object, IToken> assign_stmt5 = default(AstParserRuleReturnScope<object, IToken>);

		try { DebugEnterRule(GrammarFileName, "stmt");
		DebugLocation(25, 1);
		try
		{
			// Simple.g:26:2: ( input_stmt | print_stmt | assign_stmt )
			int alt2=3;
			try { DebugEnterDecision(2, false);
			switch (input.LA(1))
			{
			case 22:
				{
				alt2 = 1;
				}
				break;
			case 23:
				{
				alt2 = 2;
				}
				break;
			case IDENT:
				{
				alt2 = 3;
				}
				break;
			default:
				{
					NoViableAltException nvae = new NoViableAltException("", 2, 0, input, 1);
					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(2); }
			switch (alt2)
			{
			case 1:
				DebugEnterAlt(1);
				// Simple.g:26:4: input_stmt
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(26, 4);
				PushFollow(Follow._input_stmt_in_stmt111);
				input_stmt3=input_stmt();
				PopFollow();

				adaptor.AddChild(root_0, input_stmt3.Tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Simple.g:27:5: print_stmt
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(27, 5);
				PushFollow(Follow._print_stmt_in_stmt118);
				print_stmt4=print_stmt();
				PopFollow();

				adaptor.AddChild(root_0, print_stmt4.Tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Simple.g:28:5: assign_stmt
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(28, 5);
				PushFollow(Follow._assign_stmt_in_stmt125);
				assign_stmt5=assign_stmt();
				PopFollow();

				adaptor.AddChild(root_0, assign_stmt5.Tree);

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("stmt", 2);
			LeaveRule("stmt", 2);
			LeaveRule_stmt();
		}
		DebugLocation(29, 1);
		} finally { DebugExitRule(GrammarFileName, "stmt"); }
		return retval;

	}
	// $ANTLR end "stmt"

	partial void EnterRule_assign_stmt();
	partial void LeaveRule_assign_stmt();
	// $ANTLR start "assign_stmt"
	// Simple.g:31:1: assign_stmt : IDENT '=' expression -> ^( STMT_ASSIGN IDENT expression ) ;
	[GrammarRule("assign_stmt")]
	private AstParserRuleReturnScope<object, IToken> assign_stmt()
	{
		EnterRule_assign_stmt();
		EnterRule("assign_stmt", 3);
		TraceIn("assign_stmt", 3);
		AstParserRuleReturnScope<object, IToken> retval = new AstParserRuleReturnScope<object, IToken>();
		retval.Start = (IToken)input.LT(1);

		object root_0 = default(object);

		IToken IDENT6 = default(IToken);
		IToken char_literal7 = default(IToken);
		AstParserRuleReturnScope<object, IToken> expression8 = default(AstParserRuleReturnScope<object, IToken>);

		object IDENT6_tree = default(object);
		object char_literal7_tree = default(object);
		RewriteRuleITokenStream stream_IDENT=new RewriteRuleITokenStream(adaptor,"token IDENT");
		RewriteRuleITokenStream stream_21=new RewriteRuleITokenStream(adaptor,"token 21");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		try { DebugEnterRule(GrammarFileName, "assign_stmt");
		DebugLocation(31, 1);
		try
		{
			// Simple.g:32:2: ( IDENT '=' expression -> ^( STMT_ASSIGN IDENT expression ) )
			DebugEnterAlt(1);
			// Simple.g:32:4: IDENT '=' expression
			{
			DebugLocation(32, 4);
			IDENT6=(IToken)Match(input,IDENT,Follow._IDENT_in_assign_stmt136);  
			stream_IDENT.Add(IDENT6);

			DebugLocation(32, 10);
			char_literal7=(IToken)Match(input,21,Follow._21_in_assign_stmt138);  
			stream_21.Add(char_literal7);

			DebugLocation(32, 14);
			PushFollow(Follow._expression_in_assign_stmt140);
			expression8=expression();
			PopFollow();

			stream_expression.Add(expression8.Tree);


			{
			// AST REWRITE
			// elements: IDENT, expression
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 32:25: -> ^( STMT_ASSIGN IDENT expression )
			{
				DebugLocation(32, 28);
				// Simple.g:32:28: ^( STMT_ASSIGN IDENT expression )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(32, 30);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(STMT_ASSIGN, "STMT_ASSIGN"), root_1);

				DebugLocation(32, 42);
				adaptor.AddChild(root_1, stream_IDENT.NextNode());
				DebugLocation(32, 48);
				adaptor.AddChild(root_1, stream_expression.NextTree());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("assign_stmt", 3);
			LeaveRule("assign_stmt", 3);
			LeaveRule_assign_stmt();
		}
		DebugLocation(33, 1);
		} finally { DebugExitRule(GrammarFileName, "assign_stmt"); }
		return retval;

	}
	// $ANTLR end "assign_stmt"

	partial void EnterRule_input_stmt();
	partial void LeaveRule_input_stmt();
	// $ANTLR start "input_stmt"
	// Simple.g:35:1: input_stmt : 'input' IDENT -> ^( STMT_INPUT IDENT ) ;
	[GrammarRule("input_stmt")]
	private AstParserRuleReturnScope<object, IToken> input_stmt()
	{
		EnterRule_input_stmt();
		EnterRule("input_stmt", 4);
		TraceIn("input_stmt", 4);
		AstParserRuleReturnScope<object, IToken> retval = new AstParserRuleReturnScope<object, IToken>();
		retval.Start = (IToken)input.LT(1);

		object root_0 = default(object);

		IToken string_literal9 = default(IToken);
		IToken IDENT10 = default(IToken);

		object string_literal9_tree = default(object);
		object IDENT10_tree = default(object);
		RewriteRuleITokenStream stream_22=new RewriteRuleITokenStream(adaptor,"token 22");
		RewriteRuleITokenStream stream_IDENT=new RewriteRuleITokenStream(adaptor,"token IDENT");
		try { DebugEnterRule(GrammarFileName, "input_stmt");
		DebugLocation(35, 1);
		try
		{
			// Simple.g:36:2: ( 'input' IDENT -> ^( STMT_INPUT IDENT ) )
			DebugEnterAlt(1);
			// Simple.g:36:4: 'input' IDENT
			{
			DebugLocation(36, 4);
			string_literal9=(IToken)Match(input,22,Follow._22_in_input_stmt161);  
			stream_22.Add(string_literal9);

			DebugLocation(36, 12);
			IDENT10=(IToken)Match(input,IDENT,Follow._IDENT_in_input_stmt163);  
			stream_IDENT.Add(IDENT10);



			{
			// AST REWRITE
			// elements: IDENT
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 36:18: -> ^( STMT_INPUT IDENT )
			{
				DebugLocation(36, 21);
				// Simple.g:36:21: ^( STMT_INPUT IDENT )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(36, 23);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(STMT_INPUT, "STMT_INPUT"), root_1);

				DebugLocation(36, 34);
				adaptor.AddChild(root_1, stream_IDENT.NextNode());

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("input_stmt", 4);
			LeaveRule("input_stmt", 4);
			LeaveRule_input_stmt();
		}
		DebugLocation(37, 1);
		} finally { DebugExitRule(GrammarFileName, "input_stmt"); }
		return retval;

	}
	// $ANTLR end "input_stmt"

	partial void EnterRule_print_stmt();
	partial void LeaveRule_print_stmt();
	// $ANTLR start "print_stmt"
	// Simple.g:39:1: print_stmt : 'print' expression ( ',' expression )* -> ^( STMT_PRINT ( expression )* ) ;
	[GrammarRule("print_stmt")]
	private AstParserRuleReturnScope<object, IToken> print_stmt()
	{
		EnterRule_print_stmt();
		EnterRule("print_stmt", 5);
		TraceIn("print_stmt", 5);
		AstParserRuleReturnScope<object, IToken> retval = new AstParserRuleReturnScope<object, IToken>();
		retval.Start = (IToken)input.LT(1);

		object root_0 = default(object);

		IToken string_literal11 = default(IToken);
		IToken char_literal13 = default(IToken);
		AstParserRuleReturnScope<object, IToken> expression12 = default(AstParserRuleReturnScope<object, IToken>);
		AstParserRuleReturnScope<object, IToken> expression14 = default(AstParserRuleReturnScope<object, IToken>);

		object string_literal11_tree = default(object);
		object char_literal13_tree = default(object);
		RewriteRuleITokenStream stream_23=new RewriteRuleITokenStream(adaptor,"token 23");
		RewriteRuleITokenStream stream_19=new RewriteRuleITokenStream(adaptor,"token 19");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		try { DebugEnterRule(GrammarFileName, "print_stmt");
		DebugLocation(39, 1);
		try
		{
			// Simple.g:40:2: ( 'print' expression ( ',' expression )* -> ^( STMT_PRINT ( expression )* ) )
			DebugEnterAlt(1);
			// Simple.g:40:4: 'print' expression ( ',' expression )*
			{
			DebugLocation(40, 4);
			string_literal11=(IToken)Match(input,23,Follow._23_in_print_stmt182);  
			stream_23.Add(string_literal11);

			DebugLocation(40, 12);
			PushFollow(Follow._expression_in_print_stmt184);
			expression12=expression();
			PopFollow();

			stream_expression.Add(expression12.Tree);
			DebugLocation(40, 23);
			// Simple.g:40:23: ( ',' expression )*
			try { DebugEnterSubRule(3);
			while (true)
			{
				int alt3=2;
				try { DebugEnterDecision(3, false);
				int LA3_1 = input.LA(1);

				if ((LA3_1==19))
				{
					alt3 = 1;
				}


				} finally { DebugExitDecision(3); }
				switch ( alt3 )
				{
				case 1:
					DebugEnterAlt(1);
					// Simple.g:40:24: ',' expression
					{
					DebugLocation(40, 24);
					char_literal13=(IToken)Match(input,19,Follow._19_in_print_stmt187);  
					stream_19.Add(char_literal13);

					DebugLocation(40, 28);
					PushFollow(Follow._expression_in_print_stmt189);
					expression14=expression();
					PopFollow();

					stream_expression.Add(expression14.Tree);

					}
					break;

				default:
					goto loop3;
				}
			}

			loop3:
				;

			} finally { DebugExitSubRule(3); }



			{
			// AST REWRITE
			// elements: expression
			// token labels: 
			// rule labels: retval
			// token list labels: 
			// rule list labels: 
			// wildcard labels: 
			retval.Tree = root_0;
			RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

			root_0 = (object)adaptor.Nil();
			// 40:42: -> ^( STMT_PRINT ( expression )* )
			{
				DebugLocation(40, 45);
				// Simple.g:40:45: ^( STMT_PRINT ( expression )* )
				{
				object root_1 = (object)adaptor.Nil();
				DebugLocation(40, 47);
				root_1 = (object)adaptor.BecomeRoot((object)adaptor.Create(STMT_PRINT, "STMT_PRINT"), root_1);

				DebugLocation(40, 58);
				// Simple.g:40:58: ( expression )*
				while ( stream_expression.HasNext )
				{
					DebugLocation(40, 58);
					adaptor.AddChild(root_1, stream_expression.NextTree());

				}
				stream_expression.Reset();

				adaptor.AddChild(root_0, root_1);
				}

			}

			retval.Tree = root_0;
			}

			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("print_stmt", 5);
			LeaveRule("print_stmt", 5);
			LeaveRule_print_stmt();
		}
		DebugLocation(41, 1);
		} finally { DebugExitRule(GrammarFileName, "print_stmt"); }
		return retval;

	}
	// $ANTLR end "print_stmt"

	partial void EnterRule_expression();
	partial void LeaveRule_expression();
	// $ANTLR start "expression"
	// Simple.g:43:1: expression : mult ( ( PLUS | MINUS ) ^ mult )* ;
	[GrammarRule("expression")]
	private AstParserRuleReturnScope<object, IToken> expression()
	{
		EnterRule_expression();
		EnterRule("expression", 6);
		TraceIn("expression", 6);
		AstParserRuleReturnScope<object, IToken> retval = new AstParserRuleReturnScope<object, IToken>();
		retval.Start = (IToken)input.LT(1);

		object root_0 = default(object);

		IToken set16 = default(IToken);
		AstParserRuleReturnScope<object, IToken> mult15 = default(AstParserRuleReturnScope<object, IToken>);
		AstParserRuleReturnScope<object, IToken> mult17 = default(AstParserRuleReturnScope<object, IToken>);

		object set16_tree = default(object);
		try { DebugEnterRule(GrammarFileName, "expression");
		DebugLocation(43, 1);
		try
		{
			// Simple.g:44:2: ( mult ( ( PLUS | MINUS ) ^ mult )* )
			DebugEnterAlt(1);
			// Simple.g:44:4: mult ( ( PLUS | MINUS ) ^ mult )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(44, 4);
			PushFollow(Follow._mult_in_expression213);
			mult15=mult();
			PopFollow();

			adaptor.AddChild(root_0, mult15.Tree);
			DebugLocation(44, 9);
			// Simple.g:44:9: ( ( PLUS | MINUS ) ^ mult )*
			try { DebugEnterSubRule(4);
			while (true)
			{
				int alt4=2;
				try { DebugEnterDecision(4, false);
				int LA4_1 = input.LA(1);

				if ((LA4_1==MINUS||LA4_1==PLUS))
				{
					alt4 = 1;
				}


				} finally { DebugExitDecision(4); }
				switch ( alt4 )
				{
				case 1:
					DebugEnterAlt(1);
					// Simple.g:44:11: ( PLUS | MINUS ) ^ mult
					{
					DebugLocation(44, 26);

					set16=(IToken)input.LT(1);
					set16=(IToken)input.LT(1);
					if (input.LA(1)==MINUS||input.LA(1)==PLUS)
					{
						input.Consume();
						root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set16), root_0);
						state.errorRecovery=false;
					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(44, 28);
					PushFollow(Follow._mult_in_expression227);
					mult17=mult();
					PopFollow();

					adaptor.AddChild(root_0, mult17.Tree);

					}
					break;

				default:
					goto loop4;
				}
			}

			loop4:
				;

			} finally { DebugExitSubRule(4); }


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("expression", 6);
			LeaveRule("expression", 6);
			LeaveRule_expression();
		}
		DebugLocation(45, 1);
		} finally { DebugExitRule(GrammarFileName, "expression"); }
		return retval;

	}
	// $ANTLR end "expression"

	partial void EnterRule_mult();
	partial void LeaveRule_mult();
	// $ANTLR start "mult"
	// Simple.g:47:1: mult : atom ( ( MUL | DIV ) ^ atom )* ;
	[GrammarRule("mult")]
	private AstParserRuleReturnScope<object, IToken> mult()
	{
		EnterRule_mult();
		EnterRule("mult", 7);
		TraceIn("mult", 7);
		AstParserRuleReturnScope<object, IToken> retval = new AstParserRuleReturnScope<object, IToken>();
		retval.Start = (IToken)input.LT(1);

		object root_0 = default(object);

		IToken set19 = default(IToken);
		AstParserRuleReturnScope<object, IToken> atom18 = default(AstParserRuleReturnScope<object, IToken>);
		AstParserRuleReturnScope<object, IToken> atom20 = default(AstParserRuleReturnScope<object, IToken>);

		object set19_tree = default(object);
		try { DebugEnterRule(GrammarFileName, "mult");
		DebugLocation(47, 1);
		try
		{
			// Simple.g:48:2: ( atom ( ( MUL | DIV ) ^ atom )* )
			DebugEnterAlt(1);
			// Simple.g:48:4: atom ( ( MUL | DIV ) ^ atom )*
			{
			root_0 = (object)adaptor.Nil();

			DebugLocation(48, 4);
			PushFollow(Follow._atom_in_mult241);
			atom18=atom();
			PopFollow();

			adaptor.AddChild(root_0, atom18.Tree);
			DebugLocation(48, 9);
			// Simple.g:48:9: ( ( MUL | DIV ) ^ atom )*
			try { DebugEnterSubRule(5);
			while (true)
			{
				int alt5=2;
				try { DebugEnterDecision(5, false);
				int LA5_1 = input.LA(1);

				if ((LA5_1==DIV||LA5_1==MUL))
				{
					alt5 = 1;
				}


				} finally { DebugExitDecision(5); }
				switch ( alt5 )
				{
				case 1:
					DebugEnterAlt(1);
					// Simple.g:48:10: ( MUL | DIV ) ^ atom
					{
					DebugLocation(48, 22);

					set19=(IToken)input.LT(1);
					set19=(IToken)input.LT(1);
					if (input.LA(1)==DIV||input.LA(1)==MUL)
					{
						input.Consume();
						root_0 = (object)adaptor.BecomeRoot((object)adaptor.Create(set19), root_0);
						state.errorRecovery=false;
					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(48, 24);
					PushFollow(Follow._atom_in_mult254);
					atom20=atom();
					PopFollow();

					adaptor.AddChild(root_0, atom20.Tree);

					}
					break;

				default:
					goto loop5;
				}
			}

			loop5:
				;

			} finally { DebugExitSubRule(5); }


			}

			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("mult", 7);
			LeaveRule("mult", 7);
			LeaveRule_mult();
		}
		DebugLocation(49, 1);
		} finally { DebugExitRule(GrammarFileName, "mult"); }
		return retval;

	}
	// $ANTLR end "mult"

	partial void EnterRule_atom();
	partial void LeaveRule_atom();
	// $ANTLR start "atom"
	// Simple.g:51:1: atom : ( IDENT | NUMBER | '(' expression ')' -> expression );
	[GrammarRule("atom")]
	private AstParserRuleReturnScope<object, IToken> atom()
	{
		EnterRule_atom();
		EnterRule("atom", 8);
		TraceIn("atom", 8);
		AstParserRuleReturnScope<object, IToken> retval = new AstParserRuleReturnScope<object, IToken>();
		retval.Start = (IToken)input.LT(1);

		object root_0 = default(object);

		IToken IDENT21 = default(IToken);
		IToken NUMBER22 = default(IToken);
		IToken char_literal23 = default(IToken);
		IToken char_literal25 = default(IToken);
		AstParserRuleReturnScope<object, IToken> expression24 = default(AstParserRuleReturnScope<object, IToken>);

		object IDENT21_tree = default(object);
		object NUMBER22_tree = default(object);
		object char_literal23_tree = default(object);
		object char_literal25_tree = default(object);
		RewriteRuleITokenStream stream_17=new RewriteRuleITokenStream(adaptor,"token 17");
		RewriteRuleITokenStream stream_18=new RewriteRuleITokenStream(adaptor,"token 18");
		RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
		try { DebugEnterRule(GrammarFileName, "atom");
		DebugLocation(51, 1);
		try
		{
			// Simple.g:52:2: ( IDENT | NUMBER | '(' expression ')' -> expression )
			int alt6=3;
			try { DebugEnterDecision(6, false);
			switch (input.LA(1))
			{
			case IDENT:
				{
				alt6 = 1;
				}
				break;
			case NUMBER:
				{
				alt6 = 2;
				}
				break;
			case 17:
				{
				alt6 = 3;
				}
				break;
			default:
				{
					NoViableAltException nvae = new NoViableAltException("", 6, 0, input, 1);
					DebugRecognitionException(nvae);
					throw nvae;
				}
			}

			} finally { DebugExitDecision(6); }
			switch (alt6)
			{
			case 1:
				DebugEnterAlt(1);
				// Simple.g:52:4: IDENT
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(52, 4);
				IDENT21=(IToken)Match(input,IDENT,Follow._IDENT_in_atom268); 
				IDENT21_tree = (object)adaptor.Create(IDENT21);
				adaptor.AddChild(root_0, IDENT21_tree);

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Simple.g:53:5: NUMBER
				{
				root_0 = (object)adaptor.Nil();

				DebugLocation(53, 5);
				NUMBER22=(IToken)Match(input,NUMBER,Follow._NUMBER_in_atom275); 
				NUMBER22_tree = (object)adaptor.Create(NUMBER22);
				adaptor.AddChild(root_0, NUMBER22_tree);

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Simple.g:54:5: '(' expression ')'
				{
				DebugLocation(54, 5);
				char_literal23=(IToken)Match(input,17,Follow._17_in_atom282);  
				stream_17.Add(char_literal23);

				DebugLocation(54, 9);
				PushFollow(Follow._expression_in_atom284);
				expression24=expression();
				PopFollow();

				stream_expression.Add(expression24.Tree);
				DebugLocation(54, 20);
				char_literal25=(IToken)Match(input,18,Follow._18_in_atom286);  
				stream_18.Add(char_literal25);



				{
				// AST REWRITE
				// elements: expression
				// token labels: 
				// rule labels: retval
				// token list labels: 
				// rule list labels: 
				// wildcard labels: 
				retval.Tree = root_0;
				RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.Tree:null);

				root_0 = (object)adaptor.Nil();
				// 54:24: -> expression
				{
					DebugLocation(54, 27);
					adaptor.AddChild(root_0, stream_expression.NextTree());

				}

				retval.Tree = root_0;
				}

				}
				break;

			}
			retval.Stop = (IToken)input.LT(-1);

			retval.Tree = (object)adaptor.RulePostProcessing(root_0);
			adaptor.SetTokenBoundaries(retval.Tree, retval.Start, retval.Stop);

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		retval.Tree = (object)adaptor.ErrorNode(input, retval.Start, input.LT(-1), re);

		}
		finally
		{
			TraceOut("atom", 8);
			LeaveRule("atom", 8);
			LeaveRule_atom();
		}
		DebugLocation(55, 1);
		} finally { DebugExitRule(GrammarFileName, "atom"); }
		return retval;

	}
	// $ANTLR end "atom"
	#endregion Rules


	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _stmt_in_program82 = new BitSet(new ulong[]{0x100000UL});
		public static readonly BitSet _20_in_program84 = new BitSet(new ulong[]{0xC00042UL});
		public static readonly BitSet _input_stmt_in_stmt111 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _print_stmt_in_stmt118 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _assign_stmt_in_stmt125 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENT_in_assign_stmt136 = new BitSet(new ulong[]{0x200000UL});
		public static readonly BitSet _21_in_assign_stmt138 = new BitSet(new ulong[]{0x20440UL});
		public static readonly BitSet _expression_in_assign_stmt140 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _22_in_input_stmt161 = new BitSet(new ulong[]{0x40UL});
		public static readonly BitSet _IDENT_in_input_stmt163 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _23_in_print_stmt182 = new BitSet(new ulong[]{0x20440UL});
		public static readonly BitSet _expression_in_print_stmt184 = new BitSet(new ulong[]{0x80002UL});
		public static readonly BitSet _19_in_print_stmt187 = new BitSet(new ulong[]{0x20440UL});
		public static readonly BitSet _expression_in_print_stmt189 = new BitSet(new ulong[]{0x80002UL});
		public static readonly BitSet _mult_in_expression213 = new BitSet(new ulong[]{0x902UL});
		public static readonly BitSet _set_in_expression217 = new BitSet(new ulong[]{0x20440UL});
		public static readonly BitSet _mult_in_expression227 = new BitSet(new ulong[]{0x902UL});
		public static readonly BitSet _atom_in_mult241 = new BitSet(new ulong[]{0x222UL});
		public static readonly BitSet _set_in_mult244 = new BitSet(new ulong[]{0x20440UL});
		public static readonly BitSet _atom_in_mult254 = new BitSet(new ulong[]{0x222UL});
		public static readonly BitSet _IDENT_in_atom268 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NUMBER_in_atom275 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _17_in_atom282 = new BitSet(new ulong[]{0x20440UL});
		public static readonly BitSet _expression_in_atom284 = new BitSet(new ulong[]{0x40000UL});
		public static readonly BitSet _18_in_atom286 = new BitSet(new ulong[]{0x2UL});
	}
	#endregion Follow sets
}