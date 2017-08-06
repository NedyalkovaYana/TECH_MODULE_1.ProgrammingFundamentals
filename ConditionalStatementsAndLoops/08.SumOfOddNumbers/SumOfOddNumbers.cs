using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SumOfOddNumbers
{
    class SumOfOddNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int current = 1;
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(current);
                sum += current;             
                current += 2;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
