using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NSA
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> spysDict = new Dictionary<string, Dictionary<string, int>>();

            string input = String.Empty;
            while ((input = Console.ReadLine()) != "quit")
            {
                string[] spysInfo = input.Trim().Split(new string[] {"->"}, StringSplitOptions.RemoveEmptyEntries);
                string country = spysInfo[0].Trim();
                string spysName = spysInfo[1].Trim();
                int spysWorkingDays = int.Parse(spysInfo[2].Trim());


                if (!spysDict.ContainsKey(country))
                {
                    spysDict[country] = new Dictionary<string, int>();
                    spysDict[country].Add(spysName, spysWorkingDays);
                }
                if (spysDict[country].ContainsKey(spysName))
                {
                    spysDict[country][spysName] = spysWorkingDays;
                }
                else
                {
                    spysDict[country].Add(spysName, spysWorkingDays);
                }
            }

            foreach (var country in spysDict.OrderByDescending(a => a.Value.Count))
            {
                Console.WriteLine($"Country: {country.Key}");

                foreach (var spys in country.Value.OrderByDescending(a => a.Value))
                {
                    Console.WriteLine($"**{spys.Key} : {spys.Value}");
                }
            }
        }
    }
}
