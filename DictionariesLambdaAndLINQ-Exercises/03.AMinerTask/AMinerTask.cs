using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AMinerTask
{
    class AMinerTask
    {
        static void Main(string[] args)
        {
            
            List<string> resourseList = new List<string>();
            List<string> quantityList = new List<string>();
            bool canContinue = true;
            int count = 0;
            string resourse;
            while (canContinue)
            {
                count++;
                if (count % 2 == 0)
                {
                   string quantity = Console.ReadLine();
                    quantityList.Add(quantity);
                }
                else
                {
                     resourse = Console.ReadLine();
                    if (resourse == "stop")
                    {
                        break;
                    }
                    resourseList.Add(resourse);
                   
                }
            }

            var dictionary = resourseList.Zip(quantityList, (k, v) => new { Key = k, Value = v })
                     .ToDictionary(x => x.Key, x => x.Value);

            foreach (var element in dictionary)
            {
                if (dictionary.ContainsKey(element.Key))
                {
                    dictionary[element.Key] += element.Value;
                }
            }
            foreach (var item in dictionary)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
