using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.WordCount
{
    class WordCount
    {
        

        static void Main(string[] args)
        {
            string[]  findWords = File.ReadAllText("words.txt")
                .ToLower()
                .Split();           
            string[] text = File.ReadAllText("input.txt")
                .ToLower()
                .Split(new char[] {'\n', '\r', ' ', '.', ',', '!', '?', '-' },
                StringSplitOptions.RemoveEmptyEntries);
            var wordCount = new Dictionary<string, int>();
            foreach (string word in findWords)
            {
                wordCount[word] = 0;               
            }
            foreach (var word in text)
            {
                if (wordCount.ContainsKey(word))
                {
                    wordCount[word]++;
                }
            }
            foreach (var word in wordCount.OrderByDescending(a => a.Value))
            {
                File.AppendAllText(@"outputs.txt", $"{word.Key} - {word.Value}{Environment.NewLine}");
            }

            Console.WriteLine(File.ReadAllText("outputs.txt"));
        }
    }
}
