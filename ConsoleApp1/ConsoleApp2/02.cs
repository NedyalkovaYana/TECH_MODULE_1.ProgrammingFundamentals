using System.Collections.Generic;
using System.Text;

namespace Exam
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            StringBuilder sb = new StringBuilder();
            var input = Console.ReadLine().Split(new char[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> divided = new List<string>();
            var commands = string.Empty;
            while ((commands = Console.ReadLine()) != "3:1")
            { 
                var cmdTokens = commands.Split(' ').ToList();
                var command = cmdTokens[0];

                if (command == "merge")
                {
                    var startIndex = int.Parse(cmdTokens[1].Trim());
                    var endIndex = int.Parse(cmdTokens[2].Trim());
                    if (startIndex < 0 || startIndex >= input.Count)
                    {
                        break;
                    }
                    for (int i = startIndex; i < endIndex; i++)
                    {
                        sb.Append(input[i]);
                    }
                }

                else if (command == "divide")
                {
                    var index = int.Parse(cmdTokens[1].Trim());
                    var partitition = int.Parse(cmdTokens[2].Trim());
                    if (index < 0 || index > input.Count)
                    {
                        break;
                    }
                    if (partitition < 0 || partitition > input.Count)
                    {
                        break;
                    }
                    for (int i = 0; i < input.Count; i++)
                    {
                        if (input[i] == input[index])
                        {
                            var lengthCurrentWord = input[i].Length;
                            var word = input[index];
                            var element = lengthCurrentWord / partitition;

                            for (int j = 0; j < partitition; j++)
                            {
                                var rez = word.Substring(0, element);
                                divided.Add(rez);
                                word = word.Substring(rez.Length);
                            }

                            input.Remove(word);
                            input.AddRange(divided);
                        }
                    }

                }
            }

            Console.WriteLine(sb.ToString());
        }
    }
}

