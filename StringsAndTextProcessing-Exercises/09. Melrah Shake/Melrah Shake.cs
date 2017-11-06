using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Melrah_Shake
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string key = Console.ReadLine();

            string pattern = $@"{key}";

            while (input.Length > 0 && pattern.Length > 0)
            {
                int firstIndex = input.IndexOf(pattern);
                int secondIndex = input.LastIndexOf(pattern);

                if (firstIndex >= 0 && secondIndex >= 0 && firstIndex != secondIndex)
                {
                    Console.WriteLine("Shaked it.");
                    input = input.Remove(firstIndex, pattern.Length);
                    secondIndex = input.LastIndexOf(pattern);
                    input = input.Remove(secondIndex, pattern.Length);
                    pattern = pattern.Remove(pattern.Length / 2, 1);
                }
                else
                {
                    break;
                }              
            }
            Console.WriteLine("No shake.");
            Console.WriteLine(input);
        }
    }
}
