using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SupermarketDatabase
{
    class SupermarketDatabase
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            var productsBook = new Dictionary<string, Dictionary<double, double>>();

            while (input[0] != "stocked")
            {
                var product = input[0];
                var price = double.Parse(input[1]);
                var quantity = double.Parse(input[2]);

                if (!productsBook.ContainsKey(product))
                {
                    productsBook[product] = new Dictionary<double, double>();
                }
                if (!productsBook[product].ContainsKey(price))
                {
                    productsBook[product].Add(price, quantity);
                }

                Console.WriteLine();
                input = Console.ReadLine().Split().ToArray();
            }
            double totalAmount = 0.0;
            foreach (var item in productsBook)
            {
                var name = item.Key;
                var price = item.Value.Keys.Last();
                double quantity = item.Value.Values.Sum();
                totalAmount += (quantity * price);
                Console.WriteLine($"{name}: ${price:f2} * {quantity} = ${(price * quantity):f2}");
            }
            Console.WriteLine(new string('-', 30));
            Console.WriteLine($"Grand Total: ${totalAmount:f2}");
        }
    }
}
