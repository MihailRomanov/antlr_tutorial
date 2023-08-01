grammar Simple;
options 
{
	language = CSharp3;	
}

@header
{
using Sample2;
}

@members
{
	Emitter emitter; 
	
	public SimpleParser(ITokenStream input, Emitter emitter)
			: this(input) 
	{
			this.emitter = emitter;
	}
}

public
program 
	:	(stmt ';') +
	;
	
stmt	
	:	input_stmt 
	| 	print_stmt 
	| 	assign_stmt
	;

assign_stmt
	:	IDENT '=' expression { emitter.AddAssignStatement($IDENT.text ); }
	;

print_stmt
	:	'print'	expression { emitter.AddPrintStatement(); } (',' expression { emitter.AddPrintStatement(); } )*;

expression
	:	mult ( op=('+' | '-') mult { emitter.AddOperation($op.text); } )* 
	;

mult	
	:	atom ( op=( '*' | '/') atom { emitter.AddOperation($op.text); } )*
	;

atom	
	:	IDENT { emitter.AddLoadID($IDENT.text); }
	| 	NUMBER { emitter.AddLoadConst($NUMBER.text); }
	| 	'(' expression ')'
	;

input_stmt
	:	'input' IDENT { emitter.AddInputStatement($IDENT.text ); }
	;


NUMBER
	:	DIGIT +
	;
	
IDENT
	:	(LETTER | '_') (LETTER | '_' | DIGIT)*
	;


fragment
LETTER 	
	:	'A'..'Z' | 'a'..'z'
	;
	
fragment
DIGIT
	:	'0'..'9'
	;

WS	
	:	('\t' | '\r'? '\n' | ' ')+ { $channel = Hidden; }
	;