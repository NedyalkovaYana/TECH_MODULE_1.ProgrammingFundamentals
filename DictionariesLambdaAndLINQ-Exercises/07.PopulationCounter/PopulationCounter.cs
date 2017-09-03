using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PopulationCounter
{
    class PopulationCounter
    {
        static void Main(string[] args)
        {
            var populationCounter = new Dictionary<string, Dictionary<string, long>>();
            var input = Console.ReadLine().Split('|');
          
            while (input[0] != "report")
            {
               
                var city = input[0];
                var country = input[1];
                int population = int.Parse(input[2]);

                if (!populationCounter.ContainsKey(country))
                {
                    populationCounter[country] = new Dictionary<string, long>();
                }

                if (!populationCounter[country].ContainsKey(city))
                {
                    populationCounter[country][city] = population;
                }
                else
                {
                    populationCounter[country][city] += population;
                   
                }
                input = Console.ReadLine().Split('|');
            }

            Dictionary<string, long> mergeDict = new Dictionary<string, long>();
            foreach (var item in populationCounter)
            {
                mergeDict[item.Key] = item.Value.Values.Sum();
            }
            foreach (var item in mergeDict.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{item.Key} (total population: {item.Value})");
                foreach (var index in populationCounter[item.Key].OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"=>{index.Key}: {index.Value}");
                }
            }

            //foreach (var countryes in populationCounter) // РАБОТИ, НО НЕ Е СОРТИРАН!!
            //{
            //    var countryPrint = countryes.Key;
            //    var populationPrint = countryes.Value;
            //    var totalPopulationSum = populationPrint.Sum(a => a.Value);
            //    Console.WriteLine($"{countryPrint} (total population {totalPopulationSum})");
            //    var orderedDict = populationCounter[countryes.Key].
            //        OrderByDescending(x => x.Value).
            //        ToDictionary(x => x.Key, x => x.Value);

            //    foreach (var item in orderedDict)
            //    {
            //        Console.WriteLine($"=>{item.Key}: {item.Value}");
            //    }

            //}
        }          
    }
}

