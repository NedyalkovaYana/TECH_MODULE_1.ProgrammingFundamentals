using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _02.Softuni_Coffee_Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            decimal totalSum = 0m;
            for (int i = 0; i < n; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                string[] date = Console.ReadLine().Split('/').ToArray();
                decimal capsulesCount = decimal.Parse(Console.ReadLine());

                int year = int.Parse(date[2]);
                int month = int.Parse(date[1]);

                int daysInMonth = DateTime.DaysInMonth(year, month);
                decimal result = (daysInMonth * capsulesCount) * pricePerCapsule;
                totalSum += result;
                Console.WriteLine($"The price for the coffee is: ${result:f2}");
            }
            Console.WriteLine($"Total: ${totalSum:f2}");
        }
    }
}
