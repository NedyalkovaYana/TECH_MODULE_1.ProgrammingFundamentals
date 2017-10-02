using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.CountSubstringOccurrences
{
    class CountSubstringOccurrences
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string word = Console.ReadLine();        
            int count = 0;
            int index = text.IndexOf(word);

            while (index != -1)
            {
                count++;
                index = text.IndexOf(word, index + 1);
            }
            Console.WriteLine(count);
        }
    }
}
