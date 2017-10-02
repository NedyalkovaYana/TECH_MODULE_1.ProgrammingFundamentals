using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CirclesIntersection
{
    class CirclesIntersection
    {
        class Circle
        {
            public Point point { get ; set; }
            public int r { get; set; }
        }
        class Point
        {
            public double X { get; set; }
            public double Y { get; set; }
        }

        static void Main(string[] args)
        {
            Circle one = GetCircle();
            Circle two = GetCircle();

            double distance = GetDistance(one.point, two.point);
            if (distance <= one.r + two.r)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

        private static double GetDistance(Point point1, Point point2)
        {
            double distance = Math.Sqrt(Math.Pow(point2.X - point1.X, 2) + Math.Pow(point2.Y - point1.Y, 2));
            return distance;
        }

        static Circle GetCircle()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Point point = new Point() { X = input[0], Y = input[1] };
            Circle circle = new Circle() { point = point, r = input[2] };
            return circle;
        }
    }
}
