using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.ConvertFromBase10ToBaseN
{
    class ConvertFromBase10ToBaseN
    {
        static void Main(string[] args)
        {
            List<BigInteger> nums = new List<BigInteger>();
            nums = Console.ReadLine().Split(' ').Select(BigInteger.Parse).ToList();
            int n = (int)nums[0];
            BigInteger number = nums[1];
            BigInteger remainder;

            string rezult = null;
            if (n >= 2 && n <= 10)
            {
                while (number > 0)
                {
                    remainder = number % n;
                    number /= n;
                    rezult = remainder.ToString() + rezult;
                }
                Console.WriteLine(rezult);
            }
            else
            {
                Console.WriteLine(0);
            }
        }
    }
}
