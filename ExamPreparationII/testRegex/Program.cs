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
                    string pattern1 = @"(?<id>\d){1}[\s+]#(?<evenNames>[A-Za-z\-\']+)([\s+](?<participiant>@\w+)+)+";
                    MatchCollection matches = Regex.Matches(input, pattern1);

                     foreach (Match item in matches)
                     {
                        var id = item.Groups["id"].Value;
                        var evenNames = item.Groups["evenNames"].Value;
                         var participiant = item.Groups["participiant"].Value;
                         Console.WriteLine(id);
                             
                     }
                }
            
        }
    }
}
