using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CatchTheThief
{
    class CatchTheThief
    {
        static void Main(string[] args)
        {
            string typeOfID = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            long biggestNumber = long.MinValue;

            for (int i = 0; i < n; i++)
            {
                long number = long.Parse(Console.ReadLine());

                if (typeOfID == "sbyte" && number >= sbyte.MinValue && number <= sbyte.MaxValue)
                {
                    if (number > biggestNumber)
                    {
                        biggestNumber = number;
                    }
                }
                else if (typeOfID == "int" && number >= int.MinValue && number <= int.MaxValue)
                {
                    if (number > biggestNumber)
                    {
                        biggestNumber = number;
                    }
                }
                else if (typeOfID == "long" && number >= long.MinValue && number <= long.MaxValue)
                {
                    if (number > biggestNumber)
                    {
                        biggestNumber = number;
                    }
                }
            }
            Console.WriteLine(biggestNumber);
        }
    }
}
