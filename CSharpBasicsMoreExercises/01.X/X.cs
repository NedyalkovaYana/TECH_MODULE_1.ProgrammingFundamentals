using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.X
{
    class X
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int middleSpace = n - 2;
            int leftRight = 0;
            for (int i = 1; i <= n; i++)
            {
                if ((i == (n/2)+1) && (middleSpace <=0 ))
                {
                    Console.WriteLine("{0}x{0}",
                        new string(' ', leftRight));
                    leftRight--;
                    middleSpace+=2;
                }
                else if (i > (n / 2) + 1)
                {
                    Console.WriteLine("{0}x{1}x{0}",
                    new string(' ', leftRight),
                    new string(' ', middleSpace));
                    leftRight--;
                    middleSpace += 2;
                }
                else
                {
                    Console.WriteLine("{0}x{1}x{0}",
                   new string(' ', leftRight),
                   new string(' ', middleSpace));
                    leftRight++;
                    middleSpace -= 2;
                }

            }
        }
    }
}
