using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.LargestCommonEnd
{
    class LargestCommonEnd
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(' ').ToArray();
            string[] secondArray = Console.ReadLine().Split(' ').ToArray();

            int lengthL = 0;
            int lengthR = 0;

            for (int i = 0; i < Math.Min(firstArray.Length, secondArray.Length); i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    lengthL++;
                }
                if (firstArray[firstArray.Length - i - 1] == secondArray[secondArray.Length - i - 1])
                {
                    lengthR++;
                }
            }
            if (lengthL > lengthR)
            {
                Console.WriteLine(lengthL);
            }
            else
            {
                Console.WriteLine(lengthR);
            }
        }
    }
}
