using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.GrabAndGo
{
    class GrabAndGo
    {
        static void Main(string[] args)
        {
            int[] arrayNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            long sum = 0;

            for (int pos = arrayNumbers.Length - 1; pos >= 0; pos--)
            {
                if (arrayNumbers[pos] == n)
                {
                    for (int i = 0; i < pos; i++)
                    {
                        sum += arrayNumbers[i];
                    }
                    break;
                }
            }

            if (sum == 0)
            {
                Console.WriteLine("No occurrences were found!");
            }
            else
            {
                Console.WriteLine(sum);
            }
        }
    }
}
