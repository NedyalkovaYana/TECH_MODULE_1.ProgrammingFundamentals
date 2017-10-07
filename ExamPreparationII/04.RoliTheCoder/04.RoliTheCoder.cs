using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.RoliTheCoder
{
    class Program
    {
        static void Main(string[] args)
        {
           
           Dictionary<int, string> 

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
                string idPattern = @"(?<id>\d){1}[\s*](#){1}(?<evenNames>[\w]+)";
                MatchCollection idMatch = Regex.Matches(input, idPattern);

                foreach (Match id in idMatch)
                {
                    string curentId = id.Groups["id"].Value;
                    string evenName = id.Groups["evenNames"].Value;
                    if (!list.ContainsKey(curentId))
                    {
                        list.Add(curentId, evenName);
                    }
                    else
                    {
                       
                    }
                }

                string participiantPattern = @"(?<participiant>@\w+)";
                MatchCollection participiantMatch = Regex.Matches(input, participiantPattern);

                foreach (Match p in participiantMatch)
                {
                    string curentId = p.Groups["participiant"].Value;
                   
                }
                //(?< id >\d){ 1}[\s+]#(?<evenNames>[A-Za-z\-\']+)((\s+)@(\w+))*
            }
        }
    }

}
