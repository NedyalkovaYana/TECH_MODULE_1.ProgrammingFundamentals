using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DrawFilledSquare
{
    class DrawFilledSquare
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintHeaderFooter(n);

            for (int i = 0; i < n-2; i++)
            {
                PrintBody(n);
            }
            
            PrintHeaderFooter(n);
        }

        private static void PrintBody(int n)
        {

            Console.Write("-");
            for (int i = 1; i <n; i++)
            {
                Console.Write("\\/");
            }
            Console.WriteLine("-");
        }

        static void PrintHeaderFooter(int n)
        {
            Console.WriteLine(new string('-', 2*n));
        }
    }
}
