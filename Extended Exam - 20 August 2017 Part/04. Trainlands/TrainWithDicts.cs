using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Trainlands
{
    class TrainWithDicts
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> locomotivAndWagonNames = new Dictionary<string, List<string>>();
            Dictionary<string, int> wagonNamesAndPower = new Dictionary<string, int>();

            string inputsTrains = String.Empty;
            while ((inputsTrains = Console.ReadLine()) != "It's Training Men!")
            {
                if (inputsTrains.Contains("->"))
                {
                    string[] tokens = inputsTrains.Trim().Split(new string[] {"->"}, StringSplitOptions.RemoveEmptyEntries);
                    string locomotiveName = tokens[0];
                    if (tokens[1].Contains(":"))
                    {
                        string[] wagonNameAndPower = tokens[1].Trim().Split(':');
                        string wagonName = wagonNameAndPower[0];
                        int wagonPower = int.Parse(wagonNameAndPower[1]);

                        if (!locomotivAndWagonNames.ContainsKey(locomotiveName))
                        {
                            locomotivAndWagonNames[locomotiveName] = new List<string>();
                        }
                        locomotivAndWagonNames[locomotiveName].Add(wagonName);               
                        wagonNamesAndPower.Add(wagonName, wagonPower);
                    }
                    else
                    {
                        string wagonName = tokens[1];
                        string locomotivForRemove = String.Empty;
                        if (!locomotivAndWagonNames.ContainsKey(locomotiveName))
                        {
                            locomotivAndWagonNames[locomotiveName] = new List<string>();
                        }
                        if (locomotivAndWagonNames.ContainsKey(wagonName))
                        {
                            foreach (var wagon in locomotivAndWagonNames.Values)
                            {
                                locomotivAndWagonNames[locomotiveName].AddRange(wagon);
                            }
                        }
                        locomotivAndWagonNames.Remove(wagonName);
                    }
                }
                else
                {
                    string[] tokens = inputsTrains.Trim().Split('=');
                    string locoNameToCopyWagons = tokens[0];
                    string locoNameCopyFrom = tokens[1];

                    if (!locomotivAndWagonNames.ContainsKey(locoNameToCopyWagons))
                    {
                        locomotivAndWagonNames.Add(locoNameToCopyWagons, new List<string>());
                    }
                    if (locomotivAndWagonNames.ContainsKey(locoNameCopyFrom))
                    {
                        foreach (var wagon in locomotivAndWagonNames.Values)
                        {
                            locomotivAndWagonNames[locoNameToCopyWagons].AddRange(wagon);
                        }
                    }                    
                }

            }

            foreach (var VARIABLE in COLLECTION)
            {
                
            }
        }
    }
}
