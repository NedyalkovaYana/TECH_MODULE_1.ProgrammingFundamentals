using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Cubic_Messages
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"^(?<digitsBefore>\d+)(?<message>[a-zA-Z]+)(?<digitsAfter>[^a-zA-Z]*)$";

            while (true)
            {
                string encriptedMessage = Console.ReadLine();
                if (encriptedMessage == "Over!")
                {
                    break;
                }
                int number = int.Parse(Console.ReadLine());

                var matches = Regex.Match(encriptedMessage, pattern);

                if (!matches.Success)
                {
                    continue;
                }

                var leftPart = matches.Groups["digitsBefore"].Value;
                var message = matches.Groups["message"].Value;
                var rightPart = matches.Groups["digitsAfter"].Value;

                if (message.Length != number)
                {
                    continue;
                }
                var verificationCode = new StringBuilder();

                foreach (var @char in leftPart + rightPart)
                {
                    if (! char.IsDigit(@char))
                    {
                        continue;
                    }

                    var index = int.Parse(@char.ToString());
                    if (index >= 0 && index < message.Length)
                    {
                        verificationCode.Append(message[index]);
                    }
                    else
                    {
                        verificationCode.Append(' ');
                    }

                    
                }
                Console.WriteLine($"{message} == {verificationCode}");
            }
           
        }
    }
}
