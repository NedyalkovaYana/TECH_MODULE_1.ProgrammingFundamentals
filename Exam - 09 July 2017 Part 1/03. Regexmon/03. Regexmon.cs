using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Regexmon
{
    class Program
    {
        static void Main(string[] args)
        {

            var didimonPattern = @"[^a-zA-Z-]+";
            var bojomonPattern = @"[A-Za-z]+-[A-Za-z]+";

            var input = Console.ReadLine();

            Regex digi = new Regex(didimonPattern);
            Regex bojo = new Regex(bojomonPattern);

            while (true)
            {
                Match digiMatch = digi.Match(input);

                if (digiMatch.Success)
                {
                    Console.WriteLine(digiMatch.Value.ToString());
                }
                else
                {
                    return;
                }
                int furstSimbolDigi = digiMatch.Index;
                input = input.Substring(furstSimbolDigi + digiMatch.Length);

                Match bojoMatch = bojo.Match(input);
                if (bojoMatch.Success)
                {
                    Console.WriteLine(bojoMatch.Value.ToString());
                }
                else
                {
                    return;
                }
                int firstSymbolBojo = bojoMatch.Index;
                input = input.Substring(firstSymbolBojo + bojoMatch.Length);

            }
        }
    }
}
