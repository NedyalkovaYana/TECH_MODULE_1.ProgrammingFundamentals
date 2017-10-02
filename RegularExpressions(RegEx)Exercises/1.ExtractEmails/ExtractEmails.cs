using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _1.ExtractEmails
{
    class ExtractEmails
    {
        static void Main(string[] args)
        {
            var regex = new Regex(@"(?<=\s)[a-z0-9]+([-.]\w*)*@[a-z]+([-.]\w*)*(\.[a-z]+)");

            var text = Console.ReadLine();

            var emails = regex.Matches(text);

            foreach (Match email in emails)
            {
                Console.WriteLine(email);
            }
        }
    }
}
