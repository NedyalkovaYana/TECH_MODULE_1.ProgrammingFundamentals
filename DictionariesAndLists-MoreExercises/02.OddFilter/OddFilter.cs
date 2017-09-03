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
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var evenNumbers = nums.Where(num => num % 2 == 0).ToList();
            var average = evenNumbers.Average();
            var finalList = evenNumbers
                .Select(a => a > evenNumbers.Average() ? a += 1 : a -= 1).ToList();
            Console.WriteLine(string.Join(" ", finalList));
        }
    }
}
