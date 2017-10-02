using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.OddLines
{
    class OddLines
    {
        static void Main(string[] args)
        {
            var lines = File.ReadAllLines("input.txt");
            var oddLines = lines.Where((line, index) => index % 2 != 0);
            File.WriteAllLines("odd-Lines", oddLines);
            Console.WriteLine(File.ReadAllText("odd-Lines"));

        }
    }
}
