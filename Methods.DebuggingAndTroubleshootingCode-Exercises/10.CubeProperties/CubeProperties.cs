using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.CubeProperties
{
    class CubeProperties
    {
        static void Main(string[] args)
        {
            decimal sideOfCube = decimal.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            decimal result = 0.0m;
            if (parameter == "face")
            {
                result = sideOfCube * (decimal)Math.Sqrt(2.0);
            }
            else if (parameter == "space")
            {
                result = sideOfCube * (decimal)Math.Sqrt(3);
            }
            else if (parameter == "volume")
            {
                result = sideOfCube * sideOfCube * sideOfCube;
            }
            else if (parameter == "area")
            {
                result = 6 * sideOfCube * sideOfCube;
            }
            Console.WriteLine($"{result:f2}");
        }
    }
}
