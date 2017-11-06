using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.MatchPhoneNumber
{
    class MatchPhoneNumber
    {
        static void Main(string[] args)
        {
            string regex = @"\+359([ -])2\1\d{3}\1\d{4}\b";
            var input = Console.ReadLine();

            var match = Regex.Matches(input, regex);

            var matchedPhones = match.Cast<Match>().Select(a => a.Value.Trim()).ToArray();
            Console.WriteLine(string.Join(", ", matchedPhones));

        }
    }
}

                           
           