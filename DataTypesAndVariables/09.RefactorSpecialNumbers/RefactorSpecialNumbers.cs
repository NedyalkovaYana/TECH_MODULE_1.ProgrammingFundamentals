using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.RefactorSpecialNumbers
{
    class RefactorSpecialNumbers
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int num = 0;
            int sumDigits = 0;
            bool isNumberSpecial = false;
            for (int i = 1; i <= numbers; i++)
            {
                sumDigits = i;
                while (i > 0)
                {
                    num += i % 10;
                    i = i / 10;
                }
                isNumberSpecial = (num == 5) || (num == 7) || (num == 11);
                Console.WriteLine($"{sumDigits} -> {isNumberSpecial}");
                num = 0;
                i = sumDigits;
            }

        }
    }
}
