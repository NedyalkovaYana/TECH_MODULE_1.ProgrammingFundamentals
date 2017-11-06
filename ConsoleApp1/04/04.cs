using System.Collections.Generic;

namespace Exam
{
    using System;
    using System.Linq;
    class Program
    {
        static void Main()
        {
            var validData = new Dictionary<string, Dictionary<string, long>>();
            var failData = new Dictionary<string, Dictionary<string, long>>();
            var input = string.Empty;
            while ((input = Console.ReadLine()) != "thetinggoesskrra")
            {
                var tokens = input.Split(new string[] { " -> ", " | " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (tokens.Length > 1)//ADDB444 -> 23111 | BankAccounts
                {
                    //•	{dataKey} -> {dataSize} | {dataSet}
                    var dataKey = tokens[0].Trim();
                    var dataSize =long.Parse(tokens[1].Trim());
                    var dataSetTogether = tokens[2].Trim();


                    if (!validData.ContainsKey(dataSetTogether))
                    {
                        validData.Add(dataSetTogether, new Dictionary<string, long>());
                    }
                    if (failData.ContainsKey(dataSetTogether))
                    {
                        if (validData.ContainsKey(dataSetTogether))
                        {
                            validData[dataSetTogether] = new Dictionary<string, long>();
                            foreach (var set in failData)
                            {
                                foreach (var pr in set.Value)
                                {
                                    validData[dataSetTogether].Add(pr.Key, pr.Value);
                                }
                            }
                        }
                    }
                   else  if (validData.ContainsKey(dataSetTogether))
                    {
                        validData[dataSetTogether].Add(dataKey, dataSize);
                    }
                    else
                    {
                        if (!failData.ContainsKey(dataSetTogether))
                        {
                            failData[dataSetTogether] = new Dictionary<string, long>() {{dataKey, dataSize}};
                        }
                        else
                        {
                            failData[dataSetTogether].Add(dataKey, dataSize);
                        }
                    }
                }
                else
                {
                    var dataSetMain = input;
                    if (!validData.ContainsKey(dataSetMain))
                    {
                        validData.Add(dataSetMain, new Dictionary<string, long>());
                    }
                }
            }

            foreach (var pairs in validData.OrderByDescending(a => a.Value.Values.Sum()))
            {//Data Set: {dataSet}, Total Size: {sumOfAllDataSizes}
                Console.WriteLine($"Data Set: {pairs.Key}, Total Size: {pairs.Value.Values.Sum()}");
                foreach (var pb in pairs.Value)
                {
                    Console.WriteLine($"$.{pb.Key}");
                    
                }
                return;
            }
        }
    }
}
