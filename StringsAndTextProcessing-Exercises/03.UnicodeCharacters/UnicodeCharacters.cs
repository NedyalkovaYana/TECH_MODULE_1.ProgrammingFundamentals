using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var chars = input
                .Select(c => (int) c)
                .Select(c => $@"\u{c:x4}");

            string rezult = string.Concat(chars);
            Console.WriteLine(string.Join("\\", rezult));
        }
    }
}
