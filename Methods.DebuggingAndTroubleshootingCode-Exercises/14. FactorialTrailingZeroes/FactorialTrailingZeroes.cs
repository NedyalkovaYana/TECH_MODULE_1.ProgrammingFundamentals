using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _14.FactorialTrailingZeroes
{
    class FactorialTrailingZeroes
    {
       
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            BigInteger factoriel = 1;

            for (long i = n; i >= 1; i--)
            {
                factoriel *= i;
            }

               TrailingZeroes(factoriel);
        }
       
        static void TrailingZeroes(BigInteger factoriel)
        {
            
            BigInteger number = factoriel;
            int countZeros = 0;
            while (number % 10 == 0)
            {
                number /= 10;
                countZeros++;                   
 
            }
            Console.WriteLine(countZeros);
        }
    }
}
