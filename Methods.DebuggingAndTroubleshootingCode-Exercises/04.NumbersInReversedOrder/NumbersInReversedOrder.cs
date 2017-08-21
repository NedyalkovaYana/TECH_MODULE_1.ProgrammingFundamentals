using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NumbersInReversedOrder
{
    class NumbersInReversedOrder
    {
        static void Main()
        {
           decimal number =Math.Abs(decimal.Parse(Console.ReadLine()));
           PrintReversedNumber(number);
        }

        static decimal PrintReversedNumber(decimal number)
        {
            decimal reversedNumber = 0m;
            int places = 0;
            int times = 0;

            while (number % 1 > 0)  //  Намираме броя знаци след десетичната запетая и привеждаме до цяло число
            {
                number *= 10;
                places++;
            }

            do                     //  Обръщаме реда на цифрите в цялото число и запазваме броя им
            {
                int lastDigit = (int)number % 10;
                reversedNumber = reversedNumber * 10 + lastDigit;
                number = (int)number / 10;
                times++;
            } while (number > 0);

            if (places > 0)              //  Ако въведеното число е имало дробна част, разделяме така че да получим обърнат вариант на въведеното число
            {
                int division = (int)Math.Pow(10, times - places);
                reversedNumber = reversedNumber / division;
            }
            Console.WriteLine(reversedNumber);
            return reversedNumber;
        }
    }
}
