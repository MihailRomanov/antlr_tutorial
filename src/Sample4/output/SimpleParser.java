// $ANTLR 3.4 D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g 2012-03-24 13:28:57

import org.antlr.runtime.*;
import java.util.Stack;
import java.util.List;
import java.util.ArrayList;

import org.antlr.runtime.tree.*;


@SuppressWarnings({"all", "warnings", "unchecked"})
public class SimpleParser extends Parser {
    public static final String[] tokenNames = new String[] {
        "<invalid>", "<EOR>", "<DOWN>", "<UP>", "DIGIT", "DIV", "IDENT", "LETTER", "MINUS", "MUL", "NUMBER", "PLUS", "PROGRAM", "STMT_ASSIGN", "STMT_INPUT", "STMT_PRINT", "WS", "'('", "')'", "','", "';'", "'='", "'input'", "'print'"
    };

    public static final int EOF=-1;
    public static final int T__17=17;
    public static final int T__18=18;
    public static final int T__19=19;
    public static final int T__20=20;
    public static final int T__21=21;
    public static final int T__22=22;
    public static final int T__23=23;
    public static final int DIGIT=4;
    public static final int DIV=5;
    public static final int IDENT=6;
    public static final int LETTER=7;
    public static final int MINUS=8;
    public static final int MUL=9;
    public static final int NUMBER=10;
    public static final int PLUS=11;
    public static final int PROGRAM=12;
    public static final int STMT_ASSIGN=13;
    public static final int STMT_INPUT=14;
    public static final int STMT_PRINT=15;
    public static final int WS=16;

    // delegates
    public Parser[] getDelegates() {
        return new Parser[] {};
    }

    // delegators


    public SimpleParser(TokenStream input) {
        this(input, new RecognizerSharedState());
    }
    public SimpleParser(TokenStream input, RecognizerSharedState state) {
        super(input, state);
    }

protected TreeAdaptor adaptor = new CommonTreeAdaptor();

public void setTreeAdaptor(TreeAdaptor adaptor) {
    this.adaptor = adaptor;
}
public TreeAdaptor getTreeAdaptor() {
    return adaptor;
}
    public String[] getTokenNames() { return SimpleParser.tokenNames; }
    public String getGrammarFileName() { return "D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g"; }


