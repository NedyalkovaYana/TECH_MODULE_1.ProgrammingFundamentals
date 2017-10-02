using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.RestaurantDiscount
{
    class RestaurantDiscount
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            decimal priceForHall = 0;
            decimal packagePrice = 0;
            decimal discount = 0;
            decimal totalPrice = 0;
            decimal totalDiscount = 0;
            decimal pricePerPerson = 0;
            string name = string.Empty;

            if (groupSize > 120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }

            switch (package)
            {
                case "Normal": packagePrice = 500; discount = 5; break;
                case "Gold": packagePrice = 750; discount = 10; break;
                case "Platinum": packagePrice = 1000; discount = 15; break;
            }

            if (groupSize <= 50) //Small Hall
            {
                name = "Small Hall";
                priceForHall = 2500;
                totalPrice = priceForHall + packagePrice;
                totalDiscount = totalPrice - ((totalPrice * discount) / 100);
                pricePerPerson = totalDiscount / groupSize;

                Console.WriteLine($"We can offer you the {name}");
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");

            }
            else if (groupSize > 50 && groupSize <= 100) // Terrace
            {
                name = "Terrace";
                priceForHall = 5000;
                totalPrice = priceForHall + packagePrice;
                totalDiscount = totalPrice - ((totalPrice * discount) / 100);
                pricePerPerson = totalDiscount / groupSize;

                Console.WriteLine($"We can offer you the {name}");
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }
            else if (groupSize > 100 && groupSize <= 120) // Great Hall
            {
                name = "Great Hall";
                priceForHall = 7500;
                totalPrice = priceForHall + packagePrice;
                totalDiscount = totalPrice - ((totalPrice * discount) / 100);
                pricePerPerson = totalDiscount / groupSize;

                Console.WriteLine($"We can offer you the {name}");
                Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
            }
        }
    }
}
