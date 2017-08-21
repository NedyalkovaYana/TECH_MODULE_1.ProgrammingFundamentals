using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CalculateTriangleArea
{
    class CalculateTriangleArea
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double triangleArea = GetTriangleArea(width, height);
            Console.WriteLine(triangleArea);
        }
        static double GetTriangleArea(double width, double height)
        {
            return (width * height) / 2;
        }
    }
}
