namespace Sample3
{
    using System;
    using System.Linq;

    using Antlr.Runtime.Tree;

    class PrintASTVisitor 
    {
        public void visitProgram(CommonTree tree)
        {
            foreach (CommonTree node in tree.Children.OfType<CommonTree>())
            {
                switch (node.Type)
                { 
                    case SimpleParser.STMT_ASSIGN:
                        this.visitAssignStatement(node);
                        break;

                    case SimpleParser.STMT_INPUT:
                        this.visitInputStatement(node);
                        break;

                    case SimpleParser.STMT_PRINT:
                        this.visitPrintStatement(node);
                        break;

                    default:
                        Console.WriteLine("Error in PROGRAM node!");
                        break;
                }
            }
        }

        void visitAssignStatement(CommonTree tree)
        {
            var variable = tree.GetChild(0) as CommonTree;
            var expression = tree.GetChild(1) as CommonTree;

            Console.WriteLine("Присваиваем переменной " + variable.Token.Text + 
                " выражение " + this.visitExpression(expression));
        }

        void visitPrintStatement(CommonTree tree)
        {
            string allExpressions = string.Empty;

            foreach (CommonTree node in tree.Children.OfType<CommonTree>())
            {
                allExpressions += this.visitExpression(node) + " ";
            }

            Console.WriteLine("Печатаем значения " + allExpressions);
        }

        void visitInputStatement(CommonTree tree)
        {
            Console.WriteLine("Вводим значение переменной " + (tree.GetChild(0) as CommonTree).Token.Text);
        }

        string visitExpression(CommonTree tree)
        {
            switch (tree.Type)
            { 
                case SimpleParser.PLUS: 
                case SimpleParser.MINUS:
                case SimpleParser.MUL:
                case SimpleParser.DIV:
                    var leftExp = tree.GetChild(0) as CommonTree;
                    var rightExp = tree.GetChild(1) as CommonTree;

                    return "(" + this.visitExpression(leftExp) + tree.Token.Text + this.visitExpression(rightExp) + ")";

                case SimpleParser.NUMBER:
                case SimpleParser.IDENT:
                    return tree.Token.Text;

                default:
                    return string.Empty;
            }
        }
    }
}
