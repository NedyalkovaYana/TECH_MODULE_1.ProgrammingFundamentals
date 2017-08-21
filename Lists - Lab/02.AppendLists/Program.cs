using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AppendLists
{
    class Program
    {
        static void Main(string[] args)
        { 
            var input = Console.ReadLine().Split('|').ToArray();
            var result = new List<string>();
            Array.Reverse(input);
            foreach (var token in input)
            {
                string[] numbers = token.Split(' ');
                foreach (var item in numbers)
                {
                   
                    result.Add(item);
                }
               
            }
            //result = result.Where(s => !string.IsNullOrWhiteSpace(s)).Distinct().ToList();
            Console.WriteLine(string.Join(" ",result));
        }
    }
}
