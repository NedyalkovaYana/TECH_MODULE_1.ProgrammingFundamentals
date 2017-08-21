using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Split_ByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(new[] {' ', ',', ';', ':', '.', '!', '(', ')', '"', '\\', '/', '[', ']' }).ToList();
            for (int i = 0; i < input.Count; i++)
            {
                input.Remove("");
            }
           
            List<string> lowerCase = new List<string>();
            List<string> mixedCase = new List<string>();
            List<string> upperCase = new List<string>();

            for (int i = 0; i < input.Count; i++)
            {
                string word = input[i];
                if (word.All(symbol => char.IsLower(symbol)))
                {
                    lowerCase.Add(word);
                }
                else if (word.All(symbol => char.IsUpper(symbol)))
                {
                    upperCase.Add(word);
                }
                else
                {
                    mixedCase.Add(word);
                }
               
            }
            
            Console.WriteLine($"Lower-case: {string.Join(", ", lowerCase)}");
            Console.WriteLine($"Mixed-case: {string.Join(", ", mixedCase)}");
            Console.WriteLine($"Upper-case: {string.Join(", ", upperCase)}");
        }
    }
}
