using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.PrintPartOfASCIITable
{
    class PrintPartOfASCIITable
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            for (int i = startNumber; i <= endNumber; i++)
            {
                string asciiChar = ((char)i).ToString();

                Console.Write(asciiChar + " ");
            }
        }
    }
}
