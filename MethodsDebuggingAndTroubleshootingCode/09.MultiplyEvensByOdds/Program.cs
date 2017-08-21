using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Math.Abs(int.Parse(Console.ReadLine()));
            int sum = GetMultipleOfEvensAndOdds(n);
            Console.WriteLine(sum);
        }

        static int GetMultipleOfEvensAndOdds(int n)
        {
            int sumEventDigits = GetSumOfEvenDigits(n);
            int sumOddDigits = GetSumOddDigits(n);
            return sumEventDigits * sumOddDigits;


        }

        static int GetSumOddDigits(int n)
        {
            int sumOdd = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 != 0)
                {
                    sumOdd += lastDigit;
                }
                n /= 10;
            }
            return sumOdd;
        }

        static int GetSumOfEvenDigits(int n)
        {
            int sumEven = 0;
            while (n > 0)
            {
                int lastDigit = n % 10;
                if (lastDigit % 2 == 0)
                {
                    sumEven += lastDigit;
                }
                n /= 10;
            }
            return sumEven;
        }
    }
}
