using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern =
                @"(^|(?<=\s))[a-z0-9]+((\.-)([a-z0-9]+))?@[a-z]+((\.-)[a-z0-9]+)*(\.[a-z]+)";
            var regex = new Regex(pattern);
            var collectedMatches = regex.Matches(input)
                .Cast<Match>()
                .Select(x => x.Value)
                .ToArray();
            Console.WriteLine(string.Join((Environment.NewLine), collectedMatches));

        }
    }
}
