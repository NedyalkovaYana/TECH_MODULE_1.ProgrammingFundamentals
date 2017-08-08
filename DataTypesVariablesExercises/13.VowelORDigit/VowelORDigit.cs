using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.VowelORDigit
{
    class VowelORDigit
    {
        static void Main(string[] args)
        {
            char n = char.Parse(Console.ReadLine());
            if (n == 'a' || n == 'o' || n == 'e' || n == 'i' || n == 'u')
            {
                Console.WriteLine("vowel");
            } 
            else if ((n >= '0') && (n <= '9'))
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
           
        }
    }
}
