using System;
using System.IO;
using System.Reflection;

using Antlr.Runtime;
using Antlr.Runtime.Tree;

using Antlr3.ST;

namespace Sample5
{
    class Program
    {
        static void Main(string[] args)
        {
            var stg = new StringTemplateGroup(
                new StreamReader(new FileStream("Templates\\Simple.stg", FileMode.Open)));
            
            Console.WriteLine(stg.Templates.Count);

            var inStream = new ANTLRFileStream(@"D:\Projects\_Other\Antlr\AntlrTutorial\TestFiles\test.simp");
            var lexer = new SimpleLexer(inStream);

            var tokenStream = new CommonTokenStream(lexer);
            var parser = new SimpleParser(tokenStream);
            var tree = parser.program().Tree as CommonTree;

            Console.WriteLine(tree.ToStringTree());

            var treeStream = new CommonTreeNodeStream(tree);

            var convert = new Convert(treeStream);
            var convertedTree = convert.program().Tree;

            Console.WriteLine(convertedTree.ToStringTree());

            //var treeStream = new CommonTreeNodeStream(tree);
            //var treeParser = new Out(treeStream);
            //treeParser.TemplateGroup = stg;

            //var st = treeParser.program();

            //Console.WriteLine(st.Template.ToString());
        }
    }
}
