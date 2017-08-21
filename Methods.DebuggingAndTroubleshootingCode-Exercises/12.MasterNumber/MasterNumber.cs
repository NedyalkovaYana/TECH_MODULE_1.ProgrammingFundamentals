using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.MasterNumber
{
    class MasterNumber
    {
        static void Main(string[] args) // Broken Code
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (IsPaliondrome(i) && SumOfDigits(i) && 
                    ContainsEvenDigit(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool ContainsEvenDigit(int i)
        {
            bool isContainsEvenDigit = false;
            int num = i;
            while (i > 0)
            {
                int lastDigit = num % 10;
                num /= 10;

                if (lastDigit % 2 == 0)
                {
                    return true;
                }
            }
            return isContainsEvenDigit;
        }

        static bool SumOfDigits(int i)
        {
            bool isDevisibleBySeven = false;
            int num = i;
            int sumOfDigit = 0;
            while (num > 0)
            {
                int lastDigit = num % 10;
                sumOfDigit += lastDigit;
                num /= 10;
            }
            if (sumOfDigit % 7 == 0)
            {
                isDevisibleBySeven = true;
            }
            return isDevisibleBySeven;
        }

        private static bool IsPaliondrome(int num)
        {
            string sNum = num.ToString();
            for (int i = 0; i < sNum.Length; i++)
                if (sNum[i] != sNum[sNum.Length - 1 - i]) return false;
            return true;

        }
    }
}
