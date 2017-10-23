using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Spy_Gram
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> encriptedMessage = new Dictionary<string, List<string>>();

            string privateKey = Console.ReadLine();
            int index = 0;
            Regex regex = new Regex(@"^TO:\s(?<sender>[A-Z]+);\sMESSAGE:\s(?<message>.+);$");
            string inputMessage = String.Empty;
            while ((inputMessage = Console.ReadLine()) != "END")
            {             
                var match = regex.Match(inputMessage);

                if (match.Success)
                {
                    var sender = match.Groups["sender"].Value;

                    if (!encriptedMessage.ContainsKey(sender))
                    {
                        encriptedMessage[sender] = new List<string>();
                    }

                   string encriptMessage = String.Empty;

                    for (int i = 0; i < match.Length; i++)
                    {
                        if (index > privateKey.Length - 1)
                        {
                            index = 0;
                        }
                        var x = int.Parse(privateKey[index].ToString());
                        char letter = (char)(match.ToString()[i] + x);

                        encriptMessage += letter;
                        index++;
                    }
                    index = 0;
                    encriptedMessage[sender].Add(encriptMessage);
                } 
            }
            foreach (var sender in encriptedMessage.OrderBy(a => a.Key))
            {
                foreach (var message in sender.Value)
                {
                    Console.WriteLine(message);
                }
            }
        }
    }
}
