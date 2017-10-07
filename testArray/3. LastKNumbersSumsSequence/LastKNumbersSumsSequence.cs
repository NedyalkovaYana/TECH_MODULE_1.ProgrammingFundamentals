using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.LastKNumbersSumsSequence
{
    class LastKNumbersSumsSequence
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int max = Math.Max(firstArray.Length, secondArray.Length);

            for (int i = 0; i < max; i++)
            {
                int sum = firstArray[i] + secondArray[i];
                Console.Write($"{sum} ");
            }
            Console.WriteLine();
        }
    }
}
