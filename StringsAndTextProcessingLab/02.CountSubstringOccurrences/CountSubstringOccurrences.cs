using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.CountSubstringOccurrences
{
    class CountSubstringOccurrences
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToUpper();
            string word = Console.ReadLine().ToUpper();
            string pattern = $@"{word}";

            int numberAppears = Regex.Matches(Regex.Escape(text), pattern).Count;
            Console.WriteLine(numberAppears);
        }
    }
}
