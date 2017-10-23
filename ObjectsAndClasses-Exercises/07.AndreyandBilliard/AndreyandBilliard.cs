using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _07.AndreyandBilliard
{
    class AndreyandBilliard
    {
        public class Customer
        {
            public string Name { get; set; }
            public Dictionary<string, int> ShopList  { get; set; }
            public decimal Bill { get; set; }
        }
        static void Main(string[] args)
        {
            Dictionary<string, decimal> productsPriceList = new Dictionary<string, decimal>();
            List<Customer> customerList = new List<Customer>();

            int n = int.Parse(Console.ReadLine());
            decimal price = 0m;

            for (int i = 0; i < n; i++)
            {
                string[] productsWithPrice = Console.ReadLine().Split('-').ToArray();
                string product = productsWithPrice[0];
                price = decimal.Parse(productsWithPrice[1]);

                if (!productsPriceList.ContainsKey(product))
                {
                    productsPriceList[product] = price;
                }
                else
                {
                    productsPriceList[product] = price;
                }
            }
            
            while (true)
            {
                string clients = Console.ReadLine();
                if (clients == "end of clients")
                {
                    break;
                }
                string[] tokens = clients.Split(new char[] {'-', ','}, StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];
                string wantedProduct = tokens[1];
                int quantity = int.Parse(tokens[2]);

                if (!productsPriceList.ContainsKey(wantedProduct))
                {
                    continue;
                }

                Customer customer = new Customer();
                if (customerList.Any( a => a.Name == name))
                {
                    customer = customerList.First(a => a.Name == name);
                    if (!customer.ShopList.ContainsKey(wantedProduct))
                    {
                        customer.ShopList.Add(wantedProduct, 0);
                    }
                    customer.ShopList[wantedProduct] += quantity;
                    customer.Bill += quantity * productsPriceList[wantedProduct];
                }
                else
                {
                    customer.Name = name;
                    customer.ShopList = new Dictionary<string, int>
                    {
                        [wantedProduct] = quantity,
                    };
                    customer.Bill = quantity * productsPriceList[wantedProduct];
                    customerList.Add(customer);
                };

            }
            var orderedCustomerList = customerList.OrderBy(a => a.Name).ThenBy(a => a.Bill).ToList();
            decimal totalBill = 0m;
            foreach (var item in orderedCustomerList)
            {
                Console.WriteLine($"{item.Name}");

                foreach (var products in item.ShopList)
                {
                    Console.WriteLine($"-- {products.Key} - {products.Value}");
                }

                Console.WriteLine($"Bill: {item.Bill:f2}");
                totalBill += item.Bill;
            }
            Console.WriteLine($"Total bill: {totalBill:f2}");
        }
       
    }
}
