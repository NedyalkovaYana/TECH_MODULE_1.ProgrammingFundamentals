using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.CountTheIntegers
{
    class CountTheIntegers
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int count = 0;

            int number;
            while (int.TryParse(input, out number))
            {
                count++;
                input = Console.ReadLine();
            }

            Console.WriteLine(count);
        }
    }
}
