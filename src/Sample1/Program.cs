using System;
using Antlr.Runtime;

namespace Sample1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Строка с текстом программы - чтобы не связываться с вводом-выводом
            var inputString = "a = 3 + 4; input b; print a + 1, b * 3;";

            /* Создаем цепочку обработки входящей строки
             * - входящий поток, читающий из заранее предопределенной строки
             * - лексический анализатор, подключенный к входному потоку
             * - поток токенов, связанный с ранее созданным лексическим анализатором
             * - синтаксический анализатор, работающий с созданным ранее потоком токенов
             */
            var inputSteam = new ANTLRStringStream(inputString);
            var lexer = new SimpleLexer(inputSteam);
            var tokenStream = new CommonTokenStream(lexer);
            var parser = new SimpleParser(tokenStream);

            // Создаем и подключаем буфер сбора ошибок разбора
            var logBuffer = new System.IO.StringWriter();
            parser.TraceDestination = logBuffer;

            // Вызываем разбор правила program
            parser.program();

            // Анализируем результаты разбора. Если были синтаксические ошибки, выдадим лог анализа
            if (parser.NumberOfSyntaxErrors != 0)
            {
                Console.WriteLine(logBuffer.ToString());
            }
            else
            {
                Console.WriteLine("All ok!");
            }
        }
    }
}
