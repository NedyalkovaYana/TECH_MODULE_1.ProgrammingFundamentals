using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DayОfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputData = Console.ReadLine();
            DateTime date =  DateTime.ParseExact(inputData, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(date.DayOfWeek);
        }
    }
}
