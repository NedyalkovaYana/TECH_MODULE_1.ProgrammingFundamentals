using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _06.EmailStatistics
{
    class EmailStatistics
    {
        static void Main(string[] args)
        {
            string pattern = @"^(?<username>[A-Za-z]{5,})@(?<domein>[a-z]{3,}\.(bg|org|com))$";
            Regex regex = new Regex(pattern);

            int n = int.Parse(Console.ReadLine());
            Dictionary<string, HashSet<string>> emails = new Dictionary<string, HashSet<string>>();

            for (int i = 0; i < n; i++)
            {
                string wannaBeEmail = Console.ReadLine();
                Match match = regex.Match(wannaBeEmail);
                if (match.Success)
                {                 
                    string username = match.Groups["username"].Value;
                    string domain = match.Groups["domein"].Value;

                    if (!emails.ContainsKey(domain))
                    {
                        emails[domain] = new HashSet<string>();
                    }
                    //if (!emails[domain].Contains(username))
                    //{
                    //    emails[domain].Add(username);
                    //}
                    emails[domain].Add(username);

                }

            }
            foreach (KeyValuePair<string, HashSet<string>> item in 
                emails.OrderByDescending(u=> u.Value.Count))
            {
                Console.WriteLine(item.Key + ":");
                foreach (var usernames in item.Value)
                {
                    Console.WriteLine($"### " + usernames);
                }
            }
        }
    }
}
