using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SumAdjacentEqualNumbers
{
    class SumAdjacentEqualNumbers
    {
        static void Main(string[] args)
        {
            List<decimal> input = Console.ReadLine().Split().Select(decimal.Parse).ToList();
           
            decimal sum = 0;
            for (int item = 0; item < input.Count - 1; item++)
            {
                if (input[item] == input[item + 1])
                {
                    sum = input[item] + input[item + 1];
                    input.Remove(input[item]);
                    input.Remove(input[item]);
                    input.Insert(item , sum);
                    sum = 0;
                    item = -1;
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
