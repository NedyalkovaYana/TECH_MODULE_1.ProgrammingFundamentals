using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _04.Winning_Ticket
{
    class winningTicket
    {
        static void Main(string[] args)
        {
            string[] inputTicket = Console.ReadLine().Split(new char[] { ','}, StringSplitOptions.RemoveEmptyEntries).Select(s=> s.Trim()).ToArray();

            foreach (var ticket in inputTicket)
            {
                if (ticket.Length < 20 || ticket.Length > 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                var leftPartTicket = ticket.Substring(0, 10);
                var rightPartTicket = ticket.Substring(10);

                int resultLeftPart = IsTicketValid(leftPartTicket);
                char symbolleftPart = FindSpecialSymbol(leftPartTicket);
                char symbolRightPart = FindSpecialSymbol(rightPartTicket);
                int resultRightPart = IsTicketValid(rightPartTicket);

                if (resultLeftPart >=6 && resultRightPart >=6)
                {
                    int totalResult = Math.Min(resultRightPart, resultLeftPart);
                    if (symbolRightPart == symbolleftPart)
                    {
                        if (resultRightPart == 10 && resultLeftPart == 10)
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {totalResult}{symbolRightPart} Jackpot!");
                        }
                        else
                        {
                            Console.WriteLine($"ticket \"{ticket}\" - {totalResult}{symbolRightPart}");
                        }
                        
                    }
                }
                else
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }
            }
        }

        private static char FindSpecialSymbol(string symbol)
        {
            var maxSymbol = symbol.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key;
            return maxSymbol;
        }

        static int IsTicketValid(string partToCheck)
        {
            List<char> charsToCheckFor = new List<char>() { '#', '@', '$', '^' };

            var symbol = partToCheck.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key;
            if (charsToCheckFor.Contains(symbol))
            {
                int charCount = partToCheck.Count(a => a == symbol);
                if (charCount > 0)
                {

                    return charCount;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }

        }
    }
}
