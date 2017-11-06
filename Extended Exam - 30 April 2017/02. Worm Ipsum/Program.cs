using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Worm_Ipsum
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentencePattern = @"^[A-Z][^\.]+\.$";
            string wordsPattern = @"[a-zA-Z]+";

            string input = Console.ReadLine();

            while (!input.Equals("Worm Ipsum"))
            {
                Match sentence = Regex.Match(input, sentencePattern);

                if (sentence.Success)
                {
                    MatchCollection words = Regex.Matches(input, wordsPattern);

                    foreach (Match word in words)
                    {
                        string currentWord = word.ToString();
                        char mostFreqChar = ' ';

                        if (currentWord.Length != currentWord.Distinct().Count())
                        {
                            int maxCount = 0;

                            for (int i = 0; i < currentWord.Length; i++)
                            {
                                int count = 0;

                                for (int j = i; j < currentWord.Length; j++)
                                {
                                    if (currentWord[i].Equals(currentWord[j]))
                                    {
                                        count++;

                                        if (count > maxCount)
                                        {
                                            maxCount = count;
                                            mostFreqChar = currentWord[i];
                                        }
                                    }
                                }
                            }

                            if (maxCount >= 2)
                            {
                                string replacer = new string(mostFreqChar, word.Length);
                                input = Regex.Replace(input, word.ToString(), replacer);
                            }
                        }
                    }
                    Console.WriteLine(input);
                }
                input = Console.ReadLine();
            }
        }
    }
}
