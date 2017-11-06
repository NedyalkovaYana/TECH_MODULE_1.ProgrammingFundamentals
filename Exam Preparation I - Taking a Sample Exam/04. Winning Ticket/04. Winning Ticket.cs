using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Winning_Ticket
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputTickets = Console.ReadLine().Trim()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(t => t.Trim()).ToList();

            foreach (var ticket in inputTickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }
                string leftPart = ticket.Substring(0, ticket.Length / 2);
                string rightPart = ticket.Substring(ticket.Length - 10);

                Regex pattern = new Regex(@"[@]{6,10}|[#]{6,10}|[$]{6,10}|[\^]{6,10}");
                Match leftMatch = pattern.Match(leftPart);
                Match rightMatch = pattern.Match(rightPart);
                int min = Math.Min(leftMatch.Length, rightMatch.Length);

                if (leftMatch.ToString().Substring(0, min) == rightMatch.ToString().Substring(0, min))
                {
                    if (leftMatch.Length == 10 && rightMatch.Length == 10)
                    {
                        Console.WriteLine(
                            $"ticket \"{ticket}\" - {min}{leftMatch.ToString().Substring(1, 1)} Jackpot!");
                        continue;
                    }
                    if (leftMatch.Length >= 6 && rightMatch.Length >= 6)
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - {min}{leftMatch.ToString().Substring(1, 1)}");
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{ticket}\" - no match");
                    }
                }
            }
        }
    }
}
