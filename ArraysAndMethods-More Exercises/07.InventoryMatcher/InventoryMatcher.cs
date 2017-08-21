using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.InventoryMatcher
{
    class InventoryMatcher
    {
        static void Main(string[] args)
        {
            string[] productsNames = Console.ReadLine().Split().ToArray(); ;
            long[] quantity = Console.ReadLine().Split().Select(long.Parse).ToArray();
            decimal[] priceOfProducts = Console.ReadLine().Split().Select(decimal.Parse).ToArray();
            string commands = Console.ReadLine();

            while (commands != "done")
            {
                for (int i = 0; i < productsNames.Length; i++)
                {
                    if (commands == productsNames[i])
                    {
                        Console.WriteLine($"{commands} costs: {priceOfProducts[i]}; Available quantity: {quantity[i]}");
                    }
                    
                }
                commands = Console.ReadLine();
            }
        }
    }
}
