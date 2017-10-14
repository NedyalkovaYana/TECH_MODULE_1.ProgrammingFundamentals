using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace logUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> userAndId = new Dictionary<string, Dictionary<string, int>>();

            while (true)
            {
                string[] command = Console.ReadLine().Split(new char[]{' ', '='}, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (command[0] == "end")
                {
                    break;
                }
                var ip = command[1];
                var username = command[5];

                if (!userAndId.ContainsKey(username))
                {
                    userAndId[username] = new Dictionary<string, int>();
                }
             
                
                if (!userAndId[username].ContainsKey(ip))
                {
                    userAndId[username].Add(ip, 0);
                }
                userAndId[username][ip]++;
            }

            PrintDictionary(userAndId);
        }

        private static void PrintDictionary(Dictionary<string, Dictionary<string, int>> userAndId)
        {
            
            foreach (var item in userAndId.OrderBy(a => a.Key))
            {
                Console.WriteLine($"{item.Key}:");               
                string print = "";
                foreach (var ip in item.Value)
                {
                    print += $"{ip.Key} => {ip.Value}, ";
                }
                print = print.Substring(0, print.Length - 2);
                print += ".";
                Console.WriteLine(print);
            }
        }
    }
}
