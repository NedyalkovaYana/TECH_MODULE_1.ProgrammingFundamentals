using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07.Hideout
{
    class Hideout
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();

            while (true)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                string pattern = @"\" + tokens[0] + "{" + tokens[1] + ",}";
                Match match = Regex.Match(path, pattern);
                if (match.Success)
                {
                    Console.WriteLine($"Hideout found at index " +
                        $"{path.IndexOf(match.Value)} and it is with size" +
                        $" {match.Value.Length}!");
                    break;
                }
            }
        }
    }
}
