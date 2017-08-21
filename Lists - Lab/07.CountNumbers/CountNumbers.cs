using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CountNumbers
{
    class CountNumbers
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            numbers.Sort();
            int pos = 0;
            int count = 0;
            while (pos < numbers.Count)
            {
                int num = numbers[pos];
                count = 1;
                while (pos + count < numbers.Count && numbers[pos + count] == num)
                {
                    count++;
                }
                pos = pos + count;
                Console.WriteLine($"{num} -> {count}");
            }
        }
    }
}
