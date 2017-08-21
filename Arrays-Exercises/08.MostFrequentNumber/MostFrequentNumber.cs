using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.MostFrequentNumber
{
    class MostFrequentNumber
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int count = 1;
            int maxcount = 1; 
            int maxvalue = 0;
            int result = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                maxvalue = arr[i];
                for (int j = 0; j < arr.Length; j++)
                {
                    if (maxvalue == arr[j] && j != i)
                    {
                        count++;
                        if (count > maxcount)
                        {
                            maxcount = count;
                            result = arr[i];
                        }
                    }
                    else
                    {
                        count = 1;
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
