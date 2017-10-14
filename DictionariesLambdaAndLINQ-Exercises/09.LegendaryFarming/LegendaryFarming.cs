using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.LegendaryFarming
{
    class LegendaryFarming
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyMaterial = new Dictionary<string, int>();

            keyMaterial["shards"] = 0;
            keyMaterial["fragments"] = 0;
            keyMaterial["motes"] = 0;

            Dictionary<string, int> junk = new Dictionary<string, int>();

            bool getMaterial = true;
            string win = string.Empty;
            while (getMaterial)
            {
               List<string> line = Console.ReadLine().ToLower().Split(' ').ToList();

                for (int i = 0; i < line.Count; i += 2)
                {
                    int quantity = int.Parse(line[i]);
                    string material = line[i + 1];

                    if (keyMaterial.ContainsKey(material))
                    {
                        keyMaterial[material] += quantity;

                        if (keyMaterial[material] >= 250)
                        {
                            win = material;
                            keyMaterial[material] -= 250;
                            getMaterial = false;
                            break;
                        }
                    }
                    else
                    {
                        if (!junk.ContainsKey(material))
                        {
                            junk.Add(material, 0);
                        }
                        junk[material] += quantity;
                    }

                    
                }
            }
            string first = PrintWin(win);
            Console.WriteLine(PrintWin(win) + " obtained!");

            foreach (var keys in keyMaterial.OrderByDescending(a => a.Value).ThenBy(a => a.Key))
            {
                Console.WriteLine($"{keys.Key}: {keys.Value}");
            }

            foreach (var material in junk.OrderBy(a => a.Key))
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
        }

        static string PrintWin(string win)
        {
            string wins = string.Empty;
            switch (win)
            {
                case "shards":
                    wins = "Shadowmourne";
                    break;
                case "fragments":
                    wins =  "Valanyr";
                    break;
                case "motes":
                    wins = "Dragonwrath";
                    break;
            }
            return wins;
        }
    }
}
