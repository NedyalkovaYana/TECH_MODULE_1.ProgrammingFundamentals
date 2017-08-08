using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.WaterOverflow
{
    class WaterOverflow
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int capacity = 255;
            int capacityLeft = capacity;

            for (int i = 0; i < n; i++)
            {
                int litersToPour = int.Parse(Console.ReadLine());

                if (capacityLeft - litersToPour >= 0)
                {
                    capacityLeft -= litersToPour;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            int filled = capacity - capacityLeft;
            Console.WriteLine(filled);
        }
    }
}
