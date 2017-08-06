using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MonthPrinter
{
    class MonthPrinter
    {
        static void Main(string[] args)
        {
            int month = int.Parse(Console.ReadLine());
            string answeringMonth = String.Empty;
            if ((month < 1) || (month > 12))
            {
                Console.WriteLine("Error!");
            }
            else
            {
                switch (month)
                {
                    case 1: answeringMonth = "January"; break;
                    case 2: answeringMonth = "February"; break;
                    case 3: answeringMonth = "March"; break;
                    case 4: answeringMonth = "April"; break;
                    case 5: answeringMonth = "May"; break;
                    case 6: answeringMonth = "June"; break;
                    case 7: answeringMonth = "July"; break;
                    case 8: answeringMonth = "August"; break;
                    case 9: answeringMonth = "September"; break;
                    case 10: answeringMonth = "October"; break;
                    case 11: answeringMonth = "November"; break;
                    case 12: answeringMonth = "December"; break;
                }
            }
            Console.WriteLine(answeringMonth);
        }
    }
}
