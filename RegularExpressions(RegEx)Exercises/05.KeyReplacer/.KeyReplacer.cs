﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.KeyReplacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string keys = Console.ReadLine();
            string text = Console.ReadLine();
            string pattern = @"(?<startKey>\w*)(?:\<|\||\\)(?:.+)(?:\<|\||\\)(?<endKey>\w*)";
            var keyMatch = Regex.Match(keys, pattern);

            if (keyMatch.Success)
            {
                var startKey = keyMatch.Groups["startKey"].Value;
                var endKey = keyMatch.Groups["endKey"].Value;

                var textPattern = $@"{startKey}(?<word>.*?){endKey}";
                var matches = Regex.Matches(text, textPattern);

                var result = new StringBuilder();
                foreach (Match match in matches)
                {
                    result.Append(match.Groups["word"].Value);
                }
                Console.WriteLine(result.ToString().Length ==0 ? "Empty result" : result.ToString());
            }

        }
    }
}
