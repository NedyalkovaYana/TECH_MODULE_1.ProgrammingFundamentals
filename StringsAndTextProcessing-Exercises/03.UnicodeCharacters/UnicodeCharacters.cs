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

            var result = input.Select(t => string.Format("u{0:x4}", Convert.ToUInt16(t))).ToList();


            Console.Write("\\");
            Console.WriteLine(string.Join("\\", result));
        }
    }
}
