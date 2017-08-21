using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.JumpAround
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int index = 0;
            long sum = 0L;
            while (true)
            {
                sum += arr[index];
                int tempIndex = index;
                index = tempIndex + arr[index];                
                if (index >= arr.Length)
                {
                    index = tempIndex - arr[tempIndex];
                    if (index < 0)
                    {                    
                        break;
                    }                       
                }
            }
            Console.WriteLine(sum);
        }
    }
}
