tree grammar Convert;
 
options {
	output=AST;
	tokenVocab=Simple;
	ASTLabelType=CommonTree; 
}

public
program :  ^(PROGRAM (t+=stmt)+) -> $t+;

stmt	: input_stmt 
		| print_stmt 
		| assign_stmt
		;

assign_stmt
	:	^(STMT_ASSIGN IDENT expression) -> IDENT expression?;

input_stmt
	:	^(STMT_INPUT IDENT) -> IDENT;

print_stmt
	:	^(STMT_PRINT (exp+=expression)*) -> $exp*;

expression
	: mult 
	| ^(PLUS e1=expression e2=expression) -> $e1? $e2?
	| ^(MINUS e1=expression e2=expression) -> $e1? $e2?
	;

mult	
	: atom 
	| ^(MUL e1=mult e2=mult) -> $e1? $e2?
	| ^(DIV e1=mult e2=mult) -> $e1? $e2?
	;

atom	
	:	IDENT -> IDENT
	| 	NUMBER ->
	;
