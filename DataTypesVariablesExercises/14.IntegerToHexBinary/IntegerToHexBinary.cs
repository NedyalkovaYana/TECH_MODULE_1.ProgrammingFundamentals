using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.IntegerToHexBinary
{
    class IntegerToHexBinary
    {
        static void Main(string[] args)
        {
            int decValue = int.Parse(Console.ReadLine());
            string hexValue = decValue.ToString("X");
            Console.WriteLine(hexValue);
            int remainder;
            string result = string.Empty;
            while (decValue > 0)
            {
                remainder = decValue % 2;
                decValue /= 2;
                result = remainder.ToString() + result;
            }
            Console.WriteLine(result);
        }
    }
}
