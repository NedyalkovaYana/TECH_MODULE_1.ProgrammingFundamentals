using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PunctuationFinder
{
    class PunctuationFinder
    {
        static void Main(string[] args)
        {
            string[] allLines = File.ReadAllLines
                ("input.txt");
            List<char> punctoations = new List<char>();
            char[] punctoationsToTake = new char[]
                { '.', ',', '!', '?', ':'};

            foreach (string line in allLines)
            {
                for (int i = 0; i < line.Length; i++)
                {
                    if (punctoationsToTake.Contains(line[i]))
                    {
                        punctoations.Add(line[i]);
                    }
                }
            }
            Console.WriteLine(string.Join(", ", punctoations));
        }
    }
}
