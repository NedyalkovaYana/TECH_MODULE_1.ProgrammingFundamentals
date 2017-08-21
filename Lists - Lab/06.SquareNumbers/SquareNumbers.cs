using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.SquareNumbers
{
    class SquareNumbers
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            input.Sort();
            var result = new List<int>();
            foreach (var num in input)
            {
                if (Math.Sqrt(num) == (int)Math.Sqrt(num))
                {
                    result.Add(num);
                }
            }
            result.Reverse();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
