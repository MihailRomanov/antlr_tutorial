grammar Simple;

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
	:	IDENT '=' expression
	;

print_stmt
	:	'print'	expression (',' expression )*;

expression
	:	mult ( ('+' | '-') mult)*
	;

mult	
	:	atom (( '*' | '/') atom)*
	;

atom	
	:	IDENT 
	| 	NUMBER 
	| 	'(' expression ')'
	;

input_stmt
	:	'input' IDENT
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