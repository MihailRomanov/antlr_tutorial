// $ANTLR 3.4 D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g 2012-03-24 13:28:57

import org.antlr.runtime.*;
import java.util.Stack;
import java.util.List;
import java.util.ArrayList;

@SuppressWarnings({"all", "warnings", "unchecked"})
public class SimpleLexer extends Lexer {
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
    // delegators
    public Lexer[] getDelegates() {
        return new Lexer[] {};
    }

    public SimpleLexer() {} 
    public SimpleLexer(CharStream input) {
        this(input, new RecognizerSharedState());
    }
    public SimpleLexer(CharStream input, RecognizerSharedState state) {
        super(input,state);
    }
    public String getGrammarFileName() { return "D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g"; }

    // $ANTLR start "DIV"
    public final void mDIV() throws RecognitionException {
        try {
            int _type = DIV;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:2:5: ( '/' )
            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:2:7: '/'
            {
            match('/'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        	// do for sure before leaving
        }
    }
    // $ANTLR end "DIV"

    // $ANTLR start "MINUS"
    public final void mMINUS() throws RecognitionException {
        try {
            int _type = MINUS;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:3:7: ( '-' )
            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:3:9: '-'
            {
            match('-'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        	// do for sure before leaving
        }
    }
    // $ANTLR end "MINUS"

    // $ANTLR start "MUL"
    public final void mMUL() throws RecognitionException {
        try {
            int _type = MUL;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:4:5: ( '*' )
            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:4:7: '*'
            {
            match('*'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        	// do for sure before leaving
        }
    }
    // $ANTLR end "MUL"

    // $ANTLR start "PLUS"
    public final void mPLUS() throws RecognitionException {
        try {
            int _type = PLUS;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:5:6: ( '+' )
            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:5:8: '+'
            {
            match('+'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        	// do for sure before leaving
        }
    }
    // $ANTLR end "PLUS"

    // $ANTLR start "T__17"
    public final void mT__17() throws RecognitionException {
        try {
            int _type = T__17;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:6:7: ( '(' )
            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:6:9: '('
            {
            match('('); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        	// do for sure before leaving
        }
    }
    // $ANTLR end "T__17"

    // $ANTLR start "T__18"
    public final void mT__18() throws RecognitionException {
        try {
            int _type = T__18;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:7:7: ( ')' )
            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:7:9: ')'
            {
            match(')'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        	// do for sure before leaving
        }
    }
    // $ANTLR end "T__18"

    // $ANTLR start "T__19"
    public final void mT__19() throws RecognitionException {
        try {
            int _type = T__19;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:8:7: ( ',' )
            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:8:9: ','
            {
            match(','); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        	// do for sure before leaving
        }
    }
    // $ANTLR end "T__19"

    // $ANTLR start "T__20"
    public final void mT__20() throws RecognitionException {
        try {
            int _type = T__20;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:9:7: ( ';' )
            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:9:9: ';'
            {
            match(';'); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        	// do for sure before leaving
        }
    }
    // $ANTLR end "T__20"

    // $ANTLR start "T__21"
    public final void mT__21() throws RecognitionException {
        try {
            int _type = T__21;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:10:7: ( '=' )
            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:10:9: '='
            {
            match('='); 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        	// do for sure before leaving
        }
    }
    // $ANTLR end "T__21"

    // $ANTLR start "T__22"
    public final void mT__22() throws RecognitionException {
        try {
            int _type = T__22;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:11:7: ( 'input' )
            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:11:9: 'input'
            {
            match("input"); 



            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        	// do for sure before leaving
        }
    }
    // $ANTLR end "T__22"

    // $ANTLR start "T__23"
    public final void mT__23() throws RecognitionException {
        try {
            int _type = T__23;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:12:7: ( 'print' )
            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:12:9: 'print'
            {
            match("print"); 



            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        	// do for sure before leaving
        }
    }
    // $ANTLR end "T__23"

    // $ANTLR start "NUMBER"
    public final void mNUMBER() throws RecognitionException {
        try {
            int _type = NUMBER;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:59:2: ( ( DIGIT )+ )
            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:59:4: ( DIGIT )+
            {
            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:59:4: ( DIGIT )+
            int cnt1=0;
            loop1:
            do {
                int alt1=2;
                int LA1_0 = input.LA(1);

                if ( ((LA1_0 >= '0' && LA1_0 <= '9')) ) {
                    alt1=1;
                }


                switch (alt1) {
            	case 1 :
            	    // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:
            	    {
            	    if ( (input.LA(1) >= '0' && input.LA(1) <= '9') ) {
            	        input.consume();
            	    }
            	    else {
            	        MismatchedSetException mse = new MismatchedSetException(null,input);
            	        recover(mse);
            	        throw mse;
            	    }


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


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        	// do for sure before leaving
        }
    }
    // $ANTLR end "NUMBER"

    // $ANTLR start "IDENT"
    public final void mIDENT() throws RecognitionException {
        try {
            int _type = IDENT;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:63:2: ( ( LETTER | '_' ) ( LETTER | '_' | DIGIT )* )
            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:63:4: ( LETTER | '_' ) ( LETTER | '_' | DIGIT )*
            {
            if ( (input.LA(1) >= 'A' && input.LA(1) <= 'Z')||input.LA(1)=='_'||(input.LA(1) >= 'a' && input.LA(1) <= 'z') ) {
                input.consume();
            }
            else {
                MismatchedSetException mse = new MismatchedSetException(null,input);
                recover(mse);
                throw mse;
            }


            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:63:19: ( LETTER | '_' | DIGIT )*
            loop2:
            do {
                int alt2=2;
                int LA2_0 = input.LA(1);

                if ( ((LA2_0 >= '0' && LA2_0 <= '9')||(LA2_0 >= 'A' && LA2_0 <= 'Z')||LA2_0=='_'||(LA2_0 >= 'a' && LA2_0 <= 'z')) ) {
                    alt2=1;
                }


                switch (alt2) {
            	case 1 :
            	    // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:
            	    {
            	    if ( (input.LA(1) >= '0' && input.LA(1) <= '9')||(input.LA(1) >= 'A' && input.LA(1) <= 'Z')||input.LA(1)=='_'||(input.LA(1) >= 'a' && input.LA(1) <= 'z') ) {
            	        input.consume();
            	    }
            	    else {
            	        MismatchedSetException mse = new MismatchedSetException(null,input);
            	        recover(mse);
            	        throw mse;
            	    }


            	    }
            	    break;

            	default :
            	    break loop2;
                }
            } while (true);


            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        	// do for sure before leaving
        }
    }
    // $ANTLR end "IDENT"

    // $ANTLR start "LETTER"
    public final void mLETTER() throws RecognitionException {
        try {
            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:70:2: ( 'A' .. 'Z' | 'a' .. 'z' )
            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:
            {
            if ( (input.LA(1) >= 'A' && input.LA(1) <= 'Z')||(input.LA(1) >= 'a' && input.LA(1) <= 'z') ) {
                input.consume();
            }
            else {
                MismatchedSetException mse = new MismatchedSetException(null,input);
                recover(mse);
                throw mse;
            }


            }


        }
        finally {
        	// do for sure before leaving
        }
    }
    // $ANTLR end "LETTER"

    // $ANTLR start "DIGIT"
    public final void mDIGIT() throws RecognitionException {
        try {
            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:75:2: ( '0' .. '9' )
            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:
            {
            if ( (input.LA(1) >= '0' && input.LA(1) <= '9') ) {
                input.consume();
            }
            else {
                MismatchedSetException mse = new MismatchedSetException(null,input);
                recover(mse);
                throw mse;
            }


            }


        }
        finally {
        	// do for sure before leaving
        }
    }
    // $ANTLR end "DIGIT"

    // $ANTLR start "WS"
    public final void mWS() throws RecognitionException {
        try {
            int _type = WS;
            int _channel = DEFAULT_TOKEN_CHANNEL;
            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:78:2: ( ( '\\t' | ( '\\r' )? '\\n' | ' ' )+ )
            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:78:4: ( '\\t' | ( '\\r' )? '\\n' | ' ' )+
            {
            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:78:4: ( '\\t' | ( '\\r' )? '\\n' | ' ' )+
            int cnt4=0;
            loop4:
            do {
                int alt4=4;
                switch ( input.LA(1) ) {
                case '\t':
                    {
                    alt4=1;
                    }
                    break;
                case '\n':
                case '\r':
                    {
                    alt4=2;
                    }
                    break;
                case ' ':
                    {
                    alt4=3;
                    }
                    break;

                }

                switch (alt4) {
            	case 1 :
            	    // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:78:5: '\\t'
            	    {
            	    match('\t'); 

            	    }
            	    break;
            	case 2 :
            	    // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:78:12: ( '\\r' )? '\\n'
            	    {
            	    // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:78:12: ( '\\r' )?
            	    int alt3=2;
            	    int LA3_0 = input.LA(1);

            	    if ( (LA3_0=='\r') ) {
            	        alt3=1;
            	    }
            	    switch (alt3) {
            	        case 1 :
            	            // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:78:12: '\\r'
            	            {
            	            match('\r'); 

            	            }
            	            break;

            	    }


            	    match('\n'); 

            	    }
            	    break;
            	case 3 :
            	    // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:78:25: ' '
            	    {
            	    match(' '); 

            	    }
            	    break;

            	default :
            	    if ( cnt4 >= 1 ) break loop4;
                        EarlyExitException eee =
                            new EarlyExitException(4, input);
                        throw eee;
                }
                cnt4++;
            } while (true);


             _channel = Hidden; 

            }

            state.type = _type;
            state.channel = _channel;
        }
        finally {
        	// do for sure before leaving
        }
    }
    // $ANTLR end "WS"

    public void mTokens() throws RecognitionException {
        // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:1:8: ( DIV | MINUS | MUL | PLUS | T__17 | T__18 | T__19 | T__20 | T__21 | T__22 | T__23 | NUMBER | IDENT | WS )
        int alt5=14;
        switch ( input.LA(1) ) {
        case '/':
            {
            alt5=1;
            }
            break;
        case '-':
            {
            alt5=2;
            }
            break;
        case '*':
            {
            alt5=3;
            }
            break;
        case '+':
            {
            alt5=4;
            }
            break;
        case '(':
            {
            alt5=5;
            }
            break;
        case ')':
            {
            alt5=6;
            }
            break;
        case ',':
            {
            alt5=7;
            }
            break;
        case ';':
            {
            alt5=8;
            }
            break;
        case '=':
            {
            alt5=9;
            }
            break;
        case 'i':
            {
            int LA5_10 = input.LA(2);

            if ( (LA5_10=='n') ) {
                int LA5_15 = input.LA(3);

                if ( (LA5_15=='p') ) {
                    int LA5_17 = input.LA(4);

                    if ( (LA5_17=='u') ) {
                        int LA5_19 = input.LA(5);

                        if ( (LA5_19=='t') ) {
                            int LA5_21 = input.LA(6);

                            if ( ((LA5_21 >= '0' && LA5_21 <= '9')||(LA5_21 >= 'A' && LA5_21 <= 'Z')||LA5_21=='_'||(LA5_21 >= 'a' && LA5_21 <= 'z')) ) {
                                alt5=13;
                            }
                            else {
                                alt5=10;
                            }
                        }
                        else {
                            alt5=13;
                        }
                    }
                    else {
                        alt5=13;
                    }
                }
                else {
                    alt5=13;
                }
            }
            else {
                alt5=13;
            }
            }
            break;
        case 'p':
            {
            int LA5_11 = input.LA(2);

            if ( (LA5_11=='r') ) {
                int LA5_16 = input.LA(3);

                if ( (LA5_16=='i') ) {
                    int LA5_18 = input.LA(4);

                    if ( (LA5_18=='n') ) {
                        int LA5_20 = input.LA(5);

                        if ( (LA5_20=='t') ) {
                            int LA5_22 = input.LA(6);

                            if ( ((LA5_22 >= '0' && LA5_22 <= '9')||(LA5_22 >= 'A' && LA5_22 <= 'Z')||LA5_22=='_'||(LA5_22 >= 'a' && LA5_22 <= 'z')) ) {
                                alt5=13;
                            }
                            else {
                                alt5=11;
                            }
                        }
                        else {
                            alt5=13;
                        }
                    }
                    else {
                        alt5=13;
                    }
                }
                else {
                    alt5=13;
                }
            }
            else {
                alt5=13;
            }
            }
            break;
        case '0':
        case '1':
        case '2':
        case '3':
        case '4':
        case '5':
        case '6':
        case '7':
        case '8':
        case '9':
            {
            alt5=12;
            }
            break;
        case 'A':
        case 'B':
        case 'C':
        case 'D':
        case 'E':
        case 'F':
        case 'G':
        case 'H':
        case 'I':
        case 'J':
        case 'K':
        case 'L':
        case 'M':
        case 'N':
        case 'O':
        case 'P':
        case 'Q':
        case 'R':
        case 'S':
        case 'T':
        case 'U':
        case 'V':
        case 'W':
        case 'X':
        case 'Y':
        case 'Z':
        case '_':
        case 'a':
        case 'b':
        case 'c':
        case 'd':
        case 'e':
        case 'f':
        case 'g':
        case 'h':
        case 'j':
        case 'k':
        case 'l':
        case 'm':
        case 'n':
        case 'o':
        case 'q':
        case 'r':
        case 's':
        case 't':
        case 'u':
        case 'v':
        case 'w':
        case 'x':
        case 'y':
        case 'z':
            {
            alt5=13;
            }
            break;
        case '\t':
        case '\n':
        case '\r':
        case ' ':
            {
            alt5=14;
            }
            break;
        default:
            NoViableAltException nvae =
                new NoViableAltException("", 5, 0, input);

            throw nvae;

        }

        switch (alt5) {
            case 1 :
                // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:1:10: DIV
                {
                mDIV(); 


                }
                break;
            case 2 :
                // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:1:14: MINUS
                {
                mMINUS(); 


                }
                break;
            case 3 :
                // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:1:20: MUL
                {
                mMUL(); 


                }
                break;
            case 4 :
                // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:1:24: PLUS
                {
                mPLUS(); 


                }
                break;
            case 5 :
                // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:1:29: T__17
                {
                mT__17(); 


                }
                break;
            case 6 :
                // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:1:35: T__18
                {
                mT__18(); 


                }
                break;
            case 7 :
                // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:1:41: T__19
                {
                mT__19(); 


                }
                break;
            case 8 :
                // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:1:47: T__20
                {
                mT__20(); 


                }
                break;
            case 9 :
                // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:1:53: T__21
                {
                mT__21(); 


                }
                break;
            case 10 :
                // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:1:59: T__22
                {
                mT__22(); 


                }
                break;
            case 11 :
                // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:1:65: T__23
                {
                mT__23(); 


                }
                break;
            case 12 :
                // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:1:71: NUMBER
                {
                mNUMBER(); 


                }
                break;
            case 13 :
                // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:1:78: IDENT
                {
                mIDENT(); 


                }
                break;
            case 14 :
                // D:\\Projects\\_Other\\Antlr\\AntlrTutorial\\Sample4\\Simple.g:1:84: WS
                {
                mWS(); 


                }
                break;

        }

    }


 

}