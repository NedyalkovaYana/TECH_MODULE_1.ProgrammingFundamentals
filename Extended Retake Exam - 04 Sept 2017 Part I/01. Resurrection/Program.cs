using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.Resurrection
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal amountOfPhoenixes = decimal.Parse(Console.ReadLine());

            for (decimal i = 0; i < amountOfPhoenixes; i++)
            {
                decimal totalLengthOfBody = decimal.Parse(Console.ReadLine());
                decimal totalWidthOfBody = decimal.Parse(Console.ReadLine());
                decimal lengthOfOneWing = decimal.Parse(Console.ReadLine());

                decimal totalYearsForReincarnat = (totalLengthOfBody * totalLengthOfBody) * (totalWidthOfBody + (2 * lengthOfOneWing));

                Console.WriteLine(totalYearsForReincarnat);

            }
        }
    }
}
