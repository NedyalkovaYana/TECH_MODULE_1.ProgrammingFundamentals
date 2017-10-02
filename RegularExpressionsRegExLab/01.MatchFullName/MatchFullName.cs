using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.MatchFullName
{
    class MatchFullName
    {
        static void Main(string[] args)
        {
            string regex = @"\b[A-Z]{1}[a-z]{1,30}[' '][A-Z]{1}[a-z]{1,30}\b";

            string names = Console.ReadLine();

            MatchCollection machedNames = Regex.Matches(names, regex);

            foreach (Match name in machedNames)
            {
                Console.Write(name.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
