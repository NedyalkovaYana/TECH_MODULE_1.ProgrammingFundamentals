using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.TriangleNumbers
{
    class TriangleNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int row = 1; row <= n; row++)
            {
                for (int cow = 1; cow <= row; cow++)
                {
                    Console.Write(row + " ");  
                }
                Console.WriteLine();
            }
        }
    }
}
