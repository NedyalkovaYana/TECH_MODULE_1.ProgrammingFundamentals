using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Population
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> populations = new Dictionary<string, Dictionary<string, long>>();
            string input = Console.ReadLine();

            while (input != "report")
            {
                string[] tokens = input.Split('|');
                string cities = tokens[0];
                string country = tokens[1];
                long population = long.Parse(tokens[2]);

                if (!populations.ContainsKey(country))
                {
                    populations.Add(country, new Dictionary<string, long>());
                }
                if (!populations[country].ContainsKey(cities))
                {
                    populations[country].Add(cities, 0);
                }
                populations[country][cities] += population;
                input = Console.ReadLine();
            }
            foreach (var item in populations.OrderByDescending(c => c.Value.Values.Sum()))
            {
                Console.WriteLine($"{item.Key} (total populatin: {item.Value.Values.Sum()}");
                foreach (var city in item.Value.OrderByDescending( a => a.Value))
                {
                    Console.WriteLine($"=> {city.Key}: {city.Value}");
                }
            }
        }
    }
}
