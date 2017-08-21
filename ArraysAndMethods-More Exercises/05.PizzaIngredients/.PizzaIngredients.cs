using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.PizzaIngredients
{
    class Program
    {
        static void Main(string[] args) /// Грешка заради запетайката :)
        {
            string[] ingredients = Console.ReadLine().Split().ToArray();
            int searchedLenght = int.Parse(Console.ReadLine());
            int count = 0;
            string newIngredients = String.Empty;
            for (int i = 0; i < ingredients.Length; i++)
            {

                if (ingredients[i].Length == searchedLenght)
                {
                    count++;
                    if (count <= 10)
                    {
                        Console.WriteLine($"Adding {ingredients[i]}.");
                        newIngredients += ", " + ingredients[i];
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {
                    ingredients = ingredients.Distinct().ToArray();
                }
            }
            Console.WriteLine($"Made pizza with total of {count} ingredients.");
            Console.WriteLine($"The ingredients are: {string.Join(", ", newIngredients)}.");

        }
    }
}
