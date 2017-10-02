using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.MagicExchangeableWords
{
    class MagicExchangeableWords
    {
        static void Main(string[] args)
        {
            Dictionary<char, char> dict = new Dictionary<char, char>();

            string[] input = Console.ReadLine().Split();
            string wordOne = input[0];
            string wordTwo = input[1];

            int minLenght = Math.Min(wordOne.Length, wordTwo.Length);
            bool isExchangeable = true;

            for (int i = 0; i < minLenght; i++)
            {
                if (! dict.ContainsKey(wordOne[i]))
                {
                    if (!dict.ContainsKey(wordTwo[i]))
                    {
                        dict.Add(wordOne[i], wordTwo[i]);
                    }
                    else
                    {
                        isExchangeable = false;
                        break;
                    }
                }
                else
                {
                    if (dict[wordOne[i]] != wordTwo[i])
                    {
                        isExchangeable = false;
                        break;
                    }
                }
            }

            string rest = string.Empty;
            if (wordOne.Length > wordTwo.Length)
            {
                rest = wordOne.Substring(minLenght);
            }
            else
            {
                rest = wordTwo.Substring(minLenght);
            }

            foreach (char item in rest)
            {
                if (!dict.ContainsValue(item) && !dict.ContainsKey(item))
                {
                    isExchangeable = false;
                }
            }
            Console.WriteLine(isExchangeable.ToString().ToLower());
        }
    }
}
