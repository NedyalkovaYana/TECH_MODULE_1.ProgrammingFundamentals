using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.ValidUsernames
{
    class ValidUsernames
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string userName = @"(?<=[\s\/\\(\)]|^)([A-Za-z]\w{3,25})(?=[\s\/\\(\)]|$)";

            MatchCollection matches = Regex.Matches(line, userName);
            List<string> validUsernames = new List<string>();

            int biggestSum = 0;
            int pos = 0;
            for (int i = 0; i < matches.Count - 1; i++)
            {
                int currentSum = matches[i].Length + matches[i + 1].Length;

                if (currentSum > biggestSum)
                {
                    biggestSum = currentSum;
                    pos = i;
                }
            }
            Console.WriteLine(matches[pos]);
            Console.WriteLine(matches[pos + 1]);
        }
    }
}
