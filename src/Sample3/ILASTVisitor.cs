namespace Sample3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Antlr.Runtime.Tree;

    class ILASTVisitor
    {
        private StringBuilder methodBody = new StringBuilder();

        private SortedSet<string> variableNames = new SortedSet<string>();
        
        public StringBuilder visitProgram(CommonTree tree)
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

                }
            }

            var program = new StringBuilder();

            program.AppendLine(".assembly Step_1 {}");
            program.AppendLine(".assembly extern mscorlib {}");
            program.AppendLine(".method static void main()");
            program.AppendLine("{");
            program.AppendLine(".entrypoint");
            program.AppendLine(".maxstack 100");

            if (this.variableNames.Count > 0)
            {
                string variableString = "int32 " + this.variableNames.First();
                foreach (string name in this.variableNames.Skip(1))
                {
                    variableString += ", int32 " + name;
                }

                program.AppendFormat(".locals init ({0}) \n", variableString);
            }

            program.Append(this.methodBody.ToString());

            program.AppendLine("ret");
            program.AppendLine("}");

            return program;
        }

        void visitAssignStatement(CommonTree tree)
        {
            var variable = ((CommonTree)tree.GetChild(0)).Text;
            var expression = tree.GetChild(1) as CommonTree;

            this.variableNames.Add(variable);

            this.visitExpression(expression);
            this.methodBody.AppendFormat("stloc {0} \n", variable);
        }

        void visitPrintStatement(CommonTree tree)
        {
            foreach (CommonTree node in tree.Children.OfType<CommonTree>())
            {
                this.visitExpression(node);
                this.methodBody.AppendLine("call void [mscorlib]System.Console::WriteLine(int32)");
            }
        }

        void visitInputStatement(CommonTree tree)
        {
            string variable = ((CommonTree)tree.GetChild(0)).Text;

            this.variableNames.Add(variable);

            this.methodBody.AppendLine("call string [mscorlib]System.Console::ReadLine()");
            this.methodBody.AppendLine("call int32 [mscorlib]System.Int32::Parse(string)");
            this.methodBody.AppendFormat("stloc {0} \n", variable);
        }

        void visitExpression(CommonTree tree)
        {
            switch (tree.Type)
            {
                case SimpleParser.PLUS:
                case SimpleParser.MINUS:
                case SimpleParser.MUL:
                case SimpleParser.DIV:
                    this.visitBinaryOperation(tree);
                    break;

                case SimpleParser.NUMBER:
                    this.methodBody.AppendFormat("ldc.i4 {0} \n", tree.Token.Text);
                    break;

                case SimpleParser.IDENT:
                    string variable = tree.Token.Text;

                    if (this.variableNames.Contains(variable))
                    {
                        this.methodBody.AppendFormat("ldloc {0}\n", variable);
                    }
                    else
                    {
                        // Обработка необъявленной переменной
                    }
                    break;
            }
        }

        void visitBinaryOperation(CommonTree tree)
        {
            this.visitExpression(tree.GetChild(0) as CommonTree);
            this.visitExpression(tree.GetChild(1) as CommonTree);

            switch (tree.Type)
            {
                case SimpleParser.PLUS:
                    this.methodBody.AppendLine("add");
                    break;

                case SimpleParser.MINUS:
                    this.methodBody.AppendLine("sub");
                    break;

                case SimpleParser.MUL:
                    this.methodBody.AppendLine("mul");
                    break;

                case SimpleParser.DIV:
                    this.methodBody.AppendLine("div");
                    break;
            }

        }

    }
}
