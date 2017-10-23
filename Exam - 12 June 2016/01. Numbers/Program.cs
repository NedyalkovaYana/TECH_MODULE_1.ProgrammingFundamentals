using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var average = numbers.Average();
            List<double> top = new List<double>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > average)
                {
                    top.Add(numbers[i]);
                }
            }         
            var sorted = top.OrderByDescending(a => a).Take(5);           
           
            if (sorted.Any())
            {
                Console.WriteLine(string.Join(" ", sorted));
               
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
