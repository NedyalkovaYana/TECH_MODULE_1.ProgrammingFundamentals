using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.StringConcatenation
{
    class StringConcatenation
    {
        static void Main(string[] args)
        {
            string separator = Console.ReadLine();
            byte reminder = Console.ReadLine() == "even" ? (byte)0 : (byte)1;
            byte stringsCount = byte.Parse(Console.ReadLine());
            string concatenatedString = String.Empty;

            for (int i = 1; i <= stringsCount; i++)
            {
                if (i % 2 == reminder)
                {
                    concatenatedString += Console.ReadLine() + separator;
                }
                else
                {
                    Console.ReadLine();
                }
            }
            Console.WriteLine(concatenatedString.Remove(concatenatedString.Length-1));
        }
    }
}
