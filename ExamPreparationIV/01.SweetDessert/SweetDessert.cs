using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SweetDessert
{
    class SweetDessert
    {
        static void Main(string[] args)
        {
            decimal cash = decimal.Parse(Console.ReadLine());
            int numberOfguests = int.Parse(Console.ReadLine());
            decimal bananaPrice = decimal.Parse(Console.ReadLine());
            decimal eggsPrice = decimal.Parse(Console.ReadLine());
            decimal beriesPriceKG = decimal.Parse(Console.ReadLine());

           decimal sets = Math.Ceiling(numberOfguests / 6m);
            
            decimal priceForSet = (2 * bananaPrice) + (4 * eggsPrice) + ((decimal)0.2 * beriesPriceKG);
            decimal totalPrice = sets * priceForSet;

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
