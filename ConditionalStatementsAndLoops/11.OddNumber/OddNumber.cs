using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.OddNumber
{
    class OddNumber
    {
        static void Main(string[] args)
        {
            int n;

            for (int i = 1; i <=10; i++)
            {
                n = Math.Abs(int.Parse(Console.ReadLine()));
                if (n % 2 == 0)
                {
                    Console.WriteLine("Please write an odd number.");
                }
                else
                {
                    Console.WriteLine($"The number is: {n}");
                    break;
                }
            }
           
        }
    }
}
