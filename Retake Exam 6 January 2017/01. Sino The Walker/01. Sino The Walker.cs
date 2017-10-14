using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sino_The_Walker
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] startTime = Console.ReadLine().Split(':').Select(int.Parse).ToArray();
            long secondsToAdd = long.Parse(Console.ReadLine()) * long.Parse(Console.ReadLine());

            long seconds = startTime[2] + 60 * startTime[1] + 60 * 60 * startTime[0];

            seconds = seconds + secondsToAdd;

            long sec = seconds % 60;
            long min = (seconds / 60) % 60;
            long hours = (seconds / 60 / 60) % 24;

            Console.WriteLine($"Time Arrival: {hours:d2}:{min:d2}:{sec:d2}");

        }
    }
}
