using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace _03.NetherRealms
{
    class NetherRealms
    {
        static void Main(string[] args)
        {
            string[] demons = Regex.Split(Console.ReadLine(), @"\s*, \s*").Select(a => a.Trim()).ToArray();
            string addLetter = "";
 
            foreach (var demon in demons.OrderBy(a => a))
            {
                string pattern = @"(?<letters>[A-Za-z]*)(?<nums>[+-]?[0-9]*[.]?[0-9]*)";
                
                MatchCollection matches = Regex.Matches(demon, pattern);
                double damage = 0;
                addLetter = string.Empty;
                foreach (Match match in matches)
                {             
                    var letter = match.Groups["letters"].Value;
                    addLetter += letter;
                    var numForDagem = match.Groups["nums"].Value;
                   
                    if (numForDagem == "")
                    {
                        continue;
                    }
                    damage += double.Parse(numForDagem, CultureInfo.InvariantCulture);
                   
                }
                string pattern1 = @"(?<star>[*])";
                MatchCollection matchee = Regex.Matches(demon, pattern1);
                double countStar = 0;
                foreach (Match match in matchee)
                {
                    countStar++;
                    var star = match.Groups["star"].Value;
                }
                string pattern2 = @"(?<devide>[\/])";
                MatchCollection matcch = Regex.Matches(demon, pattern2);
                double countDevide = 0;
                foreach (Match ma in matcch)
                {
                    countDevide++;
                    var devide = ma.Groups["devide"].Value;
                }

                Console.Write($"{demon} - ");
                GetDemonsHealth(addLetter);
                GetDemonsDamage(damage, countStar, countDevide);
                Console.WriteLine();

            }        
        }

        private static void GetDemonsDamage(double damage, double countStar, double countDevide)
        {
            double totalDamage = 0.0;
            totalDamage += damage;

            for (int i = 0; i < countStar; i++)
            {
                totalDamage *= 2;
            }
            for (int i = 0; i < countDevide; i++)
            {
                totalDamage /= 2;
            }
            Console.Write($" {totalDamage:f2} damage ");
        }

        static void GetDemonsHealth(string addLetter)
        {
            double health = 0.0;
            foreach (char ch in addLetter)
            {
                health += (int)ch;
            }
            Console.Write($"{health} health,");

            addLetter = string.Empty;
            health = 0.0;
        }
    }  
}
