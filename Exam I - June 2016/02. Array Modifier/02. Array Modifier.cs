using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _02.Array_Modifier
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] array = Console.ReadLine().Split().Select(long.Parse).ToArray();

            string inputCommand = Console.ReadLine();
            while (inputCommand != "end")
            {
                string[] commands = inputCommand.Split();

                if (commands[0] == "swap")
                {
                    long index1 = long.Parse(commands[1]);
                    long index2 = long.Parse(commands[2]);

                    var temp = array[index2];
                    array[index2] = array[index1];
                    array[index1] = temp;
                }
                if (commands[0] == "multiply")
                {
                    long index1 = long.Parse(commands[1]);
                    long index2 = long.Parse(commands[2]);

                    array[index1] = array[index1] * array[index2];
                    
                }
                if (commands[0] == "decrease")
                {
                    for (int i = 0; i < array.Length; i++)
                    {
                        array[i] -= 1;
                    }                 
                }
                inputCommand = Console.ReadLine();
            }
            Console.WriteLine(string.Join(", ", array));
        }
    }
}
