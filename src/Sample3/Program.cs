using Antlr.Runtime;
using Antlr.Runtime.Tree;

namespace Sample3
{
    using System;
    using System.IO;

    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1 || args.Length > 2)
            {
                Console.WriteLine("usage: <program> <inputfile>");
                Console.WriteLine("  or <program> <inputfile> <outputfile>");
            }

            var inStream = new ANTLRFileStream(args[0]);
            var lexer = new SimpleLexer(inStream);

            var tokenStream = new CommonTokenStream(lexer);
            var parser = new SimpleParser(tokenStream);

            var tree = parser.program().Tree as CommonTree;

            if (args.Length == 1)
            {
                var visitor = new PrintASTVisitor();
                visitor.visitProgram(tree);
            }
            else
            {
                var visitor = new ILASTVisitor();
                var program = visitor.visitProgram(tree);

                var outWriter = new StreamWriter(File.Create(args[1]), new System.Text.UTF8Encoding(true));
                outWriter.Write(program.ToString());
                outWriter.Flush();
            }
        }
    }

}
