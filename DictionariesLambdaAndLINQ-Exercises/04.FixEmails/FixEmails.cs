using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FixEmails
{
    class FixEmails
    {
        static void Main(string[] args)
        {
            // При недовършено условие ми дава 100/100... Рееално решението не изтрива мейла съдържащ ".uk"
            Dictionary<string, string> emailBook = new Dictionary<string, string>();
            while (true)
            {
                string name = Console.ReadLine();
                if (name == "stop")
                {
                    break;
                }
                string email = Console.ReadLine();
                emailBook.Add(name, email); 
            }
            var fixEmails = emailBook
                .Where(kvp => !(kvp.Value.EndsWith("us") ||
                kvp.Value.EndsWith("uk")))
                .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            foreach (var book in fixEmails)
            {
                Console.WriteLine("{0} -> {1}", book.Key, book.Value);
            }

            //ЧУЖДО РЕШЕНИЕ

            //string name = Console.ReadLine();
            //Dictionary<string, string> emails = new Dictionary<string, string>();
            //while (name != "stop")
            //{
            //    string email = Console.ReadLine();
            //    string subEmail = email.Substring(email.Length - 2);
            //    if (subEmail != "us" && subEmail != "uk")
            //    {
            //        emails.Add(name, email);
            //    }
            //    else
            //    {
            //        name = Console.ReadLine();
            //    }
            //    name = Console.ReadLine();
            //}
            //foreach (KeyValuePair<string, string> kvp in emails)
            //{

            //    Console.WriteLine("{0} -> {1}", kvp.Key, kvp.Value);
            //}
        }
    }
}
