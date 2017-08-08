using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.BeerKegs
{
    class BeerKegs
    {
        static void Main(string[] args)
        {
            int kegsCount = int.Parse(Console.ReadLine());
            string biggestKegModel = string.Empty;
            double biggestKegVolume = 0.0;
            while (kegsCount > 0)
            {
                string kegModel = Console.ReadLine();
                double radiusKeg = double.Parse(Console.ReadLine());
                int heightKeg = int.Parse(Console.ReadLine());
                double currentVolume = Math.PI * radiusKeg * radiusKeg * heightKeg;
                if (currentVolume > biggestKegVolume)
                {
                    biggestKegVolume = currentVolume;
                    biggestKegModel = kegModel;
                }
                kegsCount--;
            }

            Console.WriteLine(biggestKegModel);
        }
    }
}
