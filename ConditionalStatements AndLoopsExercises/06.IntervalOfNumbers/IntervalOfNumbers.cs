using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.IntervalOfNumbers
{
    class IntervalOfNumbers
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            if (numberOne < numberTwo)
            {
                for (int i = numberOne; i <= numberTwo; i++)
                {
                    Console.WriteLine(i);
                }
            }        
            else if (numberOne > numberTwo)
            {
                for (int i = numberTwo; i <= numberOne; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
