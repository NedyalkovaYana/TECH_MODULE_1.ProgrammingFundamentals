using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Roli
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<int, string> list = new Dictionary<int, string>();
            Dictionary<string, Dictionary<string, string>> participiantDict = new Dictionary<string, Dictionary<string, string>>();
            string input = Console.ReadLine();

            while (input != "Time for Code")
            {

                string pattern = @"#";
                Regex regex = new Regex(pattern);
                Match match = regex.Match(input);
                if (!match.Success)
                {
                    continue;
                }
                string idPattern = @"(?<id>\d){1}[\s+](#){1}(?<evenNames>\w+)";
                MatchCollection idMatch = Regex.Matches(input, idPattern);

                foreach (Match id in idMatch)
                {
                    int curentId = int.Parse(id.Groups["id"].Value);
                    string evenName = id.Groups["evenNames"].Value;
                    if (evenName.Any(c => char.IsDigit(c)))
                    {
                        continue;
                    }
                    string particianPattern = @"((\s+)(?<participiant>@[a-zA-z\-\']+)+)";

                    MatchCollection participiantMatch = Regex.Matches(input, particianPattern);

                    if (participiantMatch.Count == 0)
                    {
                        if (!participiantDict.ContainsKey(evenName))
                        {
                            participiantDict.Add(evenName, new Dictionary<string, string>());
                            
                        }
                    }
                    else
                    {
                        foreach (Match item in participiantMatch)
                        {

                            string participian = item.Groups["participiant"].Value;

                            if (!list.ContainsKey(curentId))
                            {
                                list.Add(curentId, evenName);
                                if (!participiantDict.ContainsKey(evenName))
                                {
                                    participiantDict.Add(evenName, new Dictionary<string, string>());
                                    participiantDict[evenName].Add(participian, "0");
                                }
                            }
                            else
                            {
                                if (list.ContainsKey(curentId))
                                {
                                    if (list[curentId].Contains(evenName))
                                    {
                                        if (participiantDict[evenName].ContainsKey(participian))
                                        {
                                            continue;
                                        }
                                        else
                                        {
                                            participiantDict[evenName].Add(participian, "0");
                                        }
                                    }
                                }
                            }
                        }
                    }                    
                }
                input = Console.ReadLine();
            }

            foreach (var eve in participiantDict.OrderByDescending(x => x.Value.Distinct().Count()).ThenBy(z => z.Key))
            {
                Console.WriteLine($"{eve.Key} - {eve.Value.Distinct().Count()}");
                foreach (var person in eve.Value.OrderBy(a => a.Key))
                {
                    Console.WriteLine(person.Key);
                }
            }

        }
    }
}
