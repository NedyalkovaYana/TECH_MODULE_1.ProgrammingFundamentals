using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.ChooseADrink2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string personType = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            switch (personType)
            {
                case "Athlete":
                    double price = quantity * 0.70;
                    Console.WriteLine($"The {personType} has to pay {price:f2}.");
                    break;

                case "Businessman":
                case "Businesswoman":
                    price = quantity * 1.00;
                    Console.WriteLine($"The {personType} has to pay {price:f2}.");
                    break;

                case "SoftUni Student":
                    price = quantity * 1.70;
                    Console.WriteLine($"The {personType} has to pay {price:f2}.");            
                    break;

                default:
                    price = quantity * 1.20;
                    Console.WriteLine($"The {personType} has to pay {price:f2}.");
                    break;
            }
        }
    }
}
