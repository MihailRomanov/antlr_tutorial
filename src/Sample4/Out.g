tree grammar Out;
 
options {
	output=template;
	tokenVocab=Simple;
	ASTLabelType=CommonTree; 
}

public
program :  ^(PROGRAM (t+=stmt)+) -> 
			template(st={$t})<<<st; separator="\n"> >>;

stmt	: input_stmt -> {$input_stmt.st}
		| print_stmt  -> {$print_stmt.st}
		| assign_stmt -> {$assign_stmt.st}
		;

assign_stmt
	:	^(STMT_ASSIGN IDENT expression) -> 
			template(id={$IDENT.Text}, exp={$expression.st})
			<<Присваиваем переменной <id> выражение <exp> >>
	;

input_stmt
	:	^(STMT_INPUT IDENT) -> 
			template(id={$IDENT.Text})
			<<Вводим значение переменной <id> >>
	;

print_stmt
	:	^(STMT_PRINT (exp+=expression)*) -> 
			template(exp={$exp})
			<<Печатаем значения <exp; separator=", "> >>
	;

expression
	: mult -> {$mult.st}
	| ^(PLUS e1=expression e2=expression) -> 
		template(e1={$e1.st},e2={$e2.st})
		<<(<e1> + <e2>)>>
	| ^(MINUS e1=expression e2=expression) -> 
		template(e1={$e1.st},e2={$e2.st})
		<<(<e1> - <e2>)>>
	;

mult	
	: atom -> {$atom.st}
	| ^(MUL e1=mult e2=mult) -> 
		template(e1={$e1.st},e2={$e2.st})
		<<(<e1> * <e2>)>>
	| ^(DIV e1=mult e2=mult) -> 
		template(e1={$e1.st},e2={$e2.st})
		<<(<e1> / <e2>)>>
	;

atom	
	:	IDENT -> {%{$IDENT.Text}}
	| 	NUMBER -> {%{$NUMBER.Text}}
	;