using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Heists
{
    class Heists
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int jewelsPrice = arr[0];
            int goldPrice = arr[1];
            long totalLoot = 0L;
            long totalExpense = 0L;

            string[] tokens = Console.ReadLine().Split().ToArray();

            while (tokens[0] != "Jail")
            {
                string loot = tokens[0];
                int expense = int.Parse(tokens[1]);
                totalExpense += expense;

                for (int i = 0; i < loot.Length; i++)
                {
                    if (loot.Contains('%'))
                    {
                        totalLoot += jewelsPrice;
                    }
                   if (loot.Contains('$'))
                    {
                        totalLoot += goldPrice;
                    }
                }
                tokens = Console.ReadLine().Split().ToArray();
            }
            if (totalExpense <= totalLoot)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {totalLoot - totalExpense}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {totalExpense - totalLoot}.");
            }
        }
    }
}
