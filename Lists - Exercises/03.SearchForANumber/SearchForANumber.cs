using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.SearchForANumber
{
    class SearchForANumber
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            List<int> toDo = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int numbersToAdd = toDo[0];
            int numbersToDelete = toDo[1];
            int isHavingThisNumber = toDo[2];

            List<int> result = new List<int>();
      
                for (int i = 0; i < numbersToAdd; i++)
                {
                    result.Add(numbers[i]);
                }
                int count = 0;
                for (int i = 0; i < numbersToDelete; i++)
                {
                    count++;
                    i = 0;
                    result.RemoveAt(i);
                    if (count == numbersToDelete)
                    {
                        break;
                    }
                }
               
            for (int i = 0; i <= result.Count; i++)
            {
                if (isHavingThisNumber == result[i])
                {
                    Console.WriteLine("YES!");
                    break;
                }
                else
                {
                    Console.WriteLine("NO!");
                    break;
                }
            }
        }
    }
}
