using System.Text;
using System.Text.RegularExpressions;

namespace Exam
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            var replace = Console.ReadLine().Split(new string[] {"{", "}"}, StringSplitOptions.RemoveEmptyEntries).ToList();

            var patternWord = @"(?<first>[a-zA-Z]+)(?<delimeters>.*)(?<t>\1)";
            Regex regex = new Regex(patternWord);

            var match = regex.Matches(input);        
                
            foreach (Match word in match)
            {
                var start = word.Groups["first"].Value;
                var delimeters = word.Groups["delimeters"].Value;
                var end = word.Groups["t"].Value;
                var replaceWord = replace[0];

                if (input.Contains(start) && input.Contains(end))
                {
                    
                   input = input.Replace(delimeters, replaceWord);

                    if (replace.Count > 1)
                    {
                        replace.RemoveAt(0);
                    }
                    
                }
            }
            
            Console.WriteLine(input);
        }
    }
}
