using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Wormhole
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wormholes = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();

            int steps = 0;
           
            for (int i = 0; i < wormholes.Count ; i++)
            {              
                if (wormholes[i] == 0)
                {
                    steps++;
                    continue;
                }
                int index = wormholes[i];
                wormholes[i] = 0;
                i = index - 1;
            }
            Console.WriteLine(steps);
        }
    }
}
