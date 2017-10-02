using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.CharacterMultiplier
{
    class CharacterMultiplier
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string lineOne = input[0];
            string lineTwo = input[1];

            int minLength = Math.Min(lineOne.Length, lineTwo.Length);
            int sum = 0;

            for (int i = minLength - 1; i >= 0; i--)
            {
                sum += lineTwo[i] * lineOne[i];
            }
            string rest = String.Empty;

            if (lineOne.Length > lineTwo.Length)
            {
                rest = lineOne.Substring(minLength);
            }
            else
            {
                rest = lineTwo.Substring(minLength);
            }

            foreach (char item in rest)
            {
                sum += item;
            }
            Console.WriteLine(sum);
        }
    }
}
