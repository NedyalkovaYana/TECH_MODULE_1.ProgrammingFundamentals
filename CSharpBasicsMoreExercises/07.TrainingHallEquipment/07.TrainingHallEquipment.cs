using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.TrainingHallEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberItemsToBuy = int.Parse(Console.ReadLine());
            double subtotal = 0;
            for (int i = 1; i <= numberItemsToBuy; i++)
            {
                string itemName = Console.ReadLine().ToLower();
                double itemPrice = double.Parse(Console.ReadLine());
                int itemCount = int.Parse(Console.ReadLine());
                
                if (itemCount > 1)
                {
                    Console.WriteLine($"Adding {itemCount} {itemName}s to cart.");
                }
                else
                {
                    Console.WriteLine($"Adding {itemCount} {itemName} to cart.");
                }
                if (itemCount >1)
                {
                    subtotal += itemCount * itemPrice;
                }
                else
                {
                    subtotal += itemPrice;
                }
                
            }
            Console.WriteLine($"Subtotal: ${(subtotal):f2}");
            if (subtotal >= budget)
            {
                Console.WriteLine($"Not enough. We need ${(subtotal - budget):f2} more.");
            }
            else
            {
                Console.WriteLine($"Money left: ${(budget - subtotal):f2}");
            }
        }
    }
}
