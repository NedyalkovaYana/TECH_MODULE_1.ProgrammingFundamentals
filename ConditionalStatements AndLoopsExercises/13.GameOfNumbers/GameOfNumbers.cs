using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.GameOfNumbers
{
    class GameOfNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combination = 0;
            int matchCoungter = 0;
            int sum = 0;

            for (int i = m; i >= n; i--)
            {
                for (int j = m; j >= n; j--)
                {
                    sum = i + j;
                    combination++;
                    if (sum == magicNumber)
                    {
                        Console.WriteLine($"Number found! {i} + {j} = {magicNumber}");
                        matchCoungter++;
                        return;
                    }
                   
                }
            }
            if (matchCoungter == 0)
            {
                Console.WriteLine($"{combination} combinations - neither equals {magicNumber}");
            }
            
        }
    }
}
