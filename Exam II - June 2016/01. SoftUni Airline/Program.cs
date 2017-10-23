using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SoftUni_Airline
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersOfFlight = int.Parse(Console.ReadLine());
            decimal totalProfit = 0m;
            for (int i = 0; i < numbersOfFlight; i++)
            {
                decimal adultPassengersCount = decimal.Parse(Console.ReadLine());
                decimal adultTicketPrice = decimal.Parse(Console.ReadLine());
                decimal youthPassengersCount = decimal.Parse(Console.ReadLine());
                decimal youthTicketPrice = decimal.Parse(Console.ReadLine());
                decimal fuelPricePerHour = decimal.Parse(Console.ReadLine());
                decimal fuelConsumptionPerHour = decimal.Parse(Console.ReadLine());
                decimal flightDuration = decimal.Parse(Console.ReadLine());

                decimal income = (adultPassengersCount * adultTicketPrice) +
                                        (youthPassengersCount * youthTicketPrice);

                decimal expenses = flightDuration * fuelConsumptionPerHour * fuelPricePerHour;

                decimal profit = income - expenses;

                if (income >= expenses)
                {
                    Console.WriteLine($"You are ahead with {profit:f3}$.");
                }
                else
                {
                    Console.WriteLine($"We've got to sell more tickets! We've lost {profit:f3}$.");
                }
                totalProfit += profit;
            }
            Console.WriteLine($"Overall profit -> {totalProfit:f3}$.");
            Console.WriteLine($"Average profit -> {(totalProfit/numbersOfFlight):f3}$.");
        }
    }
}
