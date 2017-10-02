using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MultiplyBigNumber
{
    class MultiplyBigNumber
    {
        static void Main(string[] args)
        {
            string numOne = Console.ReadLine();
            string numTwo = Console.ReadLine();
            Console.WriteLine(Add(numOne, numTwo));
        }

        private static bool Add(string numOne, string numTwo)
        {
            int maxLength = Math.Max(numOne.Length, numTwo.Length);
            numOne = numOne.PadLeft(maxLength + 1, '0');
            numTwo = numTwo.PadLeft(maxLength + 1, '0');

            int[] arr1 = 
                numOne.Select(a => int.Parse(a.ToString())).ToArray();
            int[] arr2 =
                numTwo.Select(b => int.Parse(b.ToString())).ToArray();
            int[] sum = new int[arr1.Length];

            int carry = 0;
            for (int i = sum.Length - 1; i >= 0; i--)
            {
                int total = arr1[i] + arr2[i] + carry;
                sum[i] = total % 10;
                if (total > 9)
                {
                    carry = 1;
                }
                else
                {
                    carry = 0;
                }
            }
            
            return string.Join("", sum.SkipWhile(z => z != 0));
        }
    }
}
