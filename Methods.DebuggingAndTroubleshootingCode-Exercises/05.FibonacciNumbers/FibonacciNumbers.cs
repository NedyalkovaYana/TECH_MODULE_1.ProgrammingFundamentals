using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(GetFibonacciNumbers(n)); 
        }

        static long GetFibonacciNumbers(long n)
        {
            double sqrt5 = Math.Sqrt(5);
            double p1 = (1 + sqrt5) / 2;
            double p2 = -1 * (p1 - 1);


            double n1 = Math.Pow(p1, n + 1);
            double n2 = Math.Pow(p2, n + 1);
            return (long)((n1 - n2) / sqrt5);
          
        }
    }
}
