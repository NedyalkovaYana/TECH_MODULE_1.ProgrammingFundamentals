using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _04.Phoenix_Oscar_Romeo_November
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, HashSet<string>> creatureList = new Dictionary<string, HashSet<string>>();

            string input = Console.ReadLine();
            while (input != "Blaze it!")
            {
                input = Console.ReadLine();
                string[] tokens = input.Trim().Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries);
                string creatureName = tokens[0];
                if (creatureName == "Blaze it!")
                {
                    break;
                }
                string creatureSquadMate = tokens[1];

                if (creatureName == creatureSquadMate)
                {
                    continue;
                }
                if (!creatureList.ContainsKey(creatureName))
                {
                    creatureList[creatureName] = new HashSet<string>();
                    creatureList[creatureName].Add(creatureSquadMate);
                }             
                creatureList[creatureName].Add(creatureSquadMate);
            }
           var sortedDict = new Dictionary<string, int>();

            foreach (var nameMate in creatureList)
            {
                var mates = CheckTheRealMate(creatureList, nameMate);
                sortedDict[nameMate.Key] = mates;
            }

            foreach (var item in sortedDict.OrderByDescending(a => a.Value))
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }

        }

        private static int CheckTheRealMate(Dictionary<string, HashSet<string>> creatureList, KeyValuePair<string, HashSet<string>> nameMate)
        {
            var matesNumber = nameMate.Value.Count;
            //var creature = nameMate.Key;
            foreach (var creature in creatureList)
            {
                string crName = creature.Key;
                var crSquareMate = creature.Value;
                foreach (var frends in crSquareMate)
                {
                    if (crSquareMate.Contains(crName))
                    {
                        
                    }   
                }
            }
            return matesNumber;
        }
    }
}
