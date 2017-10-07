using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _01.Hornet_Wings
{
    class Hornet_Wings
    {
        static void Main(string[] args)
        {
            int wingFlap = int.Parse(Console.ReadLine());

            double distanceInMeters = double.Parse(Console.ReadLine());
            int endurance = int.Parse(Console.ReadLine());

            double distance = (wingFlap / 1000) * distanceInMeters;

            double flaps = wingFlap / 100;
            double rest = (wingFlap / endurance) * 5;
            double totalSeconds = flaps + rest;

            Console.WriteLine($"{distance:f2} m.");
            Console.WriteLine($"{totalSeconds} s.");
        }
    }
}
