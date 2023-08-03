using System;

namespace Sample2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 2)
            {
                var inStream = new Antlr.Runtime.ANTLRFileStream(args[0]);
                var lexer = new SimpleLexer(inStream);

                var emitter = new Emitter();

                var tokenStream = new Antlr.Runtime.CommonTokenStream(lexer);
                var parser = new SimpleParser(tokenStream, emitter);

                parser.program();
                emitter.SaveMSIL(args[1]);
            }
            else
            {
                Console.WriteLine("usage: <program> <inputfile> <outputfile>");
            }
        }
    }

}
