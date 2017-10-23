using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Phoenix_Grid
{
    class Phoenix_Grid
    {
        static void Main(string[] args)
        {         
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "ReadMe")
                {
                    break;
                }

                string pattern = @"^[^\s_]\S+.*?$";
                Regex regex = new Regex(pattern);
                var matches = regex.Match(input);

                if (matches.Success)
                {
                    string wordToCheck = matches.Value;
                    string[] wordArr = wordToCheck.Split('.');

                    var result = IsPaliondrome(wordToCheck);
                    if (result)
                    {
                        Console.WriteLine("YES");
                    }
                    else
                    {
                        Console.WriteLine("NO");
                    }
                }
                else
                {
                    Console.WriteLine("NO");
                }               
            }
        }

        private static bool IsPaliondrome(string value)
        {
            char[] array = value.ToCharArray();
            Array.Reverse(array);
            string backwards = new string(array);

            return backwards == value;
        }
    }
}
