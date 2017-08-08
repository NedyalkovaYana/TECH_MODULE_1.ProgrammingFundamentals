using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.NumberChecker
{
    class NumberChecker
    {
        static void Main(string[] args)
        {
            try
            {
                var number = long.Parse(Console.ReadLine());

                Console.WriteLine("integer");

            }

            catch (Exception)
            {
                Console.WriteLine("floating-point");
            }
        }
    }
}
