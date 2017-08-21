using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.MaxMethod
{
    class MaxMethod
    {
        static void Main()
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int totalBiggestNum = Math.Max(GetMax(firstNum, secondNum), GetMax(secondNum, thirdNum));
            Console.WriteLine(totalBiggestNum);
        }

        private static int GetMax(int firstNum, int secondNum)
        {
            return Math.Max(firstNum, secondNum);
        }
    }
}
