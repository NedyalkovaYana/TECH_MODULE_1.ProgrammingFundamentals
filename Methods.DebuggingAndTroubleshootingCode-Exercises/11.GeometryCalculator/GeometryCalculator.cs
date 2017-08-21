using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.GeometryCalculator
{
    class GeometryCalculator
    {
        static void Main(string[] args)
        {
            string figureType = Console.ReadLine();
            double area = 0.0;
            if (figureType == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                area = (side * height) / 2;
            }
            else if (figureType == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                area = width * height;
            }
            else if (figureType == "square")
            {

                double side = double.Parse(Console.ReadLine());
                area = side * side;
            }
            else if (figureType == "circle")
            {

                double radius = double.Parse(Console.ReadLine());
                area = Math.PI * radius * radius;
            }
            Console.WriteLine($"{area:f2}");
        }
    }
}