using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainlandsWithClass
{
    class Program
    {      
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> trainDict = new Dictionary<string, Dictionary<string, long>>();
            string inputsTrains = String.Empty;
            while ((inputsTrains = Console.ReadLine()) != "It's Training Men!")
            {
                if (inputsTrains.Contains("->"))
                {
                    string[] tokens = inputsTrains.Trim().Split(new string[] { "->" }, StringSplitOptions.RemoveEmptyEntries);
                    string locomotiveName = tokens[0].Trim();
                    if (tokens[1].Contains(":"))
                    {
                        string[] wagonNameAndPower = tokens[1].Trim().Split(':');
                        string wagonName = wagonNameAndPower[0].Trim();
                        long wagonPower = long.Parse(wagonNameAndPower[1].Trim());

                        if (!trainDict.ContainsKey(locomotiveName))
                        {
                            trainDict[locomotiveName] = new Dictionary<string, long>();
                            trainDict[locomotiveName][wagonName] = wagonPower;
                        }
                        else
                        {
                            trainDict[locomotiveName].Add(wagonName, wagonPower);
                        }
                    }
                    else
                    {
                        string locomotiveToRemove = tokens[1].Trim();

                        if (!trainDict.ContainsKey(locomotiveName))
                        {
                            trainDict.Add(locomotiveName, new Dictionary<string, long>());
                        }

                        foreach (var trains in trainDict)
                            {
                                if (trains.Key == locomotiveToRemove)
                                {
                                    foreach (var wagon in trains.Value)
                                    {
                                        if (!trainDict[locomotiveName].ContainsKey(wagon.Key))
                                        {
                                           trainDict[locomotiveName].Add(wagon.Key, wagon.Value);
                                        }
                                        else
                                        {
                                            trainDict[locomotiveName].Add(wagon.Key, wagon.Value);
                                        }
                                    }
                                }
                            }
                            trainDict.Remove(locomotiveToRemove);
                        
                    }
                }
                else
                {
                    string[] tokens = inputsTrains.Trim().Split('=');
                    string locoNameToCopyWagons = tokens[0].Trim();
                    string locoNameCopyFrom = tokens[1].Trim();

                    if (!trainDict.ContainsKey(locoNameToCopyWagons))
                    {
                        trainDict[locoNameToCopyWagons] = new Dictionary<string, long>();
                    }
                    else
                    {
                        trainDict.Remove(locoNameToCopyWagons);
                        trainDict.Add(locoNameToCopyWagons, new Dictionary<string, long>());
                    }
                    foreach (var trains in trainDict)
                    {
                        if (trains.Key == locoNameCopyFrom)
                        {                          
                            foreach (var wagons in trains.Value)
                            {                               
                                if (!trainDict.ContainsKey(wagons.Key))
                                {
                                    trainDict[locoNameToCopyWagons].Add(wagons.Key, wagons.Value);
                                }
                                else
                                {

                                    trainDict[locoNameToCopyWagons][wagons.Key] = wagons.Value;
                                }
                            }
                        }
                    }
                }

            }

            foreach (var trains in trainDict.OrderByDescending(a => a.Value.Values.Sum()).ThenBy(w => w.Value.Count))
            {
                Console.WriteLine($"Train: {trains.Key}");
                foreach (var wagons in trains.Value.OrderByDescending(a => a.Value))
                {
                    Console.WriteLine($"###{wagons.Key} - {wagons.Value}");   
                }
            }

        }
    }
}
