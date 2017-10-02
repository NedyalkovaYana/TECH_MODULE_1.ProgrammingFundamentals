using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine();

            var result = new string(words.Reverse().ToArray());
            Console.WriteLine(result);
        }
    }
}
        