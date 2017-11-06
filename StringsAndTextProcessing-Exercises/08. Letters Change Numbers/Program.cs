using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _08.Letters_Change_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] {' ', '\t'}, StringSplitOptions.RemoveEmptyEntries)
                .Select(a => a.Trim()).ToArray();
            string pattern = @"(?<firstLetter>[a-zA-Z])(?<digits>\d+)(?<secondLetter>[a-zA-Z])";
             decimal secondOperation = 0m;
            decimal totalResult = 0m;
            foreach (var word in input)
            {
                var match = Regex.Match(word, pattern);
                var firstLetter = match.Groups["firstLetter"].Value;
                var digits = decimal.Parse(match.Groups["digits"].Value);
                var lastLetter = match.Groups["secondLetter"].Value;
                decimal resultFirstOperation = 0m;
                if (firstLetter.Trim().Any(a => Char.IsUpper(a)))
                {
                    char upperLetter = Char.Parse(firstLetter);
                    int index = char.ToUpper(upperLetter) - 64;

                    resultFirstOperation = digits/index;
                }
                else
                {
                    char lowerLetter = Char.Parse(firstLetter);
                    int index = char.ToLower(lowerLetter) % 32;

                    resultFirstOperation = index * digits;
                }

                if (lastLetter.Trim().Any(b => Char.IsUpper(b)))
                {
                    char upperLetter = Char.Parse(lastLetter);
                    int index = char.ToUpper(upperLetter) - 64;

                    secondOperation = resultFirstOperation - index;
                }
                else
                {
                    char lowerLetter = Char.Parse(lastLetter);
                    int index = char.ToLower(lowerLetter) % 32;

                    secondOperation = resultFirstOperation + index;
                }
                totalResult += secondOperation;
            }

            Console.WriteLine($"{totalResult:f2}");
        }
    }
}
