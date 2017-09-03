using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Phonebook
{
    class Phonebook
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
                    case "END": canContiune = false; break;
                }
            }
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
