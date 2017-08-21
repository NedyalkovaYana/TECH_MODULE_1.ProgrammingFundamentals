using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main(string[] args)
        {
            char[] firstArr = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] secondArr = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            bool isCharEqual = false;
            
            for (int i = 0; i < Math.Min(firstArr.Length, secondArr.Length); i++)
            {
                if (firstArr[i] == secondArr[i])
                {
                    isCharEqual = true;
                }

                if (isCharEqual)
                {
                    if (firstArr.Length >= secondArr.Length)
                    {
                        Console.WriteLine(secondArr);
                        Console.WriteLine(firstArr);
                        break;
                    }
                    else
                    {
                        Console.WriteLine(firstArr);
                        Console.WriteLine(secondArr);
                        break;
                    }

                }
                else
                {
                    if (firstArr[i] >= secondArr[i])
                    {
                        Console.WriteLine(secondArr);
                        Console.WriteLine(firstArr);
                        break;
                    }
                    else
                    {
                        Console.WriteLine(firstArr);
                        Console.WriteLine(secondArr);
                        break;
                    }
                }
            }
        }
    }
}
