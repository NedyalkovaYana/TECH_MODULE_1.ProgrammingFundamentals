using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Palindromes
{
    class Palindromes
    {
        static void Main(string[] args)
        {
            HashSet<string> uniqePaliondromes = new HashSet<string>();
            string input = Console.ReadLine();
            string pattern = @"\w+";
            var matches = Regex.Matches(input, pattern);
            var listWords = new List<string>();

            foreach (Match match in matches)
            {
                string word = match.Value;
                listWords.Add(word);
            }
            foreach (var word in listWords)
            {
                bool isOnlyLower = word.Count(c => Char.IsLower(c)) == word.Length;
                bool isOnlyUpper = word.Count(a => Char.IsUpper(a)) == word.Length;

                if (isOnlyUpper)
                {
                   uniqePaliondromes.Add(word);
                }
                if (isOnlyLower)
                {
                   IsPalindrome(word, uniqePaliondromes);                  
                }
            }

            Console.WriteLine(string.Join(", ", uniqePaliondromes.OrderBy(a => a)));
        }
        private static bool IsPalindrome(string word, HashSet<string> uniqePaliondromes)
        {
            int min = 0;
            int max = word.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    uniqePaliondromes.Add(word);
                    return true;
                }
                char a = word[min];
                char b = word[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
        }
    }
}
