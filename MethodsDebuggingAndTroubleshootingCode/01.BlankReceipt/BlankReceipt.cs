using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.BlankReceipt
{
    class BlankReceipt
    {
        static void Main()
        {
            PrintBlankCashReceipt();
        }

        static void PrintBlankCashReceipt()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }

        static void PrintFooter()
        {
            Console.WriteLine(new string('-', 30));
           
            Console.WriteLine("\u00a9 SoftUni");
        }

        static void PrintBody()
        {
            Console.WriteLine("Charged to" + new string('_', 20));
            Console.WriteLine("Received by" + new string('_', 19));
        }

        static void PrintHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine(new string('-', 30));
        }
    }
}
