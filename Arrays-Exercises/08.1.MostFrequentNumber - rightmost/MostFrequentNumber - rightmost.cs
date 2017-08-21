using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08._1.MostFrequentNumber___rightmost
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int counter = 0;
            int longestOccurance = 0;
            int mostFrequentNumber = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        counter++;
                    }
                }
                if (counter > longestOccurance)
                {
                    longestOccurance = counter;
                    mostFrequentNumber = arr[i];
                }
            }
            Console.WriteLine(mostFrequentNumber);
        }
    }
}
