using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BPMCounter
{
    class BPMCounter
    {
        static void Main(string[] args)
        {
            double bmp = double.Parse(Console.ReadLine());
            double beatsCount = double.Parse(Console.ReadLine());

            double secondsForOneBeat = 60 / bmp;
            double totalSeconds = secondsForOneBeat * beatsCount;
            int minutes = (int)totalSeconds / 60;
            int seconds = (int)totalSeconds % 60;
            double bars = Math.Round(beatsCount / 4.00, 1);
            Console.WriteLine($"{bars} bars - {minutes}m {seconds}s ");
        }
    }
}
