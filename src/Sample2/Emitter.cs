namespace Sample2
{
    #region Namespace Imports

    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    #endregion

    public class Emitter
    {
        /// <summary>
        ///     Класс для хранения информации о переменных
        ///     (пока только имя)
        /// </summary>
        public class VariableInfo
        {
            public VariableInfo(string name)
            {
                this.Name = name;
            }

            public string Name { get; set; }
        }

        /// <summary>
        ///     Таблица переменных
        /// </summary>
        private readonly IDictionary<string, VariableInfo> variableTable = new Dictionary<string, VariableInfo>();

        /// <summary>
        ///     Буфер для формирования тела основного метода
        /// </summary>
        private readonly StringBuilder methodBody = new StringBuilder();

        #region Методы для формирования кончного IL-файла

        /// <summary>
        ///     Запись в выходной поток шапки файла
        /// </summary>
        /// <param name = "outWriter"></param>
        private void WriteHeader(StreamWriter outWriter)
        {
            // Объявление сборки, модуля и подключаемых сборок
            outWriter.WriteLine(".assembly Program { }");
            outWriter.WriteLine(".module Program.exe");
            outWriter.WriteLine(".assembly extern mscorlib { }");
            outWriter.WriteLine();

            // Объявление основного метода - точки входа (стек ставим условно)
            outWriter.WriteLine(".method public static void Main() {");
            outWriter.WriteLine(".entrypoint");
            outWriter.WriteLine(".maxstack 300");
        }

        /// <summary>
        ///     Запись окончания файла
        /// </summary>
        /// <param name = "outWriter"></param>
        private void WriteFooter(StreamWriter outWriter)
        {
            outWriter.WriteLine("ret");
            outWriter.WriteLine("}");
        }

        /// <summary>
        ///     Запись объявления всех встреченных локальных переменных
        /// </summary>
        /// <param name = "outWriter"></param>
        private void WriteLocals(StreamWriter outWriter)
        {
            if (this.variableTable.Count == 0)
            {
                return;
            }

            var localsString = new StringBuilder();
            localsString.Append(".locals (");

            foreach (VariableInfo variable in this.variableTable.Values)
            {
                localsString.AppendFormat("int32 {0},", variable.Name);
            }

            localsString.Remove(localsString.Length - 1, 1);
            localsString.Append(")");

            outWriter.WriteLine(localsString.ToString());
        }

        /// <summary>
        ///     Запись ранее сгенерированного тела метода
        /// </summary>
        /// <param name = "outWriter"></param>
        private void WriteMethodBody(StreamWriter outWriter)
        {
            outWriter.WriteLine(this.methodBody.ToString());
        }

        /// <summary>
        ///     Запись всего выходного файла
        /// </summary>
        /// <param name = "fileName"></param>
        public void SaveMSIL(string fileName)
        {
            var outWriter = new StreamWriter(File.Create(fileName), new UTF8Encoding(true));

            this.WriteHeader(outWriter);
            this.WriteLocals(outWriter);
            this.WriteMethodBody(outWriter);
            this.WriteFooter(outWriter);

            outWriter.Flush();
        }

        #endregion

        #region Методы для генерации IL-команд во время разбора программы

        /// <summary>
        ///     Добавление кода для оператора присваивания
        /// </summary>
        /// <param name = "variableName"></param>
        public void AddInputStatement(string variableName)
        {
            if (!this.variableTable.Keys.Contains(variableName))
            {
                this.variableTable.Add(variableName, new VariableInfo(variableName));
            }

            this.methodBody.AppendLine("ldstr \"Введите значение переменной " + variableName + ": \"");
            this.methodBody.AppendLine("call void [mscorlib]System.Console::Write(string)");

            this.methodBody.AppendLine("call string [mscorlib]System.Console::ReadLine()");
            this.methodBody.AppendLine("call int32 [mscorlib]System.Int32::Parse(string)");
            this.methodBody.AppendLine("stloc  " + variableName);
        }

        /// <summary>
        ///     Добавление кода для оператора печати (только целые значения)
        ///     Здесь формируется только операция вывода - само значение в этот момент уже в стеке
        /// </summary>
        public void AddPrintStatement()
        {
            this.methodBody.AppendLine("call void [mscorlib]System.Console::WriteLine(int32)");
        }

        /// <summary>
        ///     Добавление кода для оператора присваивания
        ///     Аналогично оператору печати здесь формируется только код загрузки переменной 
        ///     - значение уже в стеке
        /// </summary>
        /// <param name = "variableName"></param>
        public void AddAssignStatement(string variableName)
        {
            if (!this.variableTable.Keys.Contains(variableName))
            {
                this.variableTable.Add(variableName, new VariableInfo(variableName));
            }

            this.methodBody.AppendLine("stloc  " + variableName);
        }

        /// <summary>
        ///     Загрузка в стек значения локальной переменной
        /// </summary>
        /// <param name = "variableName"></param>
        public void AddLoadID(string variableName)
        {
            this.methodBody.AppendLine("ldloc  " + variableName);
        }

        /// <summary>
        ///     Загрузка в стек константы
        /// </summary>
        /// <param name = "number">значение константы</param>
        public void AddLoadConst(string number)
        {
            this.methodBody.AppendLine("ldc.i4  " + number);
        }

        /// <summary>
        ///     Генерация кода операций
        /// </summary>
        /// <param name = "op">строка со знаком операции</param>
        public void AddOperation(string op)
        {
            switch (op)
            {
                case "+":
                    this.methodBody.AppendLine("add");
                    break;
                case "-":
                    this.methodBody.AppendLine("sub");
                    break;
                case "*":
                    this.methodBody.AppendLine("mul");
                    break;
                case "/":
                    this.methodBody.AppendLine("div");
                    break;
                default:
                    break;
            }
        }

        #endregion
    }
}