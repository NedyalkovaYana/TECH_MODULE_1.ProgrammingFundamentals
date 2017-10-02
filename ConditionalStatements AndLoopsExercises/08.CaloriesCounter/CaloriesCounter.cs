using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CaloriesCounter
{
    class CaloriesCounter
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int totalCalories = 0;
            string ingredients = string.Empty;

            for (int i = 0; i < n; i++)
            {
                ingredients = Console.ReadLine()
                .ToLower();
                switch (ingredients)
                {
                    case "cheese":
                        totalCalories += 500;
                        break;
                    case "tomato sauce":
                        totalCalories += 150;
                        break;
                    case "salami":
                        totalCalories += 600;
                        break;
                    case "pepper":
                        totalCalories += 50;
                        break;
                }
              
            }
            Console.WriteLine($"Total calories: {totalCalories}");
            
        }
    }
}
