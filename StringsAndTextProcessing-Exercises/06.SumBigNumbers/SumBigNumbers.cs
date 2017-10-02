using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SumBigNumbers
{
    class SumBigNumbers
    {
        static void Main(string[] args)
        {
            string numOne = Console.ReadLine();
            string numTwo = Console.ReadLine();

            StringBuilder sum = new StringBuilder();

            int n1 = numOne.Length;
            int n2 = numTwo.Length;

            int carry = 0;
            int n = (n1 > n2) ? n1 : n2;

            if (n1 >n2)
            {
                numTwo = numTwo.PadLeft(n1,'0'); 
            }
            else
            {
                numOne = numOne.PadLeft(n2, '0');
            }

            for (int i = n-1; i >= 0; i--)
            {
                int value = (carry + numOne[i] - 48 + numTwo[i] - 48) % 10;
                sum.Append(value);
                carry = (carry + numOne[i] - 48 + numTwo[i] - 48) / 10;
            }
            char[] c = sum.ToString().ToCharArray();
            Array.Reverse(c);
            Console.WriteLine(c);
        }
    }
}
