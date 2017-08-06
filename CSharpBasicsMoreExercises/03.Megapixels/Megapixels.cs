using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Megapixels
{
    class Megapixels
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            double megaPixel = Math.Round((width * height) / 1000000.0, 1);
            Console.WriteLine($"{width}x{height} => {megaPixel}MP");

        }
    }
}
