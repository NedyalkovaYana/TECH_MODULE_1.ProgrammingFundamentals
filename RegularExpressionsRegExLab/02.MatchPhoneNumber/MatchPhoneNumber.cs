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
            string regex = @"\+\d{3}(\s|-)\d{1}(\1)\d{3}(\1)\d{4}";
                           
            string input = Console.ReadLine();

            var match = Regex.Matches(input, regex);

            var matchedPhoneNumbers = match.Cast<Match>().Select(a => a.Value.Trim()).ToArray();

            Console.WriteLine(string.Join(", ", matchedPhoneNumbers));
            
        }
    }
}
