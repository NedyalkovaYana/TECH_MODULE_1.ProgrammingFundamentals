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
            List<string> participiant =
                Console.ReadLine().Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> songs = Console.ReadLine().Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries).ToList();

            Dictionary<string, List<string>> awards = new Dictionary<string, List<string>>();


            while (true)
            {
                string[] command = Console.ReadLine().Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (command[0] == "dawn")
                {
                    break;
                }

                string participian = command[0];
                string song = command[1];
                string award = command[2];

                if (participiant.Contains(participian) && songs.Contains(song))
                {                  
                    if (!awards.ContainsKey(participian))
                    {
                        awards.Add(participian, new List<string>());
                        awards[participian].Add(award);
                    }
                    else
                    {
                        if (awards[participian].Contains(award))
                        {
                            continue;
                        }
                        else
                        {
                            awards[participian].Add(award);
                        }
                        
                    }
                    

                }              
                else
                {
                    continue;
                }
            }

            if (awards.Count > 0)
            {
                foreach (var participian in awards.OrderByDescending(a => a.Value.Count).ThenBy(a => a.Key))
                {
                    Console.WriteLine($"{participian.Key}: {participian.Value.Distinct().ToList().Count} awards");
                    foreach (var award in participian.Value.OrderBy(a => a))
                    {
                        Console.WriteLine($"--{award}");
                    }
                }
            }
            else
            {
                Console.WriteLine("No awards");
            }
        }
    }
}
