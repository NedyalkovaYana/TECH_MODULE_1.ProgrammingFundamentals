﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.KarateStrings
{
    class KarateStrings
    {
        static void Main(string[] args)
        {
            StringBuilder path = new StringBuilder(Console.ReadLine());
            int power = 0;
            for (int i = 0; i < path.Length; i++)
            {
                if (path[i] == '>')
                {
                    power += int.Parse(path[i + 1].ToString());
                    i++;
                    while (i < path.Length && power > 0)
                    {
                        if (path[i] == '>')
                        {
                            break;
                        }
                        path.Remove(i, 1);
                        power--;
                    }
                    i--;
                }
            }
            Console.WriteLine(path);
        }
    }
}
