using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[26];
            for (int i = 0; i < alphabet.Length; i++)
            {
                alphabet[i] = (char)('a' + i);
            }
            string word = File.ReadAllText("input.txt");
            File.Delete("output.txt");
            using (var writer = File.AppendText("output.txt"))
            {
                foreach (var letter in word)
                {
                    for (int index = 0; index < alphabet.Length; index++)
                    {
                        if (letter == alphabet[index])
                        {
                          writer.WriteLine($"{letter} -> {index}"); //Console.WriteLine($"{letter} -> {index}");
                        }
                    }
                }
            }
        }
    }
}
