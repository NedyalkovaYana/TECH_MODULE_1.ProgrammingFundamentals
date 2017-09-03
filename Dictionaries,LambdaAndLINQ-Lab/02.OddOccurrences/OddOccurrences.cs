using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OddOccurrences
{
    class OddOccurrences
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string[] word = input.Split(' ');
            var dict = new Dictionary<string, int>();
            foreach (var w in word)
            {
                if (dict.ContainsKey(w))
                {
                    dict[w]++;
                }
                else
                {
                    dict[w] = 1;
                }
            }
            var output = new List<string>();
            bool first = true;
            foreach (var p in dict)
            {
                if (p.Value % 2 == 1)
                {
                    if (!first)
                    {
                        Console.Write(", ");
                    }
                    Console.Write(p.Key);           
                    first = false;
                } 
            }
            Console.WriteLine();
        }
    }
}
