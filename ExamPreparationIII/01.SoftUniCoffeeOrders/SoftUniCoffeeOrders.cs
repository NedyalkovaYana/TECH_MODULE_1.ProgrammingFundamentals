using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.SoftUniCoffeeOrders
{
    class SoftUniCoffeeOrders
    {
        static void Main(string[] args)
        {
            decimal n = decimal.Parse(Console.ReadLine());
            decimal totalPrice = 0;
            for (decimal i = 0; i < n; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());               
                string[] date = Console.ReadLine().Split('/').ToArray();
                int month = int.Parse(date[1]);
                int year = int.Parse(date[2]);
                decimal dayInMonth = DateTime.DaysInMonth(year, month);               
                long capsulesCount = long.Parse(Console.ReadLine());
                decimal price = (dayInMonth * capsulesCount) * pricePerCapsule;
                totalPrice += price;
                Console.WriteLine($"The price for the coffee is: ${price:f2}");           
            }
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}
