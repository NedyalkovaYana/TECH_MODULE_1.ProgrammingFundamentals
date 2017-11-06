using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _04.Worms.WorldParty
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> teamsDict =
                new Dictionary<string, Dictionary<string, long>>();

            string inputTeam = String.Empty;
            while ((inputTeam = Console.ReadLine()) != "quit")
            {
                string[] team = inputTeam.Trim().Split(new string[] {"->"}, StringSplitOptions.RemoveEmptyEntries);
                string wormName = team[0].Trim();
                string teamName = team[1].Trim();
                int wormScore = int.Parse(team[2].Trim());
                bool hasWorm = false;
                foreach (var worms in teamsDict)
                {
                    if (worms.Value.ContainsKey(wormName))
                    {
                        hasWorm = true;
                    }
                }
                if (!hasWorm)
                { 
                    if (!teamsDict.ContainsKey(teamName))
                    {
                        teamsDict[teamName] = new Dictionary<string, long>();
                       
                    }
                    teamsDict[teamName].Add(wormName, wormScore);
                }
            }
            teamsDict = teamsDict
                .OrderByDescending(x => x.Value.Sum(y => y.Value))
                .ThenByDescending(x => x.Value.Sum(y => y.Value) / x.Value.Count())
                .ToDictionary(x => x.Key, x => x.Value);

            int place = 1;

            foreach (var team in teamsDict)
            {
                Console.WriteLine($"{place}. Team: {team.Key} - {team.Value.Sum(a=> a.Value)}");
                foreach (var worm in team.Value.OrderByDescending(a => a.Value))
                {
                    Console.WriteLine($"###{worm.Key} : {worm.Value}");
                }
                place++;
            }            
        }
    }
}