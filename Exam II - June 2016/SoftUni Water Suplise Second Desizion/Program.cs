using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUni_Water_Suplise_Second_Desizion
{
    class Program
    {
        static void Main(string[] args)
        {
            double water = int.Parse(Console.ReadLine());
            var bottles = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            double capacity = int.Parse(Console.ReadLine());
            var bottlesLeft = new List<int>();
            double waterNeeded = 0;

            if (water % 2 == 0)
            {
                for (int i = 0; i < bottles.Count; i++)
                {
                    double currentRefill = capacity - bottles[i];

                    if (water > currentRefill)
                    {
                        water -= currentRefill;
                    }
                    else
                    {
                        waterNeeded += currentRefill - water;
                        water = 0;
                        bottlesLeft.Add(i);
                    }
                }
            }
            else  //water is odd, start from Length
            {
                for (int i = bottles.Count - 1; i >= 0; i--)
                {
                    double currentRefill = capacity - bottles[i];
                    if (water > currentRefill)
                    {
                        water -= currentRefill;
                    }
                    else
                    {
                        waterNeeded += currentRefill - water;
                        water = 0;
                        bottlesLeft.Add(i);
                    }
                }
            }
            // Print result
            if (waterNeeded == 0)
            {
                Console.WriteLine("Enough water!");
                Console.WriteLine($"Water left: {water}l.");
            }
            else
            {
                Console.WriteLine("We need more water!");
                Console.WriteLine("Bottles left: {0}", bottlesLeft.Count);
                Console.WriteLine("With indexes: {0}", string.Join(", ", bottlesLeft));
                Console.WriteLine($"We need {waterNeeded} more liters!");
            }
        }
    }
}
