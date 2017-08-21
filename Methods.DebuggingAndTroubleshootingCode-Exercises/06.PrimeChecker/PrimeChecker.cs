using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.PrimeChecker
{
    class PrimeChecker
    {
        static void Main(string[] args)
        {

            long number = long.Parse(Console.ReadLine());
            bool isPrime = IsPrime(number);
            Console.WriteLine(isPrime);
        }

        static bool IsPrime(long number)
        {
            if (number == 0 || number == 1)
            {
                return false;
            }
            for (long divider = 2; divider <= Math.Sqrt(number); divider++)
            {
                if (number % divider == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
