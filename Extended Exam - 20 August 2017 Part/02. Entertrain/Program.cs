using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Entertrain
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = new List<int>();
            int locomotivePower = int.Parse(Console.ReadLine());
            
            while (true)
            {
               string input = Console.ReadLine();
                if (input == "All ofboard!")
                {
                    break;
                }
                int tokens = int.Parse(input);
                wagons.Add(tokens);
                int sumWight = wagons.Sum();
                if (sumWight > locomotivePower)
                {
                    int average = sumWight / wagons.Count;
                    var nearest = wagons.OrderBy(a => Math.Abs(a - average)).First();
                    wagons.Remove(nearest);
                }

            }
            
            wagons.Reverse();
            Console.Write(string.Join(" ", wagons));
            Console.Write($" {locomotivePower}");
            Console.WriteLine();
        }
    }
}
