using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _02.ConvertFromBaseNToBase10
{
    class ConvertFromBaseNToBase10
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Trim().Split();
           
            int baseN = int.Parse(input[0]);
            char[] base10 = input[1].ToCharArray();
            BigInteger result = new BigInteger();
            
            for (int i = 0; i < base10.Length; i++)
            {
                int currentNum = (int)Char.GetNumericValue(base10[i]);
                result += currentNum * BigInteger.Pow(baseN, base10.Length - i - 1);
            }
            Console.WriteLine(result);
        }
    }
}
