using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> driversName = Console.ReadLine().Split(' ').ToList();
            List<double> zones = Console.ReadLine().Split(' ').Select(d => double.Parse(d) * -1).ToList();
            List<int> checkpoints = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            foreach (var i in checkpoints)
            {
                if (i >= 0 && i < zones.Count)
                {
                    zones[i] *= -1;
                }

            }
            foreach (var driver in driversName)
            {
                var fuel = (double)driver[0];
                long index = 0;
                foreach (var zone in zones)
                {
                    fuel += zone;
                    if (fuel <= 0)
                    {
                        Console.WriteLine($"{driver} - reached {index}");
                        break;
                    }
                    index++;
                }
                if (fuel > 0)
                {
                    Console.WriteLine($"{driver} - fuel left {fuel:f2}");
                }
            }
        }
    }
}
