using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.ByteFlip
{
    class ByteFlip
    {
        static void Main(string[] args)
        {
             var numbers = Console.ReadLine()
                           .Split(' ')
                           .Where(x => x.Length == 2)
                           .ToArray();
            for (int i = numbers.Length -1; i >= 0; i--)
            {
                var charArr = numbers[i].ToCharArray();
                Array.Reverse(charArr);
                Console.Write(System.Convert.ToChar(System.Convert.ToUInt32(new string(charArr), 16)));
            }
            Console.WriteLine();
        }
    }
}
