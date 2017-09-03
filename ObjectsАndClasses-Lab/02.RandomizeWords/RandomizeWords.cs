using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.RandomizeWords
{
    class RandomizeWords
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            string[] words = Console.ReadLine().Split(' ');

            for (int pos1 = 0; pos1 < words.Length; pos1++)
            {
                int pos2 = rnd.Next(words.Length);
                if (pos1 != pos2)
                {
                    var old = words[pos1];
                    words[pos1] = words[pos2];
                    words[pos2] = old;
                }
              
            }
            Console.WriteLine(string.Join("\r\n", words));
        }
    }
}
