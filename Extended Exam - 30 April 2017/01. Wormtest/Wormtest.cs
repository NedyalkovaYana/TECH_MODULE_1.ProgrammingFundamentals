using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Wormtest
{
    class Wormtest
    {
        static void Main(string[] args)
        {
            decimal wormLengthInMeters = (decimal.Parse(Console.ReadLine())) * 100;
            decimal wormWidthInCentimeters = decimal.Parse(Console.ReadLine());

            decimal remainder = wormLengthInMeters % wormWidthInCentimeters;

            if (remainder == 0)
            {
                Console.WriteLine($"{(wormWidthInCentimeters * wormLengthInMeters):f2}");
            }
            else
            {
                if (wormLengthInMeters % wormWidthInCentimeters == 0 || wormWidthInCentimeters == 0)
                {
                    decimal product = wormWidthInCentimeters * wormLengthInMeters;
                    Console.WriteLine($"{product:f2}");
                }
                decimal presentage = (wormLengthInMeters/wormWidthInCentimeters)*100;
                Console.WriteLine($"{presentage:f2}%");
            }

        }
    }
}
