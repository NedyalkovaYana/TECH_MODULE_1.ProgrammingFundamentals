using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1.NewSolutionSmSType
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string message = String.Empty;
            for (int i = 0; i < n; i++)
            {
                string digits = Console.ReadLine();
                int mainDigits = int.Parse(digits[0].ToString());
                int offset = (mainDigits - 2) * 3;
                if (mainDigits == 8 || mainDigits == 9)
                {
                    offset += 1;
                }
                int letterIndex = offset + digits.Length - 1;
                if (mainDigits == 0)
                {
                    message += " ";

                }
                else
                {
                    message += (char)(97 + letterIndex);
                }
            }
            Console.WriteLine(message);
        }
    }
}
