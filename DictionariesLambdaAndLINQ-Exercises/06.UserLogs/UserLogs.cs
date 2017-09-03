using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.UserLogs
{
    class UserLogs
    {
        static void Main(string[] args) //63/100
        {
            var usernamesIps = new SortedDictionary<string,
                SortedDictionary<string, int>>();
         
            var command = Console.ReadLine().Split();
            var ip = String.Empty;
            var name = string.Empty;
            while (command[0] != "end")
            {
                var names = command[2].Skip(5).ToArray();
                name = new string(names);
                var ips = command[0].Skip(3).ToArray();
                ip = new string(ips);

                if (!usernamesIps.ContainsKey(name))
                {
                    usernamesIps[name] = new SortedDictionary<string, int>();

                }
                if (!usernamesIps[name].ContainsKey(ip))
                {
                    usernamesIps[name][ip] = 1;
                  
                }
                else
                {
                    usernamesIps[name][ip] += 1;
                   
                }

                command = Console.ReadLine().Split();
            }
            PrintDicttionary(usernamesIps);
        }

        static void PrintDicttionary(SortedDictionary<string, SortedDictionary<string, int>> usernamesIps)
        {

            foreach (var userName in usernamesIps.Keys)
            {
                Console.WriteLine($"{userName}:");
                var orderedDict = usernamesIps[userName].OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
                string print = "";
                foreach (var ip in orderedDict.Keys)
                {
                    print += $"{ip} => {usernamesIps[userName][ip]}, ";
                }
                print = print.Substring(0, print.Length - 2);
                print += ".";
                Console.WriteLine(print);
            }
        }
    }
}
