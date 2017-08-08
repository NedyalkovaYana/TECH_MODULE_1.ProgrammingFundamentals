using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.HouseBuilder
{
    class HouseBuilder
    {
        static void Main(string[] args)
        {
            long price1 = long.Parse(Console.ReadLine());
            long price2 = long.Parse(Console.ReadLine());

            Console.WriteLine(Math.Max(price1, price2)* 10 + Math.Min(price1, price2) * 4);
        }
    }
}
