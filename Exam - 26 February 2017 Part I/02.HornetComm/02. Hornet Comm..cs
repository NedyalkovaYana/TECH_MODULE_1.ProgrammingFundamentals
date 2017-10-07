using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.HornetComm
{
    class Program
    {
        static void Main(string[] args)
        {
            List<KeyValuePair<string, string>> broadcast = new List<KeyValuePair<string, string>>();
            List<KeyValuePair<string, string>> message = new List<KeyValuePair<string, string>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(new string[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (input[0] == "Hornet is Green")
                {
                    break;
                }

                string firstQuery = input[0];
                string secondQuery = input[1];

                bool digitsOnly = firstQuery.All(char.IsDigit);

                bool validSecondQuery = secondQuery.All(c => char.IsLetterOrDigit(c));
                if (!validSecondQuery)
                {
                    continue;
                }

                if (digitsOnly)
                {
                    var reversedQuery = ReverseString(firstQuery);
                    message.Add(new KeyValuePair<string, string>(reversedQuery, secondQuery));
                   
                }
                else
                {
                    var decryptedQuery = DecryptedQuery(secondQuery);
                   broadcast.Add(new KeyValuePair<string, string>(decryptedQuery, firstQuery));
                }
               
            }
            Console.WriteLine("Broadcasts:");
            if (broadcast.Count > 0)
            {             
                foreach (var element in broadcast)
                {              
                    Console.WriteLine($"{element.Key} -> {element.Value}");
                }
            }
            else
            {
                Console.WriteLine("None");
            }

            Console.WriteLine("Messages:");
            if (message.Count > 0)
            {              
                foreach (var item in message)
                {
                    Console.WriteLine($"{item.Key} -> {item.Value}");
                }
            }
            else
            {
                Console.WriteLine("None");
            }
        }

        static string DecryptedQuery(string secondQuery)
        {
            string decryptedFrequency = "";
 
            foreach (char currentChar in secondQuery)
            {
                if (currentChar >= 65 && currentChar <= 90)
                {
                    decryptedFrequency += (char)(currentChar + 32);
                }
                else if (currentChar >= 97 && currentChar <= 122)
                {
                    decryptedFrequency += (char)(currentChar - 32);
                }
                else
                {
                    decryptedFrequency += currentChar;
                }
            }
            return decryptedFrequency;
        }

        static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
