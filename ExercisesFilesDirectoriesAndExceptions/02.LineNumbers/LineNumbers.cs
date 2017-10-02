using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.LineNumbers
{
    class LineNumbers
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("input.txt");
            var numberedLines = lines.Select((line, index) => $"{index + 1}. { line}");
            File.WriteAllLines("output.txt", numberedLines);
            Console.WriteLine(File.ReadAllLines("output.txt"));
        }
    }
}
