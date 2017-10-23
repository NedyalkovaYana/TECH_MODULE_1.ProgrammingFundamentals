using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace _09.Teamwork_Projects
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> teamDict = new Dictionary<string, List<string>>();
            int teamsCount = int.Parse(Console.ReadLine());
            List<string> creator = new List<string>();
            for (int i = 0; i < teamsCount; i++)
            {
                string[] userAndTeam = Console.ReadLine().Split('-');
                string user = userAndTeam[0];
                string team = userAndTeam[1];
                              
                if (creator.Contains(user))
                {
                    Console.WriteLine($"{user} cannot create another team!");
                    continue;
                }
                if (!teamDict.ContainsKey(team))
                {
                    teamDict[team] = new List<string>();             
                    teamDict[team].Add(user);
                    creator.Add(user);
                    Console.WriteLine($"Team {team} has been created by {user}!");                    
                }
                else
                {
                    Console.WriteLine($"Team {team} was already created!");
                    break;
                }
            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of assignment")
                {
                    break;
                }
                string[] candidatesForTeam =
                    input.Split(new string[] {"->"}, StringSplitOptions.RemoveEmptyEntries);

                string candidatesName = candidatesForTeam[0];
                string chousenTeam = candidatesForTeam[1];

                if (!teamDict.ContainsKey(chousenTeam))
                {
                    Console.WriteLine($"Team {chousenTeam} does not exist!");
                    continue;
                }

                var matchingCandidatesName = teamDict.Where(a => a.Value.Contains(candidatesName)).ToList();

                if (matchingCandidatesName.Count > 0)
                {
                    Console.WriteLine($"Member {candidatesName} cannot join team {chousenTeam}!");
                    continue;
                }

                if (teamDict.ContainsKey(chousenTeam))
                {
                    teamDict[chousenTeam].Add(candidatesName);
                }
            }

            foreach (var teams in teamDict.OrderBy(a => a.Key))
            {
                Console.WriteLine($"{teams.Key}");

                foreach (var members in teams.Value)
                {
                    Console.WriteLine($"-");
                }
            }
        }
    }
}
