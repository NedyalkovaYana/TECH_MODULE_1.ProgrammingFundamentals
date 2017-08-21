using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RotateAndSum
{
    class RotateAndSum
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());

            int[] sumRotatedNumbers = new int[nums.Length];
            for (int i = 0; i < k; i++)
            {
                int[] rotationNumbers = new int[nums.Length];
                rotationNumbers[0] = nums[nums.Length - 1];
                for (int j = 1; j < nums.Length; j++)
                {
                    rotationNumbers[j] = nums[j - 1];
                }
                for (int c = 0; c < nums.Length; c++)
                {
                    sumRotatedNumbers[c] += rotationNumbers[c];                   
                }
                nums = rotationNumbers;
            }
            Console.WriteLine(string.Join(" ", sumRotatedNumbers));
        }  
    }
}
