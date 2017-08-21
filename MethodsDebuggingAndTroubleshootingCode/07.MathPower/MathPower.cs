using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MathPower
{
    class MathPower
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double result = RiceToPower(number, power);
            Console.WriteLine(result);
        }
        static double RiceToPower(double number, double power)
        {
            return Math.Pow(number, power);
        }
    }
}
