using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.CountRealNumbers
{
    class CountRealNumbers
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var count = new SortedDictionary<double, int>();

            foreach (var num in input)
            {
                double parsedNum = double.Parse(num);
                if (count.ContainsKey(parsedNum))
                {
                    count[parsedNum]++;
                }
                else
                {
                    count[parsedNum] = 1;
                }
            }
            foreach (var item in count.Keys)
            {
                Console.WriteLine($"{item} -> {count[item]}");
            }
        }
    }
}
