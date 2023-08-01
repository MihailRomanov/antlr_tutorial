grammar Simple;
options
{
	output = AST;
}

tokens
{
	PROGRAM;
	STMT_ASSIGN;
	STMT_PRINT;
	STMT_INPUT;
	
	PLUS = '+';
	MINUS = '-';
	MUL = '*';
	DIV = '/';
}

public
program 
	:	(stmt ';') + -> ^(PROGRAM stmt+) 
		;
	
stmt	
	:	input_stmt 
	| 	print_stmt 
	| 	assign_stmt
	;

assign_stmt
	:	IDENT '=' expression -> ^(STMT_ASSIGN IDENT expression)
	;

input_stmt
	:	'input' IDENT -> ^(STMT_INPUT IDENT)
	;

print_stmt
	:	'print' expression (',' expression )* -> ^(STMT_PRINT expression *)
	;

expression
	:	mult ( (PLUS | MINUS )^ mult)*
	;

mult	
	:	atom (( MUL | DIV)^ atom)*
	;

atom	
	:	IDENT 
	| 	NUMBER 
	| 	'(' expression ')' -> expression
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