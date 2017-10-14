using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();
            string pattern = @"(?<letters>\D+)(?<digits>\d+)";

            MatchCollection matches = Regex.Matches(input, pattern);

            StringBuilder result = new StringBuilder();

            foreach (Match pair in matches)
            {
                string letters = pair.Groups["letters"].Value;
                int number = int.Parse(pair.Groups["digits"].Value);

                for (int i = 0; i < number; i++)
                {
                    result.Append(letters);
                }
            }
            int count = result.ToString().Distinct().Count();
            Console.WriteLine($"Unique symbols used: {count}");
            Console.WriteLine(result.ToString());
        }
    }
}