    public static class program_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };


    // $ANTLR start "program"
    // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:21:1: public program : ( stmt ';' )+ -> ^( PROGRAM ( stmt )+ ) ;
    public final SimpleParser.program_return program() throws RecognitionException {
        SimpleParser.program_return retval = new SimpleParser.program_return();
        retval.start = input.LT(1);


        Object root_0 = null;

        Token char_literal2=null;
        SimpleParser.stmt_return stmt1 =null;


        Object char_literal2_tree=null;
        RewriteRuleTokenStream stream_20=new RewriteRuleTokenStream(adaptor,"token 20");
        RewriteRuleSubtreeStream stream_stmt=new RewriteRuleSubtreeStream(adaptor,"rule stmt");
        try {
            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:22:2: ( ( stmt ';' )+ -> ^( PROGRAM ( stmt )+ ) )
            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:22:4: ( stmt ';' )+
            {
            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:22:4: ( stmt ';' )+
            int cnt1=0;
            loop1:
            do {
                int alt1=2;
                int LA1_0 = input.LA(1);

                if ( (LA1_0==IDENT||(LA1_0 >= 22 && LA1_0 <= 23)) ) {
                    alt1=1;
                }


                switch (alt1) {
            	case 1 :
            	    // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:22:5: stmt ';'
            	    {
            	    pushFollow(FOLLOW_stmt_in_program82);
            	    stmt1=stmt();

            	    state._fsp--;

            	    stream_stmt.add(stmt1.getTree());

            	    char_literal2=(Token)match(input,20,FOLLOW_20_in_program84);  
            	    stream_20.add(char_literal2);


            	    }
            	    break;

            	default :
            	    if ( cnt1 >= 1 ) break loop1;
                        EarlyExitException eee =
                            new EarlyExitException(1, input);
                        throw eee;
                }
                cnt1++;
            } while (true);


            // AST REWRITE
            // elements: stmt
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 22:17: -> ^( PROGRAM ( stmt )+ )
            {
                // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:22:20: ^( PROGRAM ( stmt )+ )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot(
                (Object)adaptor.create(PROGRAM, "PROGRAM")
                , root_1);

                if ( !(stream_stmt.hasNext()) ) {
                    throw new RewriteEarlyExitException();
                }
                while ( stream_stmt.hasNext() ) {
                    adaptor.addChild(root_1, stream_stmt.nextTree());

                }
                stream_stmt.reset();

                adaptor.addChild(root_0, root_1);
                }

            }


            retval.tree = root_0;

            }

            retval.stop = input.LT(-1);


            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }

        finally {
        	// do for sure before leaving
        }
        return retval;
    }
    // $ANTLR end "program"


    public static class stmt_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };


    // $ANTLR start "stmt"
    // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:25:1: stmt : ( input_stmt | print_stmt | assign_stmt );
    public final SimpleParser.stmt_return stmt() throws RecognitionException {
        SimpleParser.stmt_return retval = new SimpleParser.stmt_return();
        retval.start = input.LT(1);


        Object root_0 = null;

        SimpleParser.input_stmt_return input_stmt3 =null;

        SimpleParser.print_stmt_return print_stmt4 =null;

        SimpleParser.assign_stmt_return assign_stmt5 =null;



        try {
            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:26:2: ( input_stmt | print_stmt | assign_stmt )
            int alt2=3;
            switch ( input.LA(1) ) {
            case 22:
                {
                alt2=1;
                }
                break;
            case 23:
                {
                alt2=2;
                }
                break;
            case IDENT:
                {
                alt2=3;
                }
                break;
            default:
                NoViableAltException nvae =
                    new NoViableAltException("", 2, 0, input);

                throw nvae;

            }

            switch (alt2) {
                case 1 :
                    // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:26:4: input_stmt
                    {
                    root_0 = (Object)adaptor.nil();


                    pushFollow(FOLLOW_input_stmt_in_stmt111);
                    input_stmt3=input_stmt();

                    state._fsp--;

                    adaptor.addChild(root_0, input_stmt3.getTree());

                    }
                    break;
                case 2 :
                    // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:27:5: print_stmt
                    {
                    root_0 = (Object)adaptor.nil();


                    pushFollow(FOLLOW_print_stmt_in_stmt118);
                    print_stmt4=print_stmt();

                    state._fsp--;

                    adaptor.addChild(root_0, print_stmt4.getTree());

                    }
                    break;
                case 3 :
                    // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:28:5: assign_stmt
                    {
                    root_0 = (Object)adaptor.nil();


                    pushFollow(FOLLOW_assign_stmt_in_stmt125);
                    assign_stmt5=assign_stmt();

                    state._fsp--;

                    adaptor.addChild(root_0, assign_stmt5.getTree());

                    }
                    break;

            }
            retval.stop = input.LT(-1);


            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }

        finally {
        	// do for sure before leaving
        }
        return retval;
    }
    // $ANTLR end "stmt"


    public static class assign_stmt_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };


    // $ANTLR start "assign_stmt"
    // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:31:1: assign_stmt : IDENT '=' expression -> ^( STMT_ASSIGN IDENT expression ) ;
    public final SimpleParser.assign_stmt_return assign_stmt() throws RecognitionException {
        SimpleParser.assign_stmt_return retval = new SimpleParser.assign_stmt_return();
        retval.start = input.LT(1);


        Object root_0 = null;

        Token IDENT6=null;
        Token char_literal7=null;
        SimpleParser.expression_return expression8 =null;


        Object IDENT6_tree=null;
        Object char_literal7_tree=null;
        RewriteRuleTokenStream stream_21=new RewriteRuleTokenStream(adaptor,"token 21");
        RewriteRuleTokenStream stream_IDENT=new RewriteRuleTokenStream(adaptor,"token IDENT");
        RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
        try {
            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:32:2: ( IDENT '=' expression -> ^( STMT_ASSIGN IDENT expression ) )
            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:32:4: IDENT '=' expression
            {
            IDENT6=(Token)match(input,IDENT,FOLLOW_IDENT_in_assign_stmt136);  
            stream_IDENT.add(IDENT6);


            char_literal7=(Token)match(input,21,FOLLOW_21_in_assign_stmt138);  
            stream_21.add(char_literal7);


            pushFollow(FOLLOW_expression_in_assign_stmt140);
            expression8=expression();

            state._fsp--;

            stream_expression.add(expression8.getTree());

            // AST REWRITE
            // elements: expression, IDENT
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 32:25: -> ^( STMT_ASSIGN IDENT expression )
            {
                // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:32:28: ^( STMT_ASSIGN IDENT expression )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot(
                (Object)adaptor.create(STMT_ASSIGN, "STMT_ASSIGN")
                , root_1);

                adaptor.addChild(root_1, 
                stream_IDENT.nextNode()
                );

                adaptor.addChild(root_1, stream_expression.nextTree());

                adaptor.addChild(root_0, root_1);
                }

            }


            retval.tree = root_0;

            }

            retval.stop = input.LT(-1);


            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }

        finally {
        	// do for sure before leaving
        }
        return retval;
    }
    // $ANTLR end "assign_stmt"


    public static class input_stmt_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };


    // $ANTLR start "input_stmt"
    // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:35:1: input_stmt : 'input' IDENT -> ^( STMT_INPUT IDENT ) ;
    public final SimpleParser.input_stmt_return input_stmt() throws RecognitionException {
        SimpleParser.input_stmt_return retval = new SimpleParser.input_stmt_return();
        retval.start = input.LT(1);


        Object root_0 = null;

        Token string_literal9=null;
        Token IDENT10=null;

        Object string_literal9_tree=null;
        Object IDENT10_tree=null;
        RewriteRuleTokenStream stream_IDENT=new RewriteRuleTokenStream(adaptor,"token IDENT");
        RewriteRuleTokenStream stream_22=new RewriteRuleTokenStream(adaptor,"token 22");

        try {
            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:36:2: ( 'input' IDENT -> ^( STMT_INPUT IDENT ) )
            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:36:4: 'input' IDENT
            {
            string_literal9=(Token)match(input,22,FOLLOW_22_in_input_stmt161);  
            stream_22.add(string_literal9);


            IDENT10=(Token)match(input,IDENT,FOLLOW_IDENT_in_input_stmt163);  
            stream_IDENT.add(IDENT10);


            // AST REWRITE
            // elements: IDENT
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 36:18: -> ^( STMT_INPUT IDENT )
            {
                // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:36:21: ^( STMT_INPUT IDENT )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot(
                (Object)adaptor.create(STMT_INPUT, "STMT_INPUT")
                , root_1);

                adaptor.addChild(root_1, 
                stream_IDENT.nextNode()
                );

                adaptor.addChild(root_0, root_1);
                }

            }


            retval.tree = root_0;

            }

            retval.stop = input.LT(-1);


            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }

        finally {
        	// do for sure before leaving
        }
        return retval;
    }
    // $ANTLR end "input_stmt"


    public static class print_stmt_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };


    // $ANTLR start "print_stmt"
    // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:39:1: print_stmt : 'print' expression ( ',' expression )* -> ^( STMT_PRINT ( expression )* ) ;
    public final SimpleParser.print_stmt_return print_stmt() throws RecognitionException {
        SimpleParser.print_stmt_return retval = new SimpleParser.print_stmt_return();
        retval.start = input.LT(1);


        Object root_0 = null;

        Token string_literal11=null;
        Token char_literal13=null;
        SimpleParser.expression_return expression12 =null;

        SimpleParser.expression_return expression14 =null;


        Object string_literal11_tree=null;
        Object char_literal13_tree=null;
        RewriteRuleTokenStream stream_19=new RewriteRuleTokenStream(adaptor,"token 19");
        RewriteRuleTokenStream stream_23=new RewriteRuleTokenStream(adaptor,"token 23");
        RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
        try {
            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:40:2: ( 'print' expression ( ',' expression )* -> ^( STMT_PRINT ( expression )* ) )
            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:40:4: 'print' expression ( ',' expression )*
            {
            string_literal11=(Token)match(input,23,FOLLOW_23_in_print_stmt182);  
            stream_23.add(string_literal11);


            pushFollow(FOLLOW_expression_in_print_stmt184);
            expression12=expression();

            state._fsp--;

            stream_expression.add(expression12.getTree());

            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:40:23: ( ',' expression )*
            loop3:
            do {
                int alt3=2;
                int LA3_0 = input.LA(1);

                if ( (LA3_0==19) ) {
                    alt3=1;
                }


                switch (alt3) {
            	case 1 :
            	    // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:40:24: ',' expression
            	    {
            	    char_literal13=(Token)match(input,19,FOLLOW_19_in_print_stmt187);  
            	    stream_19.add(char_literal13);


            	    pushFollow(FOLLOW_expression_in_print_stmt189);
            	    expression14=expression();

            	    state._fsp--;

            	    stream_expression.add(expression14.getTree());

            	    }
            	    break;

            	default :
            	    break loop3;
                }
            } while (true);


            // AST REWRITE
            // elements: expression
            // token labels: 
            // rule labels: retval
            // token list labels: 
            // rule list labels: 
            // wildcard labels: 
            retval.tree = root_0;
            RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

            root_0 = (Object)adaptor.nil();
            // 40:42: -> ^( STMT_PRINT ( expression )* )
            {
                // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:40:45: ^( STMT_PRINT ( expression )* )
                {
                Object root_1 = (Object)adaptor.nil();
                root_1 = (Object)adaptor.becomeRoot(
                (Object)adaptor.create(STMT_PRINT, "STMT_PRINT")
                , root_1);

                // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:40:58: ( expression )*
                while ( stream_expression.hasNext() ) {
                    adaptor.addChild(root_1, stream_expression.nextTree());

                }
                stream_expression.reset();

                adaptor.addChild(root_0, root_1);
                }

            }


            retval.tree = root_0;

            }

            retval.stop = input.LT(-1);


            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }

        finally {
        	// do for sure before leaving
        }
        return retval;
    }
    // $ANTLR end "print_stmt"


    public static class expression_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };


    // $ANTLR start "expression"
    // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:43:1: expression : mult ( ( PLUS | MINUS ) ^ mult )* ;
    public final SimpleParser.expression_return expression() throws RecognitionException {
        SimpleParser.expression_return retval = new SimpleParser.expression_return();
        retval.start = input.LT(1);


        Object root_0 = null;

        Token set16=null;
        SimpleParser.mult_return mult15 =null;

        SimpleParser.mult_return mult17 =null;


        Object set16_tree=null;

        try {
            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:44:2: ( mult ( ( PLUS | MINUS ) ^ mult )* )
            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:44:4: mult ( ( PLUS | MINUS ) ^ mult )*
            {
            root_0 = (Object)adaptor.nil();


            pushFollow(FOLLOW_mult_in_expression213);
            mult15=mult();

            state._fsp--;

            adaptor.addChild(root_0, mult15.getTree());

            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:44:9: ( ( PLUS | MINUS ) ^ mult )*
            loop4:
            do {
                int alt4=2;
                int LA4_0 = input.LA(1);

                if ( (LA4_0==MINUS||LA4_0==PLUS) ) {
                    alt4=1;
                }


                switch (alt4) {
            	case 1 :
            	    // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:44:11: ( PLUS | MINUS ) ^ mult
            	    {
            	    set16=(Token)input.LT(1);

            	    set16=(Token)input.LT(1);

            	    if ( input.LA(1)==MINUS||input.LA(1)==PLUS ) {
            	        input.consume();
            	        root_0 = (Object)adaptor.becomeRoot(
            	        (Object)adaptor.create(set16)
            	        , root_0);
            	        state.errorRecovery=false;
            	    }
            	    else {
            	        MismatchedSetException mse = new MismatchedSetException(null,input);
            	        throw mse;
            	    }


            	    pushFollow(FOLLOW_mult_in_expression227);
            	    mult17=mult();

            	    state._fsp--;

            	    adaptor.addChild(root_0, mult17.getTree());

            	    }
            	    break;

            	default :
            	    break loop4;
                }
            } while (true);


            }

            retval.stop = input.LT(-1);


            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }

        finally {
        	// do for sure before leaving
        }
        return retval;
    }
    // $ANTLR end "expression"


    public static class mult_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };


    // $ANTLR start "mult"
    // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:47:1: mult : atom ( ( MUL | DIV ) ^ atom )* ;
    public final SimpleParser.mult_return mult() throws RecognitionException {
        SimpleParser.mult_return retval = new SimpleParser.mult_return();
        retval.start = input.LT(1);


        Object root_0 = null;

        Token set19=null;
        SimpleParser.atom_return atom18 =null;

        SimpleParser.atom_return atom20 =null;


        Object set19_tree=null;

        try {
            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:48:2: ( atom ( ( MUL | DIV ) ^ atom )* )
            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:48:4: atom ( ( MUL | DIV ) ^ atom )*
            {
            root_0 = (Object)adaptor.nil();


            pushFollow(FOLLOW_atom_in_mult241);
            atom18=atom();

            state._fsp--;

            adaptor.addChild(root_0, atom18.getTree());

            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:48:9: ( ( MUL | DIV ) ^ atom )*
            loop5:
            do {
                int alt5=2;
                int LA5_0 = input.LA(1);

                if ( (LA5_0==DIV||LA5_0==MUL) ) {
                    alt5=1;
                }


                switch (alt5) {
            	case 1 :
            	    // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:48:10: ( MUL | DIV ) ^ atom
            	    {
            	    set19=(Token)input.LT(1);

            	    set19=(Token)input.LT(1);

            	    if ( input.LA(1)==DIV||input.LA(1)==MUL ) {
            	        input.consume();
            	        root_0 = (Object)adaptor.becomeRoot(
            	        (Object)adaptor.create(set19)
            	        , root_0);
            	        state.errorRecovery=false;
            	    }
            	    else {
            	        MismatchedSetException mse = new MismatchedSetException(null,input);
            	        throw mse;
            	    }


            	    pushFollow(FOLLOW_atom_in_mult254);
            	    atom20=atom();

            	    state._fsp--;

            	    adaptor.addChild(root_0, atom20.getTree());

            	    }
            	    break;

            	default :
            	    break loop5;
                }
            } while (true);


            }

            retval.stop = input.LT(-1);


            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }

        finally {
        	// do for sure before leaving
        }
        return retval;
    }
    // $ANTLR end "mult"


    public static class atom_return extends ParserRuleReturnScope {
        Object tree;
        public Object getTree() { return tree; }
    };


    // $ANTLR start "atom"
    // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:51:1: atom : ( IDENT | NUMBER | '(' expression ')' -> expression );
    public final SimpleParser.atom_return atom() throws RecognitionException {
        SimpleParser.atom_return retval = new SimpleParser.atom_return();
        retval.start = input.LT(1);


        Object root_0 = null;

        Token IDENT21=null;
        Token NUMBER22=null;
        Token char_literal23=null;
        Token char_literal25=null;
        SimpleParser.expression_return expression24 =null;


        Object IDENT21_tree=null;
        Object NUMBER22_tree=null;
        Object char_literal23_tree=null;
        Object char_literal25_tree=null;
        RewriteRuleTokenStream stream_17=new RewriteRuleTokenStream(adaptor,"token 17");
        RewriteRuleTokenStream stream_18=new RewriteRuleTokenStream(adaptor,"token 18");
        RewriteRuleSubtreeStream stream_expression=new RewriteRuleSubtreeStream(adaptor,"rule expression");
        try {
            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:52:2: ( IDENT | NUMBER | '(' expression ')' -> expression )
            int alt6=3;
            switch ( input.LA(1) ) {
            case IDENT:
                {
                alt6=1;
                }
                break;
            case NUMBER:
                {
                alt6=2;
                }
                break;
            case 17:
                {
                alt6=3;
                }
                break;
            default:
                NoViableAltException nvae =
                    new NoViableAltException("", 6, 0, input);

                throw nvae;

            }

            switch (alt6) {
                case 1 :
                    // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:52:4: IDENT
                    {
                    root_0 = (Object)adaptor.nil();


                    IDENT21=(Token)match(input,IDENT,FOLLOW_IDENT_in_atom268); 
                    IDENT21_tree = 
                    (Object)adaptor.create(IDENT21)
                    ;
                    adaptor.addChild(root_0, IDENT21_tree);


                    }
                    break;
                case 2 :
                    // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:53:5: NUMBER
                    {
                    root_0 = (Object)adaptor.nil();


                    NUMBER22=(Token)match(input,NUMBER,FOLLOW_NUMBER_in_atom275); 
                    NUMBER22_tree = 
                    (Object)adaptor.create(NUMBER22)
                    ;
                    adaptor.addChild(root_0, NUMBER22_tree);


                    }
                    break;
                case 3 :
                    // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:54:5: '(' expression ')'
                    {
                    char_literal23=(Token)match(input,17,FOLLOW_17_in_atom282);  
                    stream_17.add(char_literal23);


                    pushFollow(FOLLOW_expression_in_atom284);
                    expression24=expression();

                    state._fsp--;

                    stream_expression.add(expression24.getTree());

                    char_literal25=(Token)match(input,18,FOLLOW_18_in_atom286);  
                    stream_18.add(char_literal25);


                    // AST REWRITE
                    // elements: expression
                    // token labels: 
                    // rule labels: retval
                    // token list labels: 
                    // rule list labels: 
                    // wildcard labels: 
                    retval.tree = root_0;
                    RewriteRuleSubtreeStream stream_retval=new RewriteRuleSubtreeStream(adaptor,"rule retval",retval!=null?retval.tree:null);

                    root_0 = (Object)adaptor.nil();
                    // 54:24: -> expression
                    {
                        adaptor.addChild(root_0, stream_expression.nextTree());

                    }


                    retval.tree = root_0;

                    }
                    break;

            }
            retval.stop = input.LT(-1);


            retval.tree = (Object)adaptor.rulePostProcessing(root_0);
            adaptor.setTokenBoundaries(retval.tree, retval.start, retval.stop);

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
    	retval.tree = (Object)adaptor.errorNode(input, retval.start, input.LT(-1), re);

        }

        finally {
        	// do for sure before leaving
        }
        return retval;
    }
    // $ANTLR end "atom"

    // Delegated rules


 

    public static final BitSet FOLLOW_stmt_in_program82 = new BitSet(new long[]{0x0000000000100000L});
    public static final BitSet FOLLOW_20_in_program84 = new BitSet(new long[]{0x0000000000C00042L});
    public static final BitSet FOLLOW_input_stmt_in_stmt111 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_print_stmt_in_stmt118 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_assign_stmt_in_stmt125 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_IDENT_in_assign_stmt136 = new BitSet(new long[]{0x0000000000200000L});
    public static final BitSet FOLLOW_21_in_assign_stmt138 = new BitSet(new long[]{0x0000000000020440L});
    public static final BitSet FOLLOW_expression_in_assign_stmt140 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_22_in_input_stmt161 = new BitSet(new long[]{0x0000000000000040L});
    public static final BitSet FOLLOW_IDENT_in_input_stmt163 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_23_in_print_stmt182 = new BitSet(new long[]{0x0000000000020440L});
    public static final BitSet FOLLOW_expression_in_print_stmt184 = new BitSet(new long[]{0x0000000000080002L});
    public static final BitSet FOLLOW_19_in_print_stmt187 = new BitSet(new long[]{0x0000000000020440L});
    public static final BitSet FOLLOW_expression_in_print_stmt189 = new BitSet(new long[]{0x0000000000080002L});
    public static final BitSet FOLLOW_mult_in_expression213 = new BitSet(new long[]{0x0000000000000902L});
    public static final BitSet FOLLOW_set_in_expression217 = new BitSet(new long[]{0x0000000000020440L});
    public static final BitSet FOLLOW_mult_in_expression227 = new BitSet(new long[]{0x0000000000000902L});
    public static final BitSet FOLLOW_atom_in_mult241 = new BitSet(new long[]{0x0000000000000222L});
    public static final BitSet FOLLOW_set_in_mult244 = new BitSet(new long[]{0x0000000000020440L});
    public static final BitSet FOLLOW_atom_in_mult254 = new BitSet(new long[]{0x0000000000000222L});
    public static final BitSet FOLLOW_IDENT_in_atom268 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_NUMBER_in_atom275 = new BitSet(new long[]{0x0000000000000002L});
    public static final BitSet FOLLOW_17_in_atom282 = new BitSet(new long[]{0x0000000000020440L});
    public static final BitSet FOLLOW_expression_in_atom284 = new BitSet(new long[]{0x0000000000040000L});
    public static final BitSet FOLLOW_18_in_atom286 = new BitSet(new long[]{0x0000000000000002L});

}