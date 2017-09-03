﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SalesReport
{
    class Program
    {
        class Sale
        {
            public string Town { get; set; }
            public string Product { get; set; }
            public decimal Price { get; set; }
            public decimal Quantity { get; set; }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Sale[] sales = new Sale[n];
            for (int i = 0; i < n; i++)
            {
                sales[i] = ReadSale();
            }

            SortedDictionary<string, decimal> salesByTown = 
                new SortedDictionary<string, decimal>();
            for (int i = 0; i < n; i++)
            {
                if (!salesByTown.ContainsKey(sales[i].Town))
                {
                    salesByTown.Add(sales[i].Town, 0);
                }
                salesByTown[sales[i].Town] +=
                    sales[i].Price * sales[i].Quantity;
            }
            foreach (var town in salesByTown)
            {
                Console.WriteLine($"{town.Key} -> {town.Value:f2}");
            }
        }
        static Sale ReadSale()
        {
            string[] items = Console.ReadLine().Split(' ');
            return new Sale() { Town = items[0], Product = items[1],
                Price = decimal.Parse(items[2]),
                Quantity = decimal.Parse(items[3])};
        }
       
    }
}
