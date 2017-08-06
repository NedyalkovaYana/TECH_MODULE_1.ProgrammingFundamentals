using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ExactSumRealNumbers
{
    class SumNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal totalSum = 0m;
            for (int i = 0; i < n; i++)
            {
                decimal exactSum = decimal.Parse(Console.ReadLine());
                totalSum += exactSum;
            }
            Console.WriteLine(totalSum);
        }
    }
}
