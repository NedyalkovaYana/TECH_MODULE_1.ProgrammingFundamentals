using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OddFilter
{
    class OddFilter
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> evenNumbers = numbers.Where(a => a % 2 == 0).ToList();
            List<int> result = evenNumbers.Select(a => a > evenNumbers.Average() ? a += 1 : a -= 1).ToList();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
