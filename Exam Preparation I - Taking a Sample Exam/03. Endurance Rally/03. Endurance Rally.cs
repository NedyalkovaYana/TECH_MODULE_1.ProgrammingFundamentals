using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Endurance_Rally
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> drivers = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<double> zones = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(d => double.Parse (d) * -1).ToList();
            List<int> checkPoints = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();
            double leftFuel = default(double);

            foreach (var index in checkPoints)
            {
                if (index >= 0 && index < zones.Count)
                {
                    zones[index] *= -1;
                }
            }

            foreach (var driver in drivers)
            {
                char driverLetter = driver.First();
                leftFuel = (int)driverLetter;

                int reached = 0;
                foreach (var r in zones)
                {
                    leftFuel += r;
                    if (leftFuel <= 0)
                    {
                        break;
                    }
                    reached++;
                }
                if (leftFuel > 0)
                {
                    Console.WriteLine($"{driver} - fuel left {leftFuel:f2}");
                }
                else
                {
                    Console.WriteLine($"{driver} - reached {reached}");
                }
            }
        }
    }
}
