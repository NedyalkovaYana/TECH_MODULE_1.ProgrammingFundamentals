using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SoftUni_Karaoke
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> awards = new Dictionary<string, List<string>>();
            List<string> participiant = Console.ReadLine().Trim()
                .Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> songs = Console.ReadLine().Trim()
                .Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();
            string input = String.Empty;
            while ((input = Console.ReadLine()) != "dawn")
            {
                string[] tokens = input.Trim().Split(',');
                string participiantName = tokens[0].Trim();
                string currentSong = tokens[1].Trim();
                string award = tokens[2].Trim();

                if (participiant.Contains(participiantName) && songs.Contains(currentSong))
                {  
                    if (!awards.ContainsKey(participiantName))
                    {
                        awards[participiantName] = new List<string>(){award};
                    }
                   else if (awards.Any(a => a.Value.Contains(award)))
                    {
                        continue;
                    }
                    else
                    {
                        awards[participiantName].Add(award);
                    }
                    
                }
            }
            if (awards.Count == 0)
            {
                Console.WriteLine("No awards");
                return;
            }

            foreach (var partisipiant in awards.OrderByDescending(a => a.Value.Count).ThenBy(a => a.Key))
            {
                Console.WriteLine($"{partisipiant.Key}: {partisipiant.Value.Count} awards");
                foreach (var award in partisipiant.Value.OrderBy(a => a))
                {
                    Console.WriteLine($"--{award}");
                }

            }
        }
    }
}
