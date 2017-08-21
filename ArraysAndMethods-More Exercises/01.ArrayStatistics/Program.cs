using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ArrayStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            // Първи работещ вариант

            //var arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //var max = int.MinValue;
            //var min = int.MaxValue;
            //var sum = 0;
            //double average = 1.0;
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    var currentNum = arr[i];
            //    if (currentNum > max)
            //    {
            //        max = currentNum;
            //    }
            //    if (currentNum < min)
            //    {
            //        min = currentNum;
            //    }
            //    sum += currentNum;
            //    average = (double)sum / arr.Length;
            //}
            //Console.WriteLine($"Min = {min}");
            //Console.WriteLine($"Max = {max}");
            //Console.WriteLine($"Sum = {sum}");
            //Console.WriteLine($"Average = {average}");

            //Втори работещ вариант

            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();

            nums.Min();
            nums.Max();
            nums.Sum();
            nums.Average();
            Console.WriteLine($"Min = {nums.Min()}\nMax = {nums.Max()}\nSum = {nums.Sum()}\nAverage = {nums.Average()}");
        }
    }
}
