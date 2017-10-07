using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ArrayManipulator2
{
    class ArrayManipulator2
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            while (true)
            {
                var line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }
                var tokens = line.Split();
                var command = tokens[0];
                if (command == "exchange")
                {
                    var index = int.Parse(tokens[1]);
                    arr = ExchangeElements(arr, index);
                }
                else if (command == "max" || command == "min")
                {
                    var evenOrOdd = tokens[1];
                    FindIndexOfMinOrMaxEvenOrOddElement(arr, evenOrOdd, command);
                }
                else if (command == "first" || command == "last")
                {
                    var count = int.Parse(tokens[1]);
                    var evenOrOdd = tokens[2];
                    FindFirstOrLastEvenOrOddElementsCount(arr, command, count, evenOrOdd);
                }
            }
            Console.WriteLine($"[{string.Join(", ", arr)}]");
        }

        static void FindFirstOrLastEvenOrOddElementsCount(int[] arr, string command, int count, string evenOrOdd)
        {
            if (count > arr.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            var parity = evenOrOdd == "even" ? 0 : 1;
            var evenOrOddElements = arr
                .Where(a => a % 2 == parity)
                .ToArray();

            var firstOrLastEvenOrOddElements = new List<int>();
            if (command == "first")
            {
                firstOrLastEvenOrOddElements.AddRange(evenOrOddElements.Take(count));

            }
            else
            {
                firstOrLastEvenOrOddElements.AddRange(evenOrOddElements.Skip(arr.Length - count));
            }
            Console.WriteLine($"[{string.Join(", ", firstOrLastEvenOrOddElements)}]");
        }

        static void FindIndexOfMinOrMaxEvenOrOddElement(int[] arr, string evenOrOdd, string command)
        {
            var parity = evenOrOdd == "even" ? 0 : 1;
            var evenOrOddElemenets = arr.Where(a => a % 2 == parity).ToArray();
            if (evenOrOddElemenets.Any())//или .Count == 0)
            {
                Console.WriteLine("No matches");
                return;
            }
            var minOrMaxElement = 0;
            if (command == "min")
            {
                minOrMaxElement = evenOrOddElemenets.Min();
            }
            else
            {
                minOrMaxElement = evenOrOddElemenets.Max();
            }
            var index = Array.LastIndexOf(arr, minOrMaxElement);
            Console.WriteLine(index);
        }

        static int[] ExchangeElements(int[] arr, int index)
        {
            var isValidIndex = index >= 0 && index < arr.Length;
            if (!isValidIndex)
            {
                Console.WriteLine("Invalid index");
                return arr;
            }
            var leftPart = arr.Take(index + 1).ToArray();
            var rightPart = arr.Skip(leftPart.Count()).ToArray();
            var concatenated = rightPart.Concat(leftPart).ToArray();
           return concatenated;
        }
    }
}
