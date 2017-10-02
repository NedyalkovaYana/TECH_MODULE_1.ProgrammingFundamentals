using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.EmailMe
{
    class EmailMe
    {
        

        static void Main(string[] args)
        {
            string[] email = Console.ReadLine().Split('@').ToArray();
            string username = email[0];
            string domain = email[1];

            int[] asciiusername = username.Select(a => (int)a).ToArray();
            int[] asciiDomain = domain.Select(a => (int)a).ToArray();
            int usernameSum = 0;
            int domainSum = 0;
            foreach (var item in asciiusername)
            {
               usernameSum += item;
            }
            foreach (var item in asciiDomain)
            {
                domainSum += item;
            }

            int result = domainSum - usernameSum;

            if (result >= 0)
            {
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one.");
            }

           
            //Regex regex = new Regex(@"(?<username>.+)@(?<domain>.+)");
            //var matches = regex.Matches(email);

            //foreach (Match item in matches)
            //{
            //    int username = item.Groups["username"].Value.Length;
            //    int domain = item.Groups["domain"].Value.Length;
                

            //    if (username >= domain)
            //    {
            //        Console.WriteLine("Call her!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("She is not the one.");
            //    }

            //}


        }
    }
}
