using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.OnlyLetters
{
    class OnlyLetters
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Regex regex = new Regex(@"(?<number>\d+)(?<letter>\w)");

            MatchCollection matches = regex.Matches(text);

            StringBuilder result = new StringBuilder(text);
            foreach (Match item in matches)
            {
                var number = item.Groups["number"].Value;
                var letter = item.Groups["letter"].Value;
                result.Replace(number, letter);
            }
            Console.WriteLine(result.ToString());

        }
    }
}
