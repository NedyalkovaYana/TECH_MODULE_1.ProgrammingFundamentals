using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Football_League
{
    class Program
    {
        class TeamGoalsAndPoints
        {
            public int Goals { get; set; }
            public int Points { get; set; }
            public string Name { get; set; }
        }
        static void Main(string[] args)
        {
            Dictionary<string, TeamGoalsAndPoints> dict = new Dictionary<string, TeamGoalsAndPoints>();

            string key =Regex.Escape(Console.ReadLine());

            string pattern = string.Format(@"^.*(?:{0})(?<team1>[a-zA-z]*)(?:{0}).*.*(?:{0})(?<team2>[a-zA-z]*)(?:{0}).* (?<team1Goals>\d+):(?<team2Goals>\d+)$", key);

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "final")
                {
                    break;
                }

                var matches = Regex.Matches(line, pattern);

                foreach (Match match in matches)
                {
                    var team1 = new string(match.Groups["team1"].Value.ToUpper().Reverse().ToArray());
                    var team2 =new string(match.Groups["team2"].Value.ToUpper().Reverse().ToArray());
                    int goalsTeam1 = int.Parse(match.Groups["team1Goals"].Value);
                    int goalsTeam2 = int.Parse(match.Groups["team2Goals"].Value);

                    if (!dict.ContainsKey(team1))
                    {
                        dict[team1] = new TeamGoalsAndPoints();
                    }
                    if (!dict.ContainsKey(team2))
                    {
                        dict[team2] = new TeamGoalsAndPoints();
                    }
                    dict[team1].Goals += goalsTeam1;
                    dict[team2].Goals += goalsTeam2;

                    if (goalsTeam1 > goalsTeam2)
                    {
                        dict[team1].Points += 3;
                    }
                    else if (goalsTeam2 > goalsTeam1)
                    {
                        dict[team2].Points += 3;
                    }
                    else
                    {
                        dict[team1].Points += 1;
                        dict[team2].Points += 1;
                    }

                }

            }
            Console.WriteLine("League standings:");
            int place = 1;
            foreach (var item in dict.OrderByDescending(a => a.Value.Points).ThenBy(a => a.Key))
            {              
                Console.WriteLine($"{place}. {item.Key} {item.Value.Points}");
                place++;
            }
            Console.WriteLine("Top 3 scored goals:");
            foreach (var item in dict.OrderByDescending(a => a.Value.Goals).ThenBy(a => a.Key).Take(3))
            {
                Console.WriteLine($"- {item.Key} -> {item.Value.Goals}");
            }
        }
    }
}
