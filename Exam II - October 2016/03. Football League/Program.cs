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
        class TeamList
        {          
            public int  Points { get; set; }
            public int  Goals { get; set; }
        }
        static void Main(string[] args)
        {
            Dictionary<string, TeamList> teams = new Dictionary<string, TeamList>();
            var key = Regex.Escape(Console.ReadLine());
            var pattern = 
                string.Format(@"^.*(?:{0})(?<team1>[a-zA-z]*)(?:{0}).*.*(?:{0})(?<team2>[a-zA-z]*)(?:{0}).* (?<team1Goals>\d+):(?<team2Goals>\d+)$", key);

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
                    var team2 = new string(match.Groups["team2"].Value.ToUpper().Reverse().ToArray());
                    int team1Goals = int.Parse(match.Groups["team1Goals"].Value);
                    int team2Goals = int.Parse(match.Groups["team2Goals"].Value);
                    

                    if (!teams.ContainsKey(team1))
                    {
                        teams[team1] = new TeamList();
                    }
                    if (!teams.ContainsKey(team2))
                    {
                        teams[team2] = new TeamList();
                    }

                    teams[team1].Goals += team1Goals;
                    teams[team2].Goals += team2Goals;

                    if (team1Goals > team2Goals)
                    {
                        teams[team1].Points += 3;

                    }
                    else if (team1Goals == team2Goals)
                    {
                        teams[team1].Points += 1;
                        teams[team2].Points += 1;
                    }
                    else
                    {
                        teams[team2].Points += 3;
                    }

                }
            }
            var leagueStanding = teams.OrderByDescending(a => a.Value.Points)
                .ThenBy(a => a.Key).ToArray();

            Console.WriteLine("League standings:");

            for (int i = 0; i < leagueStanding.Length; i++)
            {
                var currentStanding = leagueStanding[i];
                var place = i + 1;
                var country = currentStanding.Key;
                var points = currentStanding.Value.Points;

                Console.WriteLine($"{place}. {country} {points}"); 
            }

            Console.WriteLine("Top 3 scored goals:");
            var top3Goals = teams.OrderByDescending(a => a.Value.Goals)
                .ThenBy(a => a.Key)
                .Take(3).ToArray();

            foreach (var top3 in top3Goals)
            {
                var country = top3.Key;
                var goals = top3.Value.Goals;

                Console.WriteLine($"- {country} -> {goals}");
            }
        }
    }
}
