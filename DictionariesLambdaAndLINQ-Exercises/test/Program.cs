using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
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

            var list = populationCounter.Keys.ToList();
            list.Sort();
            foreach (var countryes in populationCounter) // РАБОТИ, НО НЕ Е СОРТИРАН!!
            {
                var countryPrint = countryes.Key;
                var populationPrint = countryes.Value;
                var totalPopulationSum = populationPrint.Sum(a => a.Value);
                Console.WriteLine($"{countryPrint} (total population {totalPopulationSum})");
                var orderedDict = populationCounter[countryes.Key].
                    OrderByDescending(x => x.Value).
                    ToDictionary(x => x.Key, x => x.Value);

                foreach (var item in orderedDict)
                {
                    Console.WriteLine($"=>{item.Key}: {item.Value}");
                }

            }
        }
    }
}
