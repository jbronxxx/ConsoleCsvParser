using System;

namespace TestCsv
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser parser = new Parser();

            parser.ReadCsv("");

            var readCsv = parser.CreateHeader(parser._csv);

            Console.WriteLine(readCsv.Count);

            Console.ReadLine();
        }
    }
}

        
    