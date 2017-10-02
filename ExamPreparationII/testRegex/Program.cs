using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace testRegex
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
 
                while (true)
                {
                    if (input == "Time for code")
                    {
                        break;
                    }
                    string pattern = @"#";
                    Regex regex = new Regex(pattern);
                    Match match = regex.Match(input);
                    if (!match.Success)
                    {
                        continue;
                    }
                    string idPattern = @"(?<id>[\d]){1}";
                    MatchCollection idMatch = Regex.Matches(input, idPattern);

                    foreach (Match id in idMatch)
                    {
                        string curentId = id.Groups["id"].Value;

                    }
                }
            
        }
    }
}
