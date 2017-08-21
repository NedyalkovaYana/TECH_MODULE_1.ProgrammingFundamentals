using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _13.Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            BigInteger factoriel = 1;

            for (long i = n; i >= 1; i--)
            {
                factoriel *= i;
            }
            Console.WriteLine(factoriel);
        }
    }
}
