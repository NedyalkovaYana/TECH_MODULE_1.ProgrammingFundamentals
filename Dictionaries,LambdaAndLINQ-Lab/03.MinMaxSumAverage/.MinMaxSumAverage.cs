using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MinMaxSumAverage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var inputs = new List<int>();
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                inputs.Add(num);
            }
            Console.WriteLine($"Sum = {inputs.Sum()}");
            Console.WriteLine($"Min = {inputs.Min()}");
            Console.WriteLine("Max = {0}", inputs.Max());
            Console.WriteLine($"Average = {inputs.Average()}");
        }
    }
}
