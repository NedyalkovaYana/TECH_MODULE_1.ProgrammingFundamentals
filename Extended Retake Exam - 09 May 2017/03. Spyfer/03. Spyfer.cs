using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Spyfer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];
                int nextNumber = numbers[i + 1];
                int previousNumber = numbers[i - 1];

                if (i != 0 && i != numbers.Count - 1)
                {
                    int sumOfNeighbours = previousNumber + nextNumber;

                    if (currentNumber == sumOfNeighbours)
                    {
                        numbers.RemoveAt(i + 1);
                        numbers.RemoveAt(i - 1);
                        i = 0;
                    }
                }
                else if (i == 0 && currentNumber == nextNumber)
                {
                    numbers.RemoveAt(i + 1);
                    i = 0;
                }
                else if (i == numbers.Count - 1 && currentNumber == previousNumber)
                {
                    numbers.RemoveAt(i - 1);
                    i = 0;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
