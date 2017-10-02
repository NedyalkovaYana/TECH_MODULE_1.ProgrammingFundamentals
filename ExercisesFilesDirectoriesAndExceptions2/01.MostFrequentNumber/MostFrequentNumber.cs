using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main(string[] args)
        {
            var numbers = File.ReadAllLines("input.txt");
            int[] nums = numbers.Select(int.Parse).ToArray();
            int count = 1, tempCount;
            int frequentNumber = nums[0];
            int tempNumber = 0;
            for (int i = 0; i < (nums.Length - 1); i++)
            {
                tempNumber = nums[i];
                tempCount = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (tempNumber == nums[j])
                    {
                        tempCount++;
                    }
                }
                if (tempCount > count)
                {
                    frequentNumber = tempNumber;
                    count = tempCount;
                }
            }

           
       
            File.WriteAllText("output.txt", frequentNumber.ToString());
        }
    }
}
