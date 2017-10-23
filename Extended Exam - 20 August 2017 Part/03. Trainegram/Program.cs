using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Trainegram
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = String.Empty;

            while ((input = Console.ReadLine()) != "Traincode!")
            {
                string pattern = @"^(<\[[^a-zA-Z0-9]*\][\.]{1})+([\.]{1}\[[a-zA-Z0-9]*\][\.]{1})*$";

                Regex regex = new Regex(pattern);

                var matches = regex.Match(input);

                if (matches.Success)
                {
                    Console.WriteLine(input);
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
