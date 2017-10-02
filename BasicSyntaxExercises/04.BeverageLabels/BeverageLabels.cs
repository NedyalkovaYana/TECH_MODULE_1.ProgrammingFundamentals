using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.BeverageLabels
{
    class BeverageLabels
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double volume = double.Parse(Console.ReadLine());
            double energyContent = double.Parse(Console.ReadLine());
            double sugarContent = double.Parse(Console.ReadLine());

            double kcal = (energyContent/100) * volume;
            double g = (sugarContent/100) * volume;
            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{kcal}kcal, {g}g sugars");

        }
    }
}
