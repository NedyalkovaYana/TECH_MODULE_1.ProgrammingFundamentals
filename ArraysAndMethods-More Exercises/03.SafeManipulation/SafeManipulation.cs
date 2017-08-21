using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SafeManipulation
{
    class SafeManipulation
    {
        static void Main(string[] args)
        {
            string[] arr = Console.ReadLine().Split().ToArray();

            string[] commands = Console.ReadLine().Split();

            while (commands[0] != "END")
            {
                if(commands[0] == "Reverse")
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
                commands = Console.ReadLine().Split();
            }
   
            Console.WriteLine(string.Join(", ", arr));
        }
        private static void Replace(string[] arr, string stringIndex, string newString)
        {
            int len = arr.Length;
            int index = int.Parse(stringIndex);
            if (index > len || index < 0)
            {
                Console.WriteLine("Invalid input!");               
            }
            else
            {
                arr[index] = newString;
            }          
        }
    }
}
