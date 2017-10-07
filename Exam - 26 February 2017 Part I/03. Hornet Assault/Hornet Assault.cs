using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Hornet_Assault
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> beehives = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            List<long> hornets = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
          
            long hornestPowerSum = hornets.Sum();

            for (int i = 0; i < beehives.Count; i++)
            {
                if (hornets.Count == 0)
                {
                    break;
                }

                long beehivesCount = beehives[i];
                hornestPowerSum = hornets.Sum();
                beehives[i] -= hornestPowerSum;

                if (beehivesCount >= hornestPowerSum)
                {              
                    hornets.RemoveAt(0);
                }
            }
            PrintWiningSide(hornets, beehives);
        }

        static void PrintWiningSide(List<long> hornets, List<long> beehives)
        {
           List<long> aliveBeehives = new List<long>();

            foreach (var beehive in beehives)
            {
                if (beehive > 0)
                {
                    aliveBeehives.Add(beehive);
                }               
            }
            if (aliveBeehives.Count > 0)
            {
                Console.WriteLine(string.Join(" ", aliveBeehives));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets));
            }
        }
    }
}
