using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ChangeList
{
    class ChangeList
    {
        static void Main(string[] args)
        {
            List<long> nums = Console.ReadLine().Split(' ').Select(long.Parse).ToList();
            List<string> commands = Console.ReadLine().Split(' ').ToList();
            while (true)
            { 
                string value = commands[1];
                long firstInt = 0;
                Int64.TryParse(value, out firstInt);

                if ((commands[0] == "Odd") || (commands[0] == "Even"))
                {
                    break;
                }
                if (commands[0] == "Delete")
                {
                   
                    for (long i = 0; i <= nums.Count; i++)
                    {
                        nums.Remove(firstInt);
                    }                                                                   
                }
                if (commands[0] == "Insert")
                {
                    string valueTwo = commands[2];
                    long secondInt = 0;
                    Int64.TryParse(valueTwo, out secondInt);
                    nums.Insert((int)secondInt, firstInt);
                }

                commands = Console.ReadLine().Split(' ').ToList();

                if (commands[0] == "Odd")
                {
                    var oddNumbers = nums.Where(num => num % 2 != 0);
                    foreach (long i in oddNumbers)
                        Console.Write(i + " ");
                    Console.WriteLine();
                    return;
                }
                else if (commands[0] == "Even")
                {
                    var evenNumbers = nums.Where(num => num % 2 == 0);
                    foreach (long i in evenNumbers)
                        Console.Write(i + " ");
                    Console.WriteLine();
                    return;
                }
            }
        }
    }

}

