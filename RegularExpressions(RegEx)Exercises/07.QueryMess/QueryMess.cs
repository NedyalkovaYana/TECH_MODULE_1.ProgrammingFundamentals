using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _07.QueryMess
{
    class QueryMess   //ДА СИ ОПРАВЯ ПРИНТИРАНЕТО
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> results = new Dictionary<string, List<string>>();
            string text = Console.ReadLine();

            string pattern = @"(?<key>\w+)=(?<value>\w+)&*";
            while (text != "END")
            {
                var matches = Regex.Matches(text, pattern);
  
                foreach (Match match in matches)
                {
                    var key = match.Groups["key"].Value;
                    var value = match.Groups["value"].Value;

                    if (!results.ContainsKey(key))
                    {
                        List<string> values = new List<string>();
                        values.Add(value);
                        results.Add(key, values);
                    }
                    else if (results.ContainsKey(key))
                    {
                        results[key].Add(value);
                    }
                  
                    //Console.Write($"{match.Groups["key"].Value}=[{match.Groups["value"].Value}]");
                }            
                text = Console.ReadLine();
            }
            foreach (var pair in results)
            {
                Console.Write("{0}=[{1}]", pair.Key, string.Join(", ", pair.Value));
                
            }
            Console.WriteLine();
        }
    }
}
