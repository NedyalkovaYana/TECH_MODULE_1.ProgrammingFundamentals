using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _02.Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)

        {
            var numbers = Console.ReadLine().Split(new char[]{' '}, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            while (true)
            {
                string[] commands = Console.ReadLine().ToLower().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (commands[0] == "end")
                {
                    break;
                }

                switch (commands[0])
                {
                    case "exchange":
                        int index = int.Parse(commands[1]);

                        if (index > numbers.Count)
                        {
                            Console.WriteLine("Invalid index");                          
                        }
                        else
                        {
                            var leftSide = numbers.Take(index + 1);
                            var rightSide = numbers.Skip(index + 1);

                            numbers = rightSide.Concat(leftSide).ToList();
                        }
                        break;
                    case "max":
                        try
                        {

                            if (commands[1] == "even") // max even
                            {
                                var evenNumber = numbers.Where(a => a % 2 == 0).ToList();
                                var maxValue = evenNumber.Max();
                                var maxIndex = numbers.ToList().IndexOf(maxValue);
                                Console.WriteLine(maxIndex);
                            }
                            else // max odd
                            {
                                var oddNumber = numbers.Where(a => a % 2 != 0).ToList();
                                var minValue = oddNumber.Max();
                                var minIndex = numbers.ToList().IndexOf(minValue);
                                Console.WriteLine(minIndex);
                            }
                            break;
                        }
                        catch (InvalidOperationException)
                        {
                            Console.WriteLine("No matches");
                            break;
                        }
                    case "min":
                        try
                        {
                            if (commands[1] == "even")
                            {
                                var evenNumbers = numbers.Where(a => a % 2 == 0);
                                var minEven = evenNumbers.Min();
                                var minIndex = numbers.ToList().IndexOf(minEven);
                                Console.WriteLine(minIndex);
                            }
                            else
                            {
                                var oddNumbers = numbers.Where(a => a % 2 != 0);
                                var minOdd = oddNumbers.Min();
                                var minOddIndex = numbers.ToList().IndexOf(minOdd);
                                Console.WriteLine(minOddIndex);
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("No matches");
                           
                        }
                        break;
                    //list.LastIndexOf(list.Max())
                    case "first":
                        int count = int.Parse(commands[1]);
                        if (count > numbers.Count || count < 0)
                        {
                            Console.WriteLine("Invalid count");
                            break;
                        }
                        if (commands[2] == "even")
                        {
                            var result = numbers.Where(a => a % 2 == 0).Take(count);
                            Console.WriteLine($"[{string.Join(", ", result)}]");
                        }
                        else
                        {
                            var result = numbers.Where(a => a % 2 != 0).Take(count);
                            Console.WriteLine($"[{string.Join(", ", result)}]");
                        }
                        break;
                    case "last":
                         count = int.Parse(commands[1]);
                        if (count > numbers.Count || count < 0)
                        {
                            Console.WriteLine("Invalid count");
                            break;
                        }
                        numbers.Reverse();
                        if (commands[2] == "even")
                        {
                            var result = numbers.Where(a => a % 2 == 0).Take(count).ToList();
                            if (result.Count == 0)
                            {
                                Console.WriteLine("[]");
                            }
                            else
                            {
                                Console.WriteLine($"[{string.Join(", ", result)}]");
                            }                           
                        }
                        else
                        {
                            var result = numbers.Where(b => b % 2 != 0).Take(count).ToList();
                            if (result.Count == 0)
                            {
                                Console.WriteLine("[]");
                            }
                            else
                            {
                                Console.WriteLine($"[{string.Join(", ", result)}]");
                            }
                        }
                        numbers.Reverse();
                        break;
                }
 
            }
            Console.WriteLine($"[{string.Join(", ", numbers)}]");

        }
    }
}
