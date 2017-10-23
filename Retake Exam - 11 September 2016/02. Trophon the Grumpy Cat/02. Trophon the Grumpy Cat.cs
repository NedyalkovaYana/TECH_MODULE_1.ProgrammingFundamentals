using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _02.Trophon_the_Grumpy_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> nums = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            int index = int.Parse(Console.ReadLine());
            string breakalbleIndex = Console.ReadLine();
            string itemsToLookFor = Console.ReadLine();

            var leftSideNums = nums.Take(index);
            var rightSideNums = nums.Skip(index + 1);

            long entryPoints = nums[index];

            long sumLeftNums;
            long sumRightNums;

            if (breakalbleIndex == "cheap")
            {
                sumLeftNums = SumOfBrokenItems(leftSideNums.Where(x => x < entryPoints).ToList(), itemsToLookFor);
                sumRightNums = SumOfBrokenItems(rightSideNums.Where(a => a < entryPoints).ToList(), itemsToLookFor);

            }
            else
            {
                sumLeftNums = SumOfBrokenItems(leftSideNums.Where(a => a >= entryPoints).ToList(), itemsToLookFor);
                sumRightNums = SumOfBrokenItems(rightSideNums.Where(a => a >= entryPoints).ToList(), itemsToLookFor);
            }
            Console.WriteLine(sumRightNums > sumLeftNums ? $"Right - {sumRightNums}" : $"Left - { sumLeftNums}");
        }

        private static long SumOfBrokenItems(List<long> toList, string word)
        {
            switch (word)
            {
                case "positive":
                    return toList.Where(x => x > 0).Sum();
                case "negative":
                    return toList.Where(x => x < 0).Sum();
                    default:
                        return toList.Sum();                    
            } 
        }
    }
}
