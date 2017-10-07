using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Substring
{
    class Substring
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int jump = int.Parse(Console.ReadLine());

            const char search = 'p';
            bool hasMatch = false;
            string matchedString = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == search)
                {
                    hasMatch = true;

                    int length = jump + 1;
                    
                    if (i + length <= text.Length)
                    {
                        matchedString = text.Substring(i, length);
                    }
                    else
                    {
                        matchedString = text.Substring(i);
                    }
                    i += jump;
                    Console.WriteLine(matchedString);
                }
                
            }
            
            if (!hasMatch)
            {
                Console.WriteLine("no");
            }
        }
    }
}