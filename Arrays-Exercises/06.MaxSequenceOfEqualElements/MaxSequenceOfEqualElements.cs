using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.MaxSequenceOfEqualElements
{
    class MaxSequenceOfEqualElements
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int startIndex = 0;
            int longestLenght = 1;
            int currentStartIndex = 0;
            int currentLenght = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] == arr[i-1])
                {
                    currentLenght++;
                    if (currentLenght > longestLenght)
                    {
                        longestLenght = currentLenght;
                        startIndex = currentStartIndex;
                    }
                }               
                else
                {
                    currentStartIndex = i;
                    currentLenght = 1;
                }
               
            }
            for (int i = startIndex; i < startIndex + longestLenght; i++)
            {

                Console.Write(arr[i] + " ");
            }
        }
    }
}
