using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, decimal> teams = new Dictionary<string, decimal>();
            int numbers = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers; i++)
            {

                decimal distanceInMiles = decimal.Parse(Console.ReadLine()) * 1600m;
                decimal cargoTon = decimal.Parse(Console.ReadLine()) * 1000m;
                string team = Console.ReadLine();

                decimal earnedMoney = (cargoTon * 1.5m) - (0.7m * distanceInMiles * 2.5m);
                if (teams.ContainsKey(team))
                {
                    teams[team] += earnedMoney;
                }
                else
                {
                    teams.Add(team, earnedMoney);
                }
               
            }
            foreach (var team in teams.OrderByDescending(a => a.Value))
            {
                Console.WriteLine($"The {team.Key} Trainers win with ${team.Value:f3}.");
                break;
            }
        }
    }
}
