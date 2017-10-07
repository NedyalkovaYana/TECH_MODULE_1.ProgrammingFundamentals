using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.CommandInterpreter
{
    class CommandInterpreter
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            while (true)
            {
                string[] command = Console.ReadLine().Split(' ').ToArray();
                string instruction = command[0];
                if (instruction == "end")
                {
                    break;
                }

                int start = 0;
                int count = 0;
                
                if (instruction == "reverse" || instruction == "sort")
                {
                    start = int.Parse(command[2]);
                    count = int.Parse(command[4]);

                    if (start < 0 || start > list.Count - 1 || count + start > list.Count || count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    else
                    {
                        list = ProcessString(list, start, count, instruction);
                    }
                }
                else
                {
                     count = int.Parse(command[1]);
                    if (count < 0)
                    {
                        Console.WriteLine("Invalid input parameters.");
                    }
                    else
                    {
                        list = Roll(list, count, instruction);
                    }
                }
            }
            Console.WriteLine($"[{string.Join(", ", list)}]");
        }

        static List<string> Roll(List<string> list, int count, string instruction)
        {
            count = count % list.Count;
            for (int i = 0; i < count; i++)
            {
                List<string> toRoll = new List<string>();
                List<string> toMove = new List<string>();

                if (instruction == "rollRight")
                {
                    toRoll = list.Take(list.Count() - 1).ToList();
                    toMove = list.Skip(toRoll.Count()).ToList();

                }
                else
                {
                    toRoll = list.Take(1).ToList();
                    toMove = list.Skip(1).ToList();
                }

                List<string> temp = new List<string>();
                temp.AddRange(toMove);
                temp.AddRange(toRoll);
                list = temp;           
            }
            return list;
        }

        static List<string> ProcessString(List<string> list, int start, int count, string instruction)
        {
            List<string> leftPart = list.Take(start).ToList();
            List<string> richtPart = list.Skip(start + count).ToList();
            List<string> toTreat = list.Skip(start).Take(count).ToList();

            if (instruction == "reverse")
            {
                toTreat.Reverse();
            }
            else if (instruction == "sort")
            {
                toTreat.Sort();
            }
            List<string> treat = new List<string>();
            treat.AddRange(leftPart);
            treat.AddRange(toTreat);
            treat.AddRange(richtPart);

            return treat;
        }
    }
}
