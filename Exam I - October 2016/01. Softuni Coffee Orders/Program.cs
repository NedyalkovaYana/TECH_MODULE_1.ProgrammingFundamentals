using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _01.Softuni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal ordersCount = decimal.Parse(Console.ReadLine());
            decimal orderPrice = 0m;
            decimal totalPrice = 0m;
            for (decimal i = 0; i < ordersCount; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                string[] date = Console.ReadLine().Split('/').ToArray();
                decimal day = decimal.Parse(date[0]);
                decimal month = decimal.Parse(date[1]);
                decimal year = decimal.Parse(date[2]); 
                decimal daysInMonth = DateTime.DaysInMonth((int)year, (int)month);
                decimal capsulesCount = decimal.Parse(Console.ReadLine());

                orderPrice = ((daysInMonth * capsulesCount) * pricePerCapsule);
                totalPrice += orderPrice;
                Console.WriteLine($"The price for the coffee is: ${orderPrice:f2}");
            }
            
            Console.WriteLine($"Total: ${totalPrice:f2}");
        }

        public static decimal CultureInfo { get; set; }
    }
}
