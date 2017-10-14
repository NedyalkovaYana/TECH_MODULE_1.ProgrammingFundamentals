using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _10.Сръбско_Unleashed
{
    class Сръбско_Unleashed
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> list = new Dictionary<string, Dictionary<string, long>>();
            string pattern = @"(?<singerName>(?:.*?)\s{1,3})@(?<town>(?:.*?)\s{1,3})(?<price>\d+) (?<count>\d+)";

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End")
                {
                    break;
                }

                Match matches = Regex.Match(line, pattern);

                if (!matches.Success)
                {
                    continue;
                }

                string singer = matches.Groups["singerName"].Value;
                string town = matches.Groups["town"].Value;
                long price = long.Parse(matches.Groups["price"].Value);
                long count = long.Parse(matches.Groups["count"].Value);
                long totalMoney = price * count;

                if (!list.ContainsKey(town))
                {
                    list[town] = new Dictionary<string, long>();
                }
                if (!list[town].ContainsKey(singer))
                {
                    list[town].Add(singer, 0);
                }
                list[town][singer] += totalMoney;
            }

            foreach (var town in list)
            {
                Console.WriteLine($"{town.Key} ");


                foreach (var item in town.Value.OrderByDescending(a => a.Value))
                {
                    Console.WriteLine($"#  {item.Key}-> {item.Value}");
                }
            }
        }
    }
}
