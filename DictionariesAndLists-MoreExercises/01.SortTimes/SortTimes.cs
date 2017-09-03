using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SortTimes
{
    class SortTimes
    {
        static void Main(string[] args)
        {
            var listTimes = Console.ReadLine().Split(' ').ToList();
            listTimes.Sort();       

            for (int i = 0; i < listTimes.Count; i++)
            {
                if (i == (listTimes.Count - 1))
                {
                    Console.Write(listTimes[i]);
                }
                else
                {
                    Console.Write(listTimes[i] + ", ");
                }            
            }
            Console.WriteLine();
        }
    }
}
