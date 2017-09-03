using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _03.BigFactorial
{
    class BigFactorial
    {
        static void Main(string[] args)
        {
            var number = BigInteger.Parse(Console.ReadLine());
            BigInteger result = 1;
            for (int i = 2; i <= number; i++)
            {
                result = result * i;
            }
            Console.WriteLine(result);
        }
    }
}
