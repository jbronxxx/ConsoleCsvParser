using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace ConsoleCsvParser
{
    public class Parser
    {
        internal List<string> _csv { get; set; }

        private List<string> _header = new List<string>();

        public List<string> ReadCsv(string _csvPath)
        {
            _csv = File.ReadAllLines(_csvPath).ToList();

            foreach (var lines in _csv)
            {
                Console.WriteLine(lines);
            }

            Console.WriteLine("\nThe file has been created.\n");

            for (int i = 0; i <_csv.Count; i++)
            {
                Console.WriteLine($"Line {i + 1}:\n {_csv[i]}\n");
            }

            return _csv;
        }

        public List<string> CreateHeader(List<string> _csv)
        {
            string[] split = _csv[0].Split(',').ToArray();
            
            for (int i = 0; i < split.Length; i++)
            {
                _header.Add(split[i]);
            }

            Console.WriteLine("\nThe header has been created.\n");

            for (int i = 0; i < _header.Count; i++)
            {
                Console.WriteLine($"Field {i + 1}: {_header[i]}\n");
            }

            return _header;
        }
    }
}
