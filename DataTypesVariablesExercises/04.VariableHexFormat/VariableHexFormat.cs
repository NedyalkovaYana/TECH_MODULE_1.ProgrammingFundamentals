using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.VariableHexFormat
{
    class VariableHexFormat
    {
        static void Main(string[] args)
        {
            string numberInHex =Console.ReadLine();
            int numberInDec = Convert.ToInt32(numberInHex, 16);
            Console.WriteLine(numberInDec);
        }
    }
}
