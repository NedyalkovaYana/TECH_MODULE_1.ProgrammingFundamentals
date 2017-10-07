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
        class Demon
        {
            public string Name { get; set; }
            public decimal Health { get; set; }
            public decimal Damage { get; set; }

            internal static Demon Parse(string demonStr)
            {
                var name = demonStr;
                var damageRegex = new Regex(@"-?\d+(?:\.\d+)?");
                var healthRegex = new Regex(@"[^\d\-*\/\.]");
                var health = healthRegex
                    .Matches(demonStr)
                    .Cast<Match>()
                    .Select(a =>(int)char.Parse(a.Value))
                    .Sum();

                var damage = damageRegex.Matches(demonStr)
                    .Cast<Match>()
                    .Select(a => decimal.Parse(a.Value))
                    .Sum();

                var multiplyCount = demonStr.Count(a => a == '*');
                var divideCount = demonStr.Count(a => a == '/');              
                damage *= (int)Math.Pow(2, multiplyCount);
                damage /= (int)Math.Pow(2, divideCount);
                
                var demon = new Demon
                {
                    Name = name,
                    Damage = damage,
                    Health = health                    
                };
                return demon;
            }
        }
        static void Main(string[] args)
        {
            var demons = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(Demon.Parse).OrderBy(a => a.Name).ToArray();

            foreach (var demon in demons)
            {
                Console.WriteLine($"{demon.Name} - {demon.Health} health, {demon.Damage:f2} damage");
            }
        }
    }  
}
