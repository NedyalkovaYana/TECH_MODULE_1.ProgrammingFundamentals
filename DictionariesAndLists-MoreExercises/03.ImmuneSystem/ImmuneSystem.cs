using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.ImmuneSystem
{
    class ImmuneSystem
    {
        static void Main(string[] args)
        {
            List<string> viruses = new List<string>();
            int initialStrend = int.Parse(Console.ReadLine());
            int maxHealth = initialStrend;
            string viruse = Console.ReadLine();
            while (viruse != "end")
            {
                int viruseStrend = CalculateViruseStrend(viruse);
                int viruseTime = viruseStrend * viruse.Length;
                if (viruses.Contains(viruse))
                {
                    viruseTime = (int)(viruseTime / 3.0);
                }
                else
                {
                    viruses.Add(viruse);
                }
                initialStrend -= viruseTime;
                Console.WriteLine($"Virus {viruse}: {viruseStrend} => {viruseTime} seconds");
                if (initialStrend <= 0)
                {
                    Console.WriteLine("Immune System Defeated.");
                    return;
                }
                else
                {
                    Console.WriteLine($"{viruse} defeated in {CalculateTime(viruseTime)}.");
                    Console.WriteLine($"Remaining health: {initialStrend}");
                }
                initialStrend = Math.Min(maxHealth, (int)(initialStrend * 1.2));
                viruse = Console.ReadLine();
            }
            Console.WriteLine($"Final Health: {initialStrend}");
        }

        static int CalculateViruseStrend(string viruse)
        {
            int totalStrend = 0;
            for (int i = 0; i < viruse.Length; i++)
            {
                totalStrend += viruse[i];
            }
            return (int)(totalStrend / 3.0);
        }
        static string CalculateTime(int time)
        {
            return time / 60 + "m " + time % 60 + "s";
        }
    }
}
