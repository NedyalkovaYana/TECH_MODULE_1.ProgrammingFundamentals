using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sino_The_Walker
{
    class Sino
    {
        static void Main(string[] args)
        {
            DateTime leaves = DateTime.Parse(Console.ReadLine());
            double steps = double.Parse(Console.ReadLine()) % 86400;//steps in seconds
            //махаме цели дни, ако някой се прави на интересен да ни ги подава като вход
            double timeInSeconds = double.Parse(Console.ReadLine()) % 86400;//time in seconds for each step
            double allTime = steps * timeInSeconds / 3600;//in seconds
            Console.WriteLine("Time Arrival: " + (leaves.AddHours(allTime)).TimeOfDay);

        }
    }
}
