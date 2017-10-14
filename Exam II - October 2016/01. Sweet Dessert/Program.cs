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
            decimal cash = decimal.Parse(Console.ReadLine());
            int numberOfGuest = int.Parse(Console.ReadLine());
            decimal bananaPrice = decimal.Parse(Console.ReadLine());
            decimal eggPrice = decimal.Parse(Console.ReadLine());
            decimal priceBeriesForKilo = decimal.Parse(Console.ReadLine());

            decimal priceforOneSet = (2 * bananaPrice) + (4 * eggPrice) + (0.2m * priceBeriesForKilo);

            decimal totalSet = Math.Ceiling((numberOfGuest / 6m));

            decimal totalPrice = priceforOneSet * totalSet;

            if (cash >= totalPrice)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {(totalPrice - cash):f2}lv more.");
            }
        }
    }
}
