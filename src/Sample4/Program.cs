using System;

using Antlr.Runtime;
using Antlr.Runtime.Tree;

namespace Sample4
{
    class Program
    {
        static void Main(string[] args)
        {
            var inStream = new ANTLRFileStream(args[0]);
            var lexer = new SimpleLexer(inStream);

            var tokenStream = new CommonTokenStream(lexer);
            var parser = new SimpleParser(tokenStream);
            var tree = parser.program().Tree as CommonTree;
            
            var treeStream = new CommonTreeNodeStream(tree);
            var treeParser = new Out(treeStream);
            
            var st = treeParser.program();

            Console.WriteLine(st.Template.ToString());
        }
    }
}
