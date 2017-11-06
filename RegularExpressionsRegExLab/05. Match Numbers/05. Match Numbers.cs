using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Match_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(^|(?<=\s))-?\d+(\.\d+)?($|(?=\s))";

            var numbersString = Console.ReadLine();

            var match = Regex.Matches(numbersString, pattern);

            foreach (Match m in match)
            {
                Console.Write(m.Value + " ");
            }
        }
    }
}
