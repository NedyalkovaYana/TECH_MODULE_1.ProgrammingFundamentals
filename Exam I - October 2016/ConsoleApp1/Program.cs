using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            while (true)
            {
                string[] commands = Console.ReadLine().Split(' ').ToArray();
                if (commands[0] == "print")
                {
                    Console.WriteLine($"[{string.Join(", ", numbers)}]");
                    break;
                }

                switch (commands[0])
                {
                    case "add":
                        int index = int.Parse(commands[1]);
                        int element = int.Parse(commands[2]);
                        numbers.Insert((int)index, element);
                        break;
                    case "addMany":
                        index = int.Parse(commands[1]);
                        for (int i = commands.Length - 1; i >= 2; i--)
                        {
                            int elements = int.Parse(commands[i]);
                            numbers.Insert((int)index, elements);
                        }
                        break;
                    case "contains":
                        element = int.Parse(commands[1]);
                        if (numbers.Contains(element))
                        {
                            Console.WriteLine(numbers.IndexOf(element));
                        }
                        else
                        {
                            Console.WriteLine(-1);
                        }
                        break;
                    case "remove":
                        index = int.Parse(commands[1]);
                        numbers.RemoveAt((int)index);
                        break;
                    case "shift":

                        int position = int.Parse(commands[1]);
                        while (position > 0)
                        {
                            int first = numbers[0];
                            numbers.RemoveAt(0);
                            numbers.Add(first);
                            position--;

                        }
                        break;
                    case "sumPairs":
                        List<int> result = new List<int>();
                        foreach (var item in numbers)
                        {
                            result.Add(item);
                        }
                        for (int i = 0; i < numbers.Count/2; i++)
                        {
                            result[i] = result[i] + result[i + 1];
                            result.RemoveAt(i + 1);
                        }
                       numbers = result;
                        break;
                }
            }
        }
    }
}