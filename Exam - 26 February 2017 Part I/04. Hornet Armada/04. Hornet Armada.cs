using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hornet_Armada
{
    class Program
    {
       

        static void Main(string[] args)
        {
            Dictionary<string, long> legionsActivitiesAndNames = new Dictionary<string, long>();
            Dictionary<string, Dictionary<string, long>> legionNamesAndSolider = new Dictionary<string, Dictionary<string, long>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputLegion = Console.ReadLine()
                    .Split(new string[] {" = ", " -> ", ":"}, StringSplitOptions.RemoveEmptyEntries).ToArray();

                long lastActivity = long.Parse(inputLegion[0]);
                string legionName = inputLegion[1];
                string soliderType = inputLegion[2];
                long soliderCount = long.Parse(inputLegion[3]);

                if (!legionsActivitiesAndNames.ContainsKey(legionName))
                {
                    legionsActivitiesAndNames.Add(legionName, lastActivity);
                    legionNamesAndSolider.Add(legionName, new Dictionary<string, long>());
                }
                if (lastActivity > legionsActivitiesAndNames[legionName])
                {
                    legionsActivitiesAndNames[legionName] = lastActivity;
                }
                if (!legionNamesAndSolider[legionName].ContainsKey(soliderType))
                {
                    legionNamesAndSolider[legionName].Add(soliderType, 0);
                }
                legionNamesAndSolider[legionName][soliderType] += soliderCount;
            }
            string[] legionPrint = Console.ReadLine()
                .Split('\\').ToArray();

            if (legionPrint.Length > 1)
            {
                long activity = long.Parse(legionPrint[0]);
                string soliderType = legionPrint[1];

                foreach (var legion in legionNamesAndSolider
                    .Where(legion => legion.Value.ContainsKey(soliderType)).OrderByDescending(legion => legion.Value[soliderType]))
                {
                    if (legionsActivitiesAndNames[legion.Key] < activity)
                    {
                        Console.WriteLine("{0} -> {1}", legion.Key, legionNamesAndSolider[legion.Key][soliderType]);
                    }
                }

            }
            else
            {
                string soliderType = legionPrint[0];

                foreach (var legion in legionsActivitiesAndNames.OrderByDescending(legion => legion.Value))
                {
                    Console.WriteLine($"{legion.Value} : {legion.Key}");
                }
            }
        }
    }
}


