using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.RageQuit
{
    class RageQuit
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();
            string pattern = @"(?<letters>\D+)(?<digits>\d+)";

            StringBuilder message = new StringBuilder();

            MatchCollection match = Regex.Matches(input, pattern);

            foreach (Match pair in match)
            {
                var letters = pair.Groups["letters"].Value;
                int repeat =int.Parse(pair.Groups["digits"].Value);

                for (int i = 0; i < repeat; i++)
                {
                    message.Append(letters);
                }
                
            }
            int count = message.ToString().Distinct().Count();
            Console.WriteLine($"Unique symbols used: {count}");
            Console.WriteLine(message);
        }
    }
}
