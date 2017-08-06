using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Backin30Minutes
{
    class Backin30Minutes
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes += 30;
            if (minutes >= 60)
            {
                hours++;
                minutes -= 60;
            }
            if (hours > 23)
            {
                hours = 0;
            }
            if (minutes <=9)
            {
                Console.WriteLine($"{hours}:0{minutes}");
            }
            else
            {
                Console.WriteLine($"{hours}:{minutes}");
            }
            
        }
    }
}
