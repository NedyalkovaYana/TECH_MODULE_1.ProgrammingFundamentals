using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EnglishNameOfLastDigit
{
    class EnglishNameOfLastDigit
    {
        static void Main()
        {
            long number = Math.Abs(long.Parse(Console.ReadLine()));
            GetEnglishName(number);
        }

        static void GetEnglishName(long number)
        {
            long lastDigit = number % 10;
            string name = String.Empty;
            switch (lastDigit)
            {
                case 0: name = "zero"; break;
                case 1: name = "one"; break;
                case 2: name = "two"; break;
                case 3: name = "three"; break;
                case 4: name = "four"; break;
                case 5: name = "five"; break;
                case 6: name = "six"; break;
                case 7: name = "seven"; break;
                case 8: name = "eight"; break;
                case 9: name = "nine"; break;
            }
            Console.WriteLine(name);
        }
    }
}
