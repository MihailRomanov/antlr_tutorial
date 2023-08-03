// $ANTLR 3.4 D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Out.g 2012-03-24 13:31:42

import org.antlr.runtime.*;
import org.antlr.runtime.tree.*;
import java.util.Stack;
import java.util.List;
import java.util.ArrayList;

import org.antlr.runtime.debug.*;
import java.io.IOException;
import org.antlr.stringtemplate.*;
import org.antlr.stringtemplate.language.*;
import java.util.HashMap;
@SuppressWarnings({"all", "warnings", "unchecked"})
public class Out extends DebugTreeParser {
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
    public TreeParser[] getDelegates() {
        return new TreeParser[] {};
    }

    // delegators


public static final String[] ruleNames = new String[] {
    "invalidRule", "program", "stmt"
};

public static final boolean[] decisionCanBacktrack = new boolean[] {
    false, // invalid decision
    false
};

 
    public int ruleLevel = 0;
    public int getRuleLevel() { return ruleLevel; }
    public void incRuleLevel() { ruleLevel++; }
    public void decRuleLevel() { ruleLevel--; }
    public Out(TreeNodeStream input) {
        this(input, DebugEventSocketProxy.DEFAULT_DEBUGGER_PORT, new RecognizerSharedState());
    }
    public Out(TreeNodeStream input, int port, RecognizerSharedState state) {
        super(input, state);
        DebugEventSocketProxy proxy =
            new DebugEventSocketProxy(this, port, input.getTreeAdaptor());

        setDebugListener(proxy);
        try {
            proxy.handshake();
        }
        catch (IOException ioe) {
            reportError(ioe);
        }
    }

public Out(TreeNodeStream input, DebugEventListener dbg) {
    super(input, dbg, new RecognizerSharedState());
}

protected boolean evalPredicate(boolean result, String predicate) {
    dbg.semanticPredicate(result, predicate);
    return result;
}

protected StringTemplateGroup templateLib =
  new StringTemplateGroup("OutTemplates", AngleBracketTemplateLexer.class);

public void setTemplateLib(StringTemplateGroup templateLib) {
  this.templateLib = templateLib;
}
public StringTemplateGroup getTemplateLib() {
  return templateLib;
}
/** allows convenient multi-value initialization:
 *  "new STAttrMap().put(...).put(...)"
 */
public static class STAttrMap extends HashMap {
  public STAttrMap put(String attrName, Object value) {
    super.put(attrName, value);
    return this;
  }
  public STAttrMap put(String attrName, int value) {
    super.put(attrName, new Integer(value));
    return this;
  }
}
    public String[] getTokenNames() { return Out.tokenNames; }
    public String getGrammarFileName() { return "D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Out.g"; }


    public static class program_return extends TreeRuleReturnScope {
        public StringTemplate st;
        public Object getTemplate() { return st; }
        public String toString() { return st==null?null:st.toString(); }
    };


    // $ANTLR start "program"
    // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Out.g:10:1: public program : ^( PROGRAM (t+= stmt )+ ) -> template(st=$t) \"Program <st; separator='\\n'>\";
    public final Out.program_return program() throws RecognitionException {
        Out.program_return retval = new Out.program_return();
        retval.start = input.LT(1);


        List list_t=null;
        RuleReturnScope t = null;
        try { dbg.enterRule(getGrammarFileName(), "program");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(10, 0);

        try {
            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Out.g:10:9: ( ^( PROGRAM (t+= stmt )+ ) -> template(st=$t) \"Program <st; separator='\\n'>\")
            dbg.enterAlt(1);

            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Out.g:10:12: ^( PROGRAM (t+= stmt )+ )
            {
            dbg.location(10,12);
            dbg.location(10,14);
            match(input,PROGRAM,FOLLOW_PROGRAM_in_program42); 

            match(input, Token.DOWN, null); 
            dbg.location(10,22);
            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Out.g:10:22: (t+= stmt )+
            int cnt1=0;
            try { dbg.enterSubRule(1);

            loop1:
            do {
                int alt1=2;
                try { dbg.enterDecision(1, decisionCanBacktrack[1]);

                int LA1_0 = input.LA(1);

                if ( ((LA1_0 >= DIGIT && LA1_0 <= 23)) ) {
                    alt1=1;
                }


                } finally {dbg.exitDecision(1);}

                switch (alt1) {
            	case 1 :
            	    dbg.enterAlt(1);

            	    // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Out.g:10:23: t+= stmt
            	    {
            	    dbg.location(10,24);
            	    pushFollow(FOLLOW_stmt_in_program47);
            	    t=stmt();

            	    state._fsp--;

            	    if (list_t==null) list_t=new ArrayList();
            	    list_t.add(t.getTemplate());


            	    }
            	    break;

            	default :
            	    if ( cnt1 >= 1 ) break loop1;
                        EarlyExitException eee =
                            new EarlyExitException(1, input);
                        dbg.recognitionException(eee);

                        throw eee;
                }
                cnt1++;
            } while (true);
            } finally {dbg.exitSubRule(1);}


            match(input, Token.UP, null); 


            // TEMPLATE REWRITE
            // 10:34: -> template(st=$t) \"Program <st; separator='\\n'>\"
            {
                retval.st = new StringTemplate(templateLib, "Program <st; separator='\\n'>",new STAttrMap().put("st", list_t));
            }



            }

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
        }

        finally {
        	// do for sure before leaving
        }
        dbg.location(11, 49);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "program");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "program"


    public static class stmt_return extends TreeRuleReturnScope {
        public StringTemplate st;
        public Object getTemplate() { return st; }
        public String toString() { return st==null?null:st.toString(); }
    };


    // $ANTLR start "stmt"
    // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Out.g:13:1: stmt : . -> template( \"!\";
    public final Out.stmt_return stmt() throws RecognitionException {
        Out.stmt_return retval = new Out.stmt_return();
        retval.start = input.LT(1);


        try { dbg.enterRule(getGrammarFileName(), "stmt");
        if ( getRuleLevel()==0 ) {dbg.commence();}
        incRuleLevel();
        dbg.location(13, 0);

        try {
            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Out.g:13:6: ( . -> template( \"!\")
            dbg.enterAlt(1);

            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Out.g:13:8: .
            {
            dbg.location(13,8);
            matchAny(input); 

            // TEMPLATE REWRITE
            // 13:10: -> template( \"!\"
            {
                retval.st = new StringTemplate(templateLib, "!");
            }



            }

        }
        catch (RecognitionException re) {
            reportError(re);
            recover(input,re);
        }

        finally {
        	// do for sure before leaving
        }
        dbg.location(13, 25);

        }
        finally {
            dbg.exitRule(getGrammarFileName(), "stmt");
            decRuleLevel();
            if ( getRuleLevel()==0 ) {dbg.terminate();}
        }

        return retval;
    }
    // $ANTLR end "stmt"

    // Delegated rules


 

    public static final BitSet FOLLOW_PROGRAM_in_program42 = new BitSet(new long[]{0x0000000000000004L});
    public static final BitSet FOLLOW_stmt_in_program47 = new BitSet(new long[]{0x0000000000FFFFF8L});

}