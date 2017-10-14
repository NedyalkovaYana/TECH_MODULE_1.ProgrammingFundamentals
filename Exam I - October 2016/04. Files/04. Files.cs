using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace _04.Files
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, long>> list = new Dictionary<string, Dictionary<string, long>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(new char[]{'\\'}, StringSplitOptions.RemoveEmptyEntries).ToArray();
                string[] fileName = input.Last().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                string root = input[0];
                string nameFile = fileName[0];
                long size = long.Parse(fileName[1]);

                if (list.ContainsKey(root))
                {
                    if (list[root].ContainsKey(nameFile))
                    {
                        list[root][nameFile] = size;
                    }
                    else
                    {
                        list[root].Add(nameFile, size);
                    }
                }
                else
                {
                    list.Add(root, new Dictionary<string, long>{{nameFile, size}});
                }

            }
            int count = 0;
            string[] command = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string findFile = command[0];
            string findRoot = command[2];

            var sorted = list.Where(a => a.Key == findRoot).OrderByDescending(a => a.Value.Values);

            foreach (var sortPair in sorted)
            {
                foreach (var item in sortPair.Value.OrderByDescending(a => a.Value).ThenBy(a => a.Key))
                {
                    if (item.Key.Split('.').Last() == findFile)
                    {
                        Console.WriteLine($"{item.Key} - {item.Value} KB");
                        count++;
                    }
                }
            }
            if (count <=0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
