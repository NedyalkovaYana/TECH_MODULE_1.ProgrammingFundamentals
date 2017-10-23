using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _02.SoftUni_Water_Supplies
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalWater = double.Parse(Console.ReadLine());

            double[] bottlesForFill = Console.ReadLine().Split().Select(double.Parse).ToArray();

            int bottleCapacity = int.Parse(Console.ReadLine());
            bool reversedArray = false;

            if (totalWater % 2 != 0)
            {
                reversedArray = true;
                Array.Reverse(bottlesForFill);
            }
            int unfilledBottleIndex = -1;

            for (int i = 0; i < bottlesForFill.Length; i++)
            {
                double refill = bottleCapacity - bottlesForFill[i];
                if (totalWater > refill)
                {
                    bottlesForFill[i] += refill;
                    totalWater -= refill;
                }
                else
                {
                    bottlesForFill[i] += totalWater;
                    totalWater = 0;
                    if (bottlesForFill[i] < bottleCapacity)
                    {
                        unfilledBottleIndex = i;
                        break;
                    }
                }
            }
            if (unfilledBottleIndex == -1)
            {
                Console.WriteLine("Enough water!");
                Console.WriteLine($"Water left: {totalWater}l");
            }
            else
            {
                List<int> unFilledBottleIndex = new List<int>();
                for (int i = unfilledBottleIndex; i < bottlesForFill.Length; i++)
                {
                    if (!reversedArray)
                    {
                        unFilledBottleIndex.Add(i);
                    }
                    else
                    {
                        unFilledBottleIndex.Add(bottlesForFill.Length- 1 - i);
                    }
                }
                double waterStorage = 0;
                for (int i = unfilledBottleIndex; i < bottlesForFill.Length; i++)
                {
                    waterStorage += bottleCapacity - bottlesForFill[i];
                }

                Console.WriteLine("We need more water!");
                Console.WriteLine("Bottles left: {0}", unFilledBottleIndex.Count);
                Console.WriteLine("With indexes: {0}", string.Join(", ", unFilledBottleIndex));
                Console.WriteLine("We need {0} more liters!", waterStorage);
            }

        }
    }
}
