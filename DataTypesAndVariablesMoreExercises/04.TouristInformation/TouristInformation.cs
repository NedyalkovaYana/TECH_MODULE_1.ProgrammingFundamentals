using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.TouristInformation
{
    class TouristInformation
    {
        static void Main(string[] args)
        {
            string imperialUnits = Console.ReadLine();
            double value = double.Parse(Console.ReadLine());
            double sum = 0;
            string convertedImperal = String.Empty;
            switch (imperialUnits)
            {
                case "miles": sum = value * 1.6; convertedImperal = "kilometers"; break;
                case "inches": sum = value * 2.54; convertedImperal = "centimeters"; break;
                case "feet": sum = value * 30; convertedImperal = "centimeters"; break;
                case "yards": sum = value * 0.91; convertedImperal = "meters"; break;
                case "gallons": sum = value * 3.8; convertedImperal = "liters"; break;
            }
            Console.WriteLine($"{value} {imperialUnits} = {sum:f2} {convertedImperal}");
        }
    }
}
