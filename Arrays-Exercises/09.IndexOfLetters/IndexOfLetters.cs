using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main(string[] args)
        {
            char[] allLettersFromAlfabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            string inputWord = Console.ReadLine();
   
            for (int i = 0; i < inputWord.Length; i++)
            {
                Console.WriteLine(inputWord[i] + " -> " + Array.IndexOf(allLettersFromAlfabet, inputWord[i]));
            }

            // Второ работещо решение!!!
            //string word = Console.ReadLine();

            //foreach (char letter in word)
            //{
            //    Console.WriteLine($"{letter} -> {letter - 'a'}");
            //}
        }
    }
}
