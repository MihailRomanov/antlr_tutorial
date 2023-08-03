tree grammar Out;
 
options {
	output=template;
	tokenVocab=Simple;
	ASTLabelType=CommonTree; 
}

public
program :  ^(PROGRAM (t+=stmt)+) -> 
			program(st={$t});

stmt	: input_stmt -> {$input_stmt.st}
		| print_stmt  -> {$print_stmt.st}
		| assign_stmt -> {$assign_stmt.st}
		;

assign_stmt
	:	^(STMT_ASSIGN IDENT expression) -> 
			assign_stmt(id={$IDENT.Text}, exp={$expression.st});

input_stmt
	:	^(STMT_INPUT IDENT) -> 
			input_stmt(id={$IDENT.Text});

print_stmt
	:	^(STMT_PRINT (exp+=expression)*) -> 
			print_stmt(exp={$exp});
expression
	: mult -> {$mult.st}
	| ^(PLUS e1=expression e2=expression) -> expression(e1={$e1.st}, e2={$e2.st}, operator={"+"})
	| ^(MINUS e1=expression e2=expression) -> expression(e1={$e1.st}, e2={$e2.st}, operator={"-"})
	;

mult	
	: atom -> {$atom.st}
	| ^(MUL e1=mult e2=mult) -> expression(e1={$e1.st}, e2={$e2.st}, operator={"*"})
	| ^(DIV e1=mult e2=mult) -> expression(e1={$e1.st}, e2={$e2.st}, operator={"/"})
	;

atom	
	:	IDENT -> {%{$IDENT.Text}}
	| 	NUMBER -> {%{$NUMBER.Text}}
	;