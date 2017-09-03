using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PhonebookUpgrade
{
    class PhonebookUpgrade
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            bool canContiune = true;

            while (canContiune)
            {
                string[] command = Console.ReadLine().Split();
                switch (command[0])
                {
                    case "A": AddToPB(phonebook, command); break;
                    case "S": SearchPB(phonebook, command); break;
                    case "ListAll": PrintPB(phonebook, command); break;
                    case "END": canContiune = false; break;
                        
                }
            }
        }

        static void PrintPB(Dictionary<string, string> phonebook, string[] command)
        {
            var list = phonebook.Keys.ToList();
            list.Sort();
            foreach (var key in list)
            {
                Console.WriteLine(string.Format("{0} -> {1}", key, phonebook[key]));
            }
            //var result = phonebook.OrderBy(p => p.Key);
            //Console.WriteLine(string.Join(" ", result));
        }

        static void SearchPB(Dictionary<string, string> phonebook, string[] command)
        {
            if (phonebook.ContainsKey(command[1]))
            {
                Console.WriteLine($"{command[1]} -> {phonebook[command[1]]}");
            }
            else
            {
                Console.WriteLine($"Contact {command[1]} does not exist.");
            }
        }

        static void AddToPB(Dictionary<string, string> phonebook, string[] command)
        {
            if (phonebook.ContainsKey(command[1]))
            {
                phonebook[command[1]] = command[2];
            }
            else
            {
                phonebook.Add(command[1], command[2]);
            }
        }
    }
}

