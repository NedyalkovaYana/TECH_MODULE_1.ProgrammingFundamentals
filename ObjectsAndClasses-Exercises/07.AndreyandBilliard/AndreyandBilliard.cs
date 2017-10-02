using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.AndreyandBilliard
{
    class AndreyandBilliard
    {
        class Customer
        {
            public string Name { get; set; }
            public Dictionary<string, int> ShoppingList { get; set; }
            public decimal Bill { get; set; }
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, decimal> products = new Dictionary<string, decimal>();
            List<Customer> customerList = new List<Customer>();

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split('-').ToArray();
                var item = tokens[0];
                var price = decimal.Parse(tokens[1]);

                if (! products.ContainsKey(item))
                {
                    products.Add(item, price);
                }
                else
                {
                    products[item] = price;
                }
            }
            var orders = String.Empty;
            while (true)
            {
                orders = Console.ReadLine();
                if (orders == "end of clients")
                {
                    break;
                }
                var tokens = orders.Split('-', ',').ToArray();
                string name = tokens[0];
                string order = tokens[1];
                int orderQuantity = int.Parse(tokens[2]);

                if (!products.ContainsKey(order))
                {
                    continue;
                }
                Customer customer = new Customer()
                {
                    Name = name,
                    ShoppingList = new Dictionary<string, int>
                    {
                        [order] = orderQuantity
                    },
                    Bill = orderQuantity * products[order]
                };
                if (!customerList.Exists(a => a.Name == customer.Name))
                {
                    customerList.Add(customer);
                }
                else
                {
                    Customer existingCustomer =
                        customerList.First(a => a.Name == name);
                    if (!(existingCustomer.ShoppingList.ContainsKey(order)))
                    {
                        existingCustomer.ShoppingList.Add(order, orderQuantity);
                        existingCustomer.Bill += customer.Bill;
                    }
                    else
                    {
                        existingCustomer.ShoppingList[order] += orderQuantity;
                        existingCustomer.Bill = customer.Bill;
                    }
                }
            }
            decimal totalPrice = 0;
            var orderedCustomerList = customerList.OrderBy(a => a.Name)
                .ThenBy(a => a.Bill);
            foreach (var customer in orderedCustomerList)
            {
                Console.WriteLine(customer.Name);
                foreach (KeyValuePair<string, int> item in customer.ShoppingList)
                {
                    Console.WriteLine($"-- {item.Key} - {item.Value}");
                }
                Console.WriteLine($"Bill: {customer.Bill:f2}");
                totalPrice += customer.Bill;
            }
            Console.WriteLine($"Total bill: {customerList.Sum(a => a.Bill):f2}");
        }
       
    }
}
