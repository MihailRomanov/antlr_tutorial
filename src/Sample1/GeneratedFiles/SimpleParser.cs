//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 3.4.1.9004
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// $ANTLR 3.4.1.9004 Simple.g 2012-02-19 09:23:59

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

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "3.4.1.9004")]
[System.CLSCompliant(false)]
public partial class SimpleParser : Antlr.Runtime.Parser
{
	internal static readonly string[] tokenNames = new string[] {
		"<invalid>", "<EOR>", "<DOWN>", "<UP>", "DIGIT", "IDENT", "LETTER", "NUMBER", "WS", "'('", "')'", "'*'", "'+'", "','", "'-'", "'/'", "';'", "'='", "'input'", "'print'"
	};
	public const int EOF=-1;
	public const int DIGIT=4;
	public const int IDENT=5;
	public const int LETTER=6;
	public const int NUMBER=7;
	public const int WS=8;
	public const int T__9=9;
	public const int T__10=10;
	public const int T__11=11;
	public const int T__12=12;
	public const int T__13=13;
	public const int T__14=14;
	public const int T__15=15;
	public const int T__16=16;
	public const int T__17=17;
	public const int T__18=18;
	public const int T__19=19;

	public SimpleParser(ITokenStream input)
		: this(input, new RecognizerSharedState())
	{
	}
	public SimpleParser(ITokenStream input, RecognizerSharedState state)
		: base(input, state)
	{
		OnCreated();
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
	// Simple.g:4:1: public program : ( stmt ';' )+ ;
	[GrammarRule("program")]
	public void program()
	{
		EnterRule_program();
		EnterRule("program", 1);
		TraceIn("program", 1);
		try { DebugEnterRule(GrammarFileName, "program");
		DebugLocation(4, 1);
		try
		{
			// Simple.g:5:2: ( ( stmt ';' )+ )
			DebugEnterAlt(1);
			// Simple.g:5:4: ( stmt ';' )+
			{
			DebugLocation(5, 4);
			// Simple.g:5:4: ( stmt ';' )+
			int cnt1=0;
			try { DebugEnterSubRule(1);
			while (true)
			{
				int alt1=2;
				try { DebugEnterDecision(1, false);
				int LA1_1 = input.LA(1);

				if ((LA1_1==IDENT||(LA1_1>=18 && LA1_1<=19)))
				{
					alt1 = 1;
				}


				} finally { DebugExitDecision(1); }
				switch (alt1)
				{
				case 1:
					DebugEnterAlt(1);
					// Simple.g:5:5: stmt ';'
					{
					DebugLocation(5, 5);
					PushFollow(Follow._stmt_in_program15);
					stmt();
					PopFollow();

					DebugLocation(5, 10);
					Match(input,16,Follow._16_in_program17); 

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


			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("program", 1);
			LeaveRule("program", 1);
			LeaveRule_program();
		}
		DebugLocation(6, 1);
		} finally { DebugExitRule(GrammarFileName, "program"); }
		return;

	}
	// $ANTLR end "program"

	partial void EnterRule_stmt();
	partial void LeaveRule_stmt();
	// $ANTLR start "stmt"
	// Simple.g:8:1: stmt : ( input_stmt | print_stmt | assign_stmt );
	[GrammarRule("stmt")]
	private void stmt()
	{
		EnterRule_stmt();
		EnterRule("stmt", 2);
		TraceIn("stmt", 2);
		try { DebugEnterRule(GrammarFileName, "stmt");
		DebugLocation(8, 1);
		try
		{
			// Simple.g:9:2: ( input_stmt | print_stmt | assign_stmt )
			int alt2=3;
			try { DebugEnterDecision(2, false);
			switch (input.LA(1))
			{
			case 18:
				{
				alt2 = 1;
				}
				break;
			case 19:
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
				// Simple.g:9:4: input_stmt
				{
				DebugLocation(9, 4);
				PushFollow(Follow._input_stmt_in_stmt33);
				input_stmt();
				PopFollow();


				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Simple.g:10:5: print_stmt
				{
				DebugLocation(10, 5);
				PushFollow(Follow._print_stmt_in_stmt40);
				print_stmt();
				PopFollow();


				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Simple.g:11:5: assign_stmt
				{
				DebugLocation(11, 5);
				PushFollow(Follow._assign_stmt_in_stmt47);
				assign_stmt();
				PopFollow();


				}
				break;

			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("stmt", 2);
			LeaveRule("stmt", 2);
			LeaveRule_stmt();
		}
		DebugLocation(12, 1);
		} finally { DebugExitRule(GrammarFileName, "stmt"); }
		return;

	}
	// $ANTLR end "stmt"

	partial void EnterRule_assign_stmt();
	partial void LeaveRule_assign_stmt();
	// $ANTLR start "assign_stmt"
	// Simple.g:14:1: assign_stmt : IDENT '=' expression ;
	[GrammarRule("assign_stmt")]
	private void assign_stmt()
	{
		EnterRule_assign_stmt();
		EnterRule("assign_stmt", 3);
		TraceIn("assign_stmt", 3);
		try { DebugEnterRule(GrammarFileName, "assign_stmt");
		DebugLocation(14, 1);
		try
		{
			// Simple.g:15:2: ( IDENT '=' expression )
			DebugEnterAlt(1);
			// Simple.g:15:4: IDENT '=' expression
			{
			DebugLocation(15, 4);
			Match(input,IDENT,Follow._IDENT_in_assign_stmt58); 
			DebugLocation(15, 10);
			Match(input,17,Follow._17_in_assign_stmt60); 
			DebugLocation(15, 14);
			PushFollow(Follow._expression_in_assign_stmt62);
			expression();
			PopFollow();


			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("assign_stmt", 3);
			LeaveRule("assign_stmt", 3);
			LeaveRule_assign_stmt();
		}
		DebugLocation(16, 1);
		} finally { DebugExitRule(GrammarFileName, "assign_stmt"); }
		return;

	}
	// $ANTLR end "assign_stmt"

	partial void EnterRule_print_stmt();
	partial void LeaveRule_print_stmt();
	// $ANTLR start "print_stmt"
	// Simple.g:18:1: print_stmt : 'print' expression ( ',' expression )* ;
	[GrammarRule("print_stmt")]
	private void print_stmt()
	{
		EnterRule_print_stmt();
		EnterRule("print_stmt", 4);
		TraceIn("print_stmt", 4);
		try { DebugEnterRule(GrammarFileName, "print_stmt");
		DebugLocation(18, 40);
		try
		{
			// Simple.g:19:2: ( 'print' expression ( ',' expression )* )
			DebugEnterAlt(1);
			// Simple.g:19:4: 'print' expression ( ',' expression )*
			{
			DebugLocation(19, 4);
			Match(input,19,Follow._19_in_print_stmt73); 
			DebugLocation(19, 12);
			PushFollow(Follow._expression_in_print_stmt75);
			expression();
			PopFollow();

			DebugLocation(19, 23);
			// Simple.g:19:23: ( ',' expression )*
			try { DebugEnterSubRule(3);
			while (true)
			{
				int alt3=2;
				try { DebugEnterDecision(3, false);
				int LA3_1 = input.LA(1);

				if ((LA3_1==13))
				{
					alt3 = 1;
				}


				} finally { DebugExitDecision(3); }
				switch ( alt3 )
				{
				case 1:
					DebugEnterAlt(1);
					// Simple.g:19:24: ',' expression
					{
					DebugLocation(19, 24);
					Match(input,13,Follow._13_in_print_stmt78); 
					DebugLocation(19, 28);
					PushFollow(Follow._expression_in_print_stmt80);
					expression();
					PopFollow();


					}
					break;

				default:
					goto loop3;
				}
			}

			loop3:
				;

			} finally { DebugExitSubRule(3); }


			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("print_stmt", 4);
			LeaveRule("print_stmt", 4);
			LeaveRule_print_stmt();
		}
		DebugLocation(19, 40);
		} finally { DebugExitRule(GrammarFileName, "print_stmt"); }
		return;

	}
	// $ANTLR end "print_stmt"

	partial void EnterRule_expression();
	partial void LeaveRule_expression();
	// $ANTLR start "expression"
	// Simple.g:21:1: expression : mult ( ( '+' | '-' ) mult )* ;
	[GrammarRule("expression")]
	private void expression()
	{
		EnterRule_expression();
		EnterRule("expression", 5);
		TraceIn("expression", 5);
		try { DebugEnterRule(GrammarFileName, "expression");
		DebugLocation(21, 1);
		try
		{
			// Simple.g:22:2: ( mult ( ( '+' | '-' ) mult )* )
			DebugEnterAlt(1);
			// Simple.g:22:4: mult ( ( '+' | '-' ) mult )*
			{
			DebugLocation(22, 4);
			PushFollow(Follow._mult_in_expression92);
			mult();
			PopFollow();

			DebugLocation(22, 9);
			// Simple.g:22:9: ( ( '+' | '-' ) mult )*
			try { DebugEnterSubRule(4);
			while (true)
			{
				int alt4=2;
				try { DebugEnterDecision(4, false);
				int LA4_1 = input.LA(1);

				if ((LA4_1==12||LA4_1==14))
				{
					alt4 = 1;
				}


				} finally { DebugExitDecision(4); }
				switch ( alt4 )
				{
				case 1:
					DebugEnterAlt(1);
					// Simple.g:22:11: ( '+' | '-' ) mult
					{
					DebugLocation(22, 11);
					if (input.LA(1)==12||input.LA(1)==14)
					{
						input.Consume();
						state.errorRecovery=false;
					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(22, 23);
					PushFollow(Follow._mult_in_expression104);
					mult();
					PopFollow();


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

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("expression", 5);
			LeaveRule("expression", 5);
			LeaveRule_expression();
		}
		DebugLocation(23, 1);
		} finally { DebugExitRule(GrammarFileName, "expression"); }
		return;

	}
	// $ANTLR end "expression"

	partial void EnterRule_mult();
	partial void LeaveRule_mult();
	// $ANTLR start "mult"
	// Simple.g:25:1: mult : atom ( ( '*' | '/' ) atom )* ;
	[GrammarRule("mult")]
	private void mult()
	{
		EnterRule_mult();
		EnterRule("mult", 6);
		TraceIn("mult", 6);
		try { DebugEnterRule(GrammarFileName, "mult");
		DebugLocation(25, 1);
		try
		{
			// Simple.g:26:2: ( atom ( ( '*' | '/' ) atom )* )
			DebugEnterAlt(1);
			// Simple.g:26:4: atom ( ( '*' | '/' ) atom )*
			{
			DebugLocation(26, 4);
			PushFollow(Follow._atom_in_mult118);
			atom();
			PopFollow();

			DebugLocation(26, 9);
			// Simple.g:26:9: ( ( '*' | '/' ) atom )*
			try { DebugEnterSubRule(5);
			while (true)
			{
				int alt5=2;
				try { DebugEnterDecision(5, false);
				int LA5_1 = input.LA(1);

				if ((LA5_1==11||LA5_1==15))
				{
					alt5 = 1;
				}


				} finally { DebugExitDecision(5); }
				switch ( alt5 )
				{
				case 1:
					DebugEnterAlt(1);
					// Simple.g:26:10: ( '*' | '/' ) atom
					{
					DebugLocation(26, 10);
					if (input.LA(1)==11||input.LA(1)==15)
					{
						input.Consume();
						state.errorRecovery=false;
					}
					else
					{
						MismatchedSetException mse = new MismatchedSetException(null,input);
						DebugRecognitionException(mse);
						throw mse;
					}

					DebugLocation(26, 23);
					PushFollow(Follow._atom_in_mult130);
					atom();
					PopFollow();


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

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("mult", 6);
			LeaveRule("mult", 6);
			LeaveRule_mult();
		}
		DebugLocation(27, 1);
		} finally { DebugExitRule(GrammarFileName, "mult"); }
		return;

	}
	// $ANTLR end "mult"

	partial void EnterRule_atom();
	partial void LeaveRule_atom();
	// $ANTLR start "atom"
	// Simple.g:29:1: atom : ( IDENT | NUMBER | '(' expression ')' );
	[GrammarRule("atom")]
	private void atom()
	{
		EnterRule_atom();
		EnterRule("atom", 7);
		TraceIn("atom", 7);
		try { DebugEnterRule(GrammarFileName, "atom");
		DebugLocation(29, 1);
		try
		{
			// Simple.g:30:2: ( IDENT | NUMBER | '(' expression ')' )
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
			case 9:
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
				// Simple.g:30:4: IDENT
				{
				DebugLocation(30, 4);
				Match(input,IDENT,Follow._IDENT_in_atom144); 

				}
				break;
			case 2:
				DebugEnterAlt(2);
				// Simple.g:31:5: NUMBER
				{
				DebugLocation(31, 5);
				Match(input,NUMBER,Follow._NUMBER_in_atom151); 

				}
				break;
			case 3:
				DebugEnterAlt(3);
				// Simple.g:32:5: '(' expression ')'
				{
				DebugLocation(32, 5);
				Match(input,9,Follow._9_in_atom158); 
				DebugLocation(32, 9);
				PushFollow(Follow._expression_in_atom160);
				expression();
				PopFollow();

				DebugLocation(32, 20);
				Match(input,10,Follow._10_in_atom162); 

				}
				break;

			}
		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("atom", 7);
			LeaveRule("atom", 7);
			LeaveRule_atom();
		}
		DebugLocation(33, 1);
		} finally { DebugExitRule(GrammarFileName, "atom"); }
		return;

	}
	// $ANTLR end "atom"

	partial void EnterRule_input_stmt();
	partial void LeaveRule_input_stmt();
	// $ANTLR start "input_stmt"
	// Simple.g:35:1: input_stmt : 'input' IDENT ;
	[GrammarRule("input_stmt")]
	private void input_stmt()
	{
		EnterRule_input_stmt();
		EnterRule("input_stmt", 8);
		TraceIn("input_stmt", 8);
		try { DebugEnterRule(GrammarFileName, "input_stmt");
		DebugLocation(35, 1);
		try
		{
			// Simple.g:36:2: ( 'input' IDENT )
			DebugEnterAlt(1);
			// Simple.g:36:4: 'input' IDENT
			{
			DebugLocation(36, 4);
			Match(input,18,Follow._18_in_input_stmt173); 
			DebugLocation(36, 12);
			Match(input,IDENT,Follow._IDENT_in_input_stmt175); 

			}

		}
		catch (RecognitionException re)
		{
			ReportError(re);
			Recover(input,re);
		}
		finally
		{
			TraceOut("input_stmt", 8);
			LeaveRule("input_stmt", 8);
			LeaveRule_input_stmt();
		}
		DebugLocation(37, 1);
		} finally { DebugExitRule(GrammarFileName, "input_stmt"); }
		return;

	}
	// $ANTLR end "input_stmt"
	#endregion Rules


	#region Follow sets
	private static class Follow
	{
		public static readonly BitSet _stmt_in_program15 = new BitSet(new ulong[]{0x10000UL});
		public static readonly BitSet _16_in_program17 = new BitSet(new ulong[]{0xC0022UL});
		public static readonly BitSet _input_stmt_in_stmt33 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _print_stmt_in_stmt40 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _assign_stmt_in_stmt47 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _IDENT_in_assign_stmt58 = new BitSet(new ulong[]{0x20000UL});
		public static readonly BitSet _17_in_assign_stmt60 = new BitSet(new ulong[]{0x2A0UL});
		public static readonly BitSet _expression_in_assign_stmt62 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _19_in_print_stmt73 = new BitSet(new ulong[]{0x2A0UL});
		public static readonly BitSet _expression_in_print_stmt75 = new BitSet(new ulong[]{0x2002UL});
		public static readonly BitSet _13_in_print_stmt78 = new BitSet(new ulong[]{0x2A0UL});
		public static readonly BitSet _expression_in_print_stmt80 = new BitSet(new ulong[]{0x2002UL});
		public static readonly BitSet _mult_in_expression92 = new BitSet(new ulong[]{0x5002UL});
		public static readonly BitSet _set_in_expression96 = new BitSet(new ulong[]{0x2A0UL});
		public static readonly BitSet _mult_in_expression104 = new BitSet(new ulong[]{0x5002UL});
		public static readonly BitSet _atom_in_mult118 = new BitSet(new ulong[]{0x8802UL});
		public static readonly BitSet _set_in_mult121 = new BitSet(new ulong[]{0x2A0UL});
		public static readonly BitSet _atom_in_mult130 = new BitSet(new ulong[]{0x8802UL});
		public static readonly BitSet _IDENT_in_atom144 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _NUMBER_in_atom151 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _9_in_atom158 = new BitSet(new ulong[]{0x2A0UL});
		public static readonly BitSet _expression_in_atom160 = new BitSet(new ulong[]{0x400UL});
		public static readonly BitSet _10_in_atom162 = new BitSet(new ulong[]{0x2UL});
		public static readonly BitSet _18_in_input_stmt173 = new BitSet(new ulong[]{0x20UL});
		public static readonly BitSet _IDENT_in_input_stmt175 = new BitSet(new ulong[]{0x2UL});
	}
	#endregion Follow sets
}
