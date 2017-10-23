using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Splinter_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal tripDistanceInMile = decimal.Parse(Console.ReadLine());
            decimal fuelTankCapacity = decimal.Parse(Console.ReadLine());
            decimal milesSpentInHeavyWinds = decimal.Parse(Console.ReadLine());


            decimal milesInNonHeavyWinds = tripDistanceInMile - milesSpentInHeavyWinds;
            decimal nonHeavyWindsConsumption = milesInNonHeavyWinds * 25; //liters
            decimal heavyWindsConsumption = milesSpentInHeavyWinds * (25m * 1.5m);
            decimal fuelConsumption = nonHeavyWindsConsumption + heavyWindsConsumption; //liters
            decimal tolerance = (fuelConsumption * 5)/100;
            decimal totalFuelConsumption = fuelConsumption + tolerance;
            decimal remainingFuel = fuelTankCapacity - totalFuelConsumption;

            if (remainingFuel >= 0)
            {
                Console.WriteLine($"Fuel needed: {totalFuelConsumption:f2}L");
                Console.WriteLine($"Enough with {remainingFuel:f2}L to spare!");
            }
            else
            {
                remainingFuel = Math.Abs(fuelTankCapacity - totalFuelConsumption);
                Console.WriteLine($"Fuel needed: {totalFuelConsumption:f2}L");
                Console.WriteLine($"We need {remainingFuel:f2}L more fuel.");
            }
        }
    }
}
