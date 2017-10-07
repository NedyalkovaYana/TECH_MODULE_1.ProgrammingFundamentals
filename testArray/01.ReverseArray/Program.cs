using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                int number = int.Parse(Console.ReadLine());
                arr[i] = number;
            }

            Array.Reverse(arr);

            Console.WriteLine(string.Join(" ", arr));
        }
    }
}
