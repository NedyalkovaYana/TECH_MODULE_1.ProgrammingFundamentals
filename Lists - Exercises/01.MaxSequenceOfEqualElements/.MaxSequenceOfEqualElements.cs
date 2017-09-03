using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int currenStart = 0;
            int currentLength = 1;
            int bestStart = 0;
            int bestLength = 0;

            for (int i = 1; i < nums.Count; i++)
            {
                if (nums[i] == nums[i - 1])
                {                
                    currentLength++;
                    if (currentLength > bestLength)
                    {
                        bestStart = currenStart;
                        bestLength = currentLength;
                    }
                }              
                else
                {
                    currenStart = i;
                    currentLength = 1;
                }
            }
            for (int i = bestStart; i < bestStart + bestLength; i++)
            {
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
