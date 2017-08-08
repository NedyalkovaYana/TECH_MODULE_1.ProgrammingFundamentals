using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _10.CenturiesToNanoseconds
{
    class CenturiesToNanoseconds
    {
        static void Main(string[] args)
        {
            int centuries = int.Parse(Console.ReadLine());
            int years = centuries * 100;
            int days = (int)(years * 365.2422);
            ulong hours = 24 * (ulong)days;
            BigInteger minutes = 60 * hours;
            BigInteger seconds = minutes * 60;
            BigInteger milliseconds = 1000 * seconds;
            BigInteger microseconds = 1000 * milliseconds;
            BigInteger nanoseconds = 1000 * microseconds;
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = " +
                $"{seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
