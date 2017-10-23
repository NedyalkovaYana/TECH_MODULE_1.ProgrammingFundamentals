using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Files
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> dict = new Dictionary<string, Dictionary<string, long>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string file = Console.ReadLine();

                string[] tokens = file.Split('\\');

                string root = tokens[0];

                string finalPart = tokens.Last();

                string[] extention = finalPart.Split(';').ToArray();

                string fail = extention[0];
                long size = long.Parse(extention[1]);

                if (!dict.ContainsKey(root))
                {
                    dict[root] = new Dictionary<string, long>();
                }
                if (!dict[root].ContainsKey(fail))
                {
                    dict[root][fail] = size;

                }
                else
                {
                    dict[root][fail] = size;
                }
                

            }

            string[] readCommand = Console.ReadLine().Split(' ').ToArray();

            string fileToLookFor = readCommand[0];
            string pathToLookFor = readCommand[2];

            var sorted = dict.Where(a => a.Key == pathToLookFor).OrderByDescending(a => a.Value.Values);
            int count = 0;
            foreach (var sort in sorted)
            {
                foreach (var item in sort.Value.OrderByDescending(a => a.Value).ThenBy(a => a.Key))
                {
                    if (item.Key.Split('.').Last() == fileToLookFor)
                    {
                        Console.WriteLine($"{item.Key} - {item.Value} KB");
                        count++;
                    }
                }
            }

            if (count <= 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
