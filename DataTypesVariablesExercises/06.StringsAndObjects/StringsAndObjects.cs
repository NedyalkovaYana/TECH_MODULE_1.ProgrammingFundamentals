using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main(string[] args)
        {
            string greeting = "Hello";
            string who = "World";
            object concatenation = "Hello World";
            Console.WriteLine($"{(string)concatenation}");
        }
    }
}
