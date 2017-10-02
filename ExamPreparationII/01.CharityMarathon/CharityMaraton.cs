using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CharityMarathon
{
    class CharityMaraton
    {
        static void Main(string[] args)
        {
            decimal maratonsDays = decimal.Parse(Console.ReadLine());
            decimal numberOfRunners = decimal.Parse(Console.ReadLine());
            decimal averageOfLaps = decimal.Parse(Console.ReadLine());
            decimal lengthOfTrack = decimal.Parse(Console.ReadLine());
            decimal capacityOfTrack = decimal.Parse(Console.ReadLine());
            decimal moneyToKM = decimal.Parse(Console.ReadLine());

            decimal totalRunners = Math.Min(numberOfRunners, capacityOfTrack * maratonsDays);
           
            decimal totalMeters = totalRunners * averageOfLaps * lengthOfTrack;
            decimal totalKM = totalMeters / 1000;
            decimal moneyRaicedFromMaraton = moneyToKM * totalKM;

            Console.WriteLine($"Money raised: {moneyRaicedFromMaraton:f2}");
        }
    }
}
