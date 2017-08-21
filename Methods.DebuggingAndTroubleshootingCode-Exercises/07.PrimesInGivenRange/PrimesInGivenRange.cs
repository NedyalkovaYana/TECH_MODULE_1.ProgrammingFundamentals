using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PrimesInGivenRange
{
    class PrimesInGivenRange
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            List<int> allPrimes = FindPrimesInRange(startNum, endNum);

            for (int i = 0; i < allPrimes.Count; i++)
            {
                if (i < allPrimes.Count - 1)
                {

                    Console.Write(allPrimes[i] + ", ");
                }
                else
                {
                    Console.Write(allPrimes[i]);
                }
            }
            Console.WriteLine();
        }

        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> allPrimes = new List<int>();
            if (startNum < 2)
            {
                startNum = 2;
            }

            for (int i = startNum; i <= endNum; i++)
            {
                bool isPrime = true;
                for (int counter = 2; counter <= Math.Sqrt(i); counter++)
                {
                    if (i % counter == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    allPrimes.Add(i);
                }
            }
            return allPrimes;
        }
    }
}
