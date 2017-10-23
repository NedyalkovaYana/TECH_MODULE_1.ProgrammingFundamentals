using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace _04.Population_Aggregation
{
    class Program
    {
        class Country
        {
            public string Name { get; set; }
            public List<string> Town { get; set; }
            public List<long>  Population { get; set; }
            public long TownCount { get; set; }
        }
        static void Main()
        {
            List<Country> countryList = new List<Country>();

            string[] input = Console.ReadLine().Split('\\');
            while (input[0] != "stop")
            {
                if (input[0].Any(c => char.IsUpper(c)))
                {
                    string country = ClearWord(input[0]);
                    string town = ClearWord(input[1]);
                    long population = long.Parse(input[2]);
                    var newCountry = AddInformation(country, town, population, countryList);
                }
                else
                {
                    string town = ClearWord(input[0]);
                    string country = ClearWord(input[1]);
                    long population = long.Parse(input[2]);
                    var newTown = AddInformation(country, town, population, countryList);
                }
                input = Console.ReadLine().Split('\\');

            }

            foreach (var country in countryList.OrderBy(a => a.Name))
            {
                Console.WriteLine($"{country.Name} -> {country.Town.Count}");
            }

            foreach (var population in countryList.OrderByDescending(x => x.Population.Max()))
            {             
                Console.WriteLine($"{population.Town} -> {population.Population}");
            }

        }

        static object AddInformation(string country, string town, long population, List<Country> countryList)
        {
            foreach (var countr in countryList)
            {
                if (countr.Name.Contains(country))
                {                  
                    countr.Town.Add(town);
                    countr.Population.Add(population);
                    break;
                }
            }
            if (countryList.Count == 0)
            {
                var currentCountry = new Country
                {
                    Name = country,
                    Town = new List<string>(),
                    Population = new List<long>(),
                };
                currentCountry.Town.Add(town);
                currentCountry.Population.Add(population);
                countryList.Add(currentCountry);
            }
            var isContains = countryList.FindIndex(a => a.Name == country);
            if (isContains == -1)
            {
                var currentCountry = new Country
                {
                    Name = country,
                    Town = new List<string>(),
                    Population = new List<long>(),
                };
                currentCountry.Town.Add(town);
                currentCountry.Population.Add(population);
                countryList.Add(currentCountry);
            }
            return countryList;
        }
        

        private static string ClearWord(string word)
        {
            char[] clearedCountry = word.ToCharArray();
            string clearedWord = String.Empty;
            for (int i = 0; i < clearedCountry.Length; i++)
            {
                if (char.IsLetter(clearedCountry[i]))
                {
                    clearedWord += clearedCountry[i];
                }
            }
            return clearedWord;
        }
    }
}
