using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.SMSTyping
{
    class SMSTyping
    {
        static void Main()
        {
            int numberOfCharacters = int.Parse(Console.ReadLine());
            char letter;
            string word = String.Empty;

            for (int i = 1; i <= numberOfCharacters; i++)
            {
                int textMessageCharacters = int.Parse(Console.ReadLine());

                switch (textMessageCharacters)
                {
                    case 2: letter = 'a'; word+= letter;  break;
                    case 22: letter = 'b'; word += letter; break;
                    case 222: letter = 'c'; word += letter; break;
                    case 3: letter = 'd'; word += letter; break;
                    case 33: letter = 'e'; word += letter; break;
                    case 333: letter = 'f'; word += letter; break;
                    case 4: letter = 'g'; word += letter; break;
                    case 44: letter = 'h'; word += letter; break;
                    case 444: letter = 'i'; word += letter; break;
                    case 5: letter = 'j'; word += letter; break;
                    case 55: letter = 'k'; word += letter; break;
                    case 555: letter = 'l'; word += letter; break;
                    case 6: letter = 'm'; word += letter; break;
                    case 66: letter = 'n'; word += letter; break;
                    case 666: letter = 'o'; word += letter; break;
                    case 7: letter = 'p'; word += letter; break;
                    case 77: letter = 'q'; word += letter; break;
                    case 777: letter = 'r'; word += letter; break;
                    case 7777: letter = 's'; word += letter; break;
                    case 8: letter = 't'; word += letter; break;
                    case 88: letter = 'u'; word += letter; break;
                    case 888: letter = 'v'; word += letter; break;
                    case 9: letter = 'w'; word += letter; break;
                    case 99: letter = 'x'; word += letter; break;
                    case 999: letter = 'y'; word += letter; break;
                    case 9999: letter = 'z'; word += letter; break;
                    case 0: letter = ' '; word += letter; break;


                }
               
            }
            Console.WriteLine(word);
        }
    }
}
