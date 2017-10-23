using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Population_with_Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, long> countryTownDict = new Dictionary<string, long>();
            Dictionary<string, long> townPopulationDict = new Dictionary<string, long>();

            string[] input = Console.ReadLine().Split('\\');
            while (input[0] != "stop")
            {
                if (input[0].Any(c => char.IsUpper(c)))
                {
                    string country = ClearWord(input[0]);
                    string town = ClearWord(input[1]);
                    long population = long.Parse(input[2]);

                    if (!countryTownDict.ContainsKey(country))
                    {
                        countryTownDict[country] = 1;
                    }
                    else
                    {
                        countryTownDict[country]++;
                    }

                    if (townPopulationDict.ContainsKey(town))
                    {
                        townPopulationDict[town] = population;
                    }
                    else
                    {
                        townPopulationDict.Add(town, population);
                    }
                }
                else
                {
                    string town = ClearWord(input[0]); 
                    string country = ClearWord(input[1]);
                    long population = long.Parse(input[2]);

                    if (!townPopulationDict.ContainsKey(town))
                    {
                        townPopulationDict[town] = population;
                    }
                    else
                    {
                        townPopulationDict[town] = population;
                    }
                    if (countryTownDict.ContainsKey(country))
                    {
                        countryTownDict[country] += 1;
                    }
                    else
                    {
                        countryTownDict.Add(country, 1);
                    }                  
                }
                input = Console.ReadLine().Split('\\');
            }

            foreach (var countrues in countryTownDict.OrderBy(a => a.Key))
            {
                Console.WriteLine($"{countrues.Key} -> {countrues.Value}");
            }
            int count = 0;
            foreach (var population in townPopulationDict.OrderByDescending(a => a.Value))
            {
                Console.WriteLine($"{population.Key} -> {population.Value}");
                count++;
                if (count == 3)
                {
                    break;
                }
            }
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
