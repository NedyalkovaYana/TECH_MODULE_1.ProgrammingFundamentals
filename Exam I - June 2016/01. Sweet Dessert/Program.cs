using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sweet_Dessert
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal amountOfCash = decimal.Parse(Console.ReadLine());
            decimal numberOfGuests = decimal.Parse(Console.ReadLine());
            decimal priceOfOneBanana = decimal.Parse(Console.ReadLine());
            decimal priceOfOneEgg = decimal.Parse(Console.ReadLine());
            decimal priceOfBerriesKilo = decimal.Parse(Console.ReadLine());

            decimal priceForOneSet = (2 * priceOfOneBanana) + (4 * priceOfOneEgg) + (0.2m * priceOfBerriesKilo);

            decimal sets = Math.Ceiling(numberOfGuests / 6);
            decimal totalProductsPrice = sets * priceForOneSet;

            if (amountOfCash >= totalProductsPrice)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalProductsPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {(totalProductsPrice - amountOfCash):f2}lv more.");
            }
        }
    }
}
