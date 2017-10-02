using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.CakeIngredients
{
    class CakeIngredients
    {
        static void Main(string[] args)
        {
            string ingredients = Console.ReadLine();
            int count = 0;
            while (ingredients != "Bake!")
            {
                count++;
                Console.WriteLine($"Adding ingredient {ingredients}.");

                ingredients = Console.ReadLine();
                
            }
            Console.WriteLine($"Preparing cake with {count} ingredients.");
        }
    }
}
