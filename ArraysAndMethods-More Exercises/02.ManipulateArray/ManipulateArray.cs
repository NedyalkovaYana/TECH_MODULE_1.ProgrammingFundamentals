using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ManipulateArray
{
    class ManipulateArray
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split().ToArray();

            int followingNumbersOfLine = int.Parse(Console.ReadLine());

            for (int i = 0; i < followingNumbersOfLine; i++)
            {
                string[] commands = Console.ReadLine().Split();

                if (commands[0] == "Reverse")
                {
                    Array.Reverse(arr);
                }
                else if (commands[0] == "Distinct")
                {
                    arr = arr.Distinct().ToArray();
                }
                else if (commands[0] == "Replace")
                {
                    Replace(arr, commands[1], commands[2]);
                }
            }
            Console.WriteLine(string.Join(", ", arr));
        }
        private static void Replace(string[] arr, string stringIndex, string newString)
        {
            int index = int.Parse(stringIndex);
            arr[index] = newString;
        }

    }
}
