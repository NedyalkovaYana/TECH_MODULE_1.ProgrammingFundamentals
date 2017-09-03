using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ShortWordsSorted
{
    class Program
    {
        static void Main()
        {
           
            var input = Console.ReadLine().
                        ToLower().
                        Split(new char[] {' ', '.',  ',', ':', ';', '(', ')', '[', ']', '"', '\'', '/', '!', '?' },
                        StringSplitOptions.RemoveEmptyEntries).
                        ToArray();
           
            var result = new List<string>();

            foreach (var word in input)
            {
                if (word.Length < 5)
                {
                    result.Add(word);
                }
            }
            var output = result.
                OrderBy(word => word).
                Distinct();
           
            Console.WriteLine(string.Join(", ", output));
        }
    }
}
