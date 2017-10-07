using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Poke_Mon
{
    class PokeMon
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());           
            int count = 0;
            decimal isHalf = power * 0.5m;
            while (distance <= power)
            {               
                power -= distance;
                count++;

                if (power == isHalf && exhaustionFactor > 0)
                {
                    power /= exhaustionFactor;

                }
                
            }
            Console.WriteLine(power);
            Console.WriteLine(count);
            
        }
    }
}
