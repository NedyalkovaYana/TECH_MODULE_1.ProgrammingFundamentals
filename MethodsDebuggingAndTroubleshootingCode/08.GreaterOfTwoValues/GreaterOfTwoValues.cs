using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.GreaterOfTwoValues
{
    class GreaterOfTwoValues
    {
        static void Main()
        {
            string type = Console.ReadLine();
          

            if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                int maxValue = GetMax(first, second);
                Console.WriteLine(maxValue);
            }
            if (type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                char maxValue = GetMax(first, second);
                Console.WriteLine(maxValue);
            }
            if (type == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                string maxValue = GetMax(first, second);
                Console.WriteLine(maxValue);
            }
        }

        static string GetMax(string first, string second)
        {
            if (first.CompareTo(second) >= 0)
            {
                return first;
            }
            return second;
        }

        static char GetMax(char first, char second)
        {
            int maxValue =  (int)Math.Max(first, second);
            return (char)maxValue;
        }
        static int GetMax(int first, int second)
        {
           return Math.Max(first, second);
        }
    }
}
