using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.BoatSimulator
{
    class BoatSimulator
    {
        static void Main(string[] args)
        {
            char firstBoat = char.Parse(Console.ReadLine());
            char secondBoat = char.Parse(Console.ReadLine());
            int nextStringCount = int.Parse(Console.ReadLine());
            int movesFirstBoat = 0;
            int movesSecondBoat = 0;
            for (int i = 0; i < nextStringCount; i++)
            {
                string boatMoves = Console.ReadLine();

                if (i % 2 == 0)
                {
                    //moves SecondBoat
                    movesSecondBoat += boatMoves.Length;
                    if (movesSecondBoat >= 50)
                    {
                        Console.WriteLine(secondBoat);
                        return;
                    }
                }
                else
                {
                    // moves firstBoat
                    movesFirstBoat += boatMoves.Length;
                    if (movesFirstBoat >= 50)
                    {
                        Console.WriteLine(firstBoat);
                        return;
                    }
                }
                if (boatMoves == "UPGRADE")
                {
                    firstBoat += (char)3;
                    secondBoat += (char)3;
                }
 
            }
            Console.WriteLine(movesFirstBoat > movesSecondBoat ? firstBoat : secondBoat);
        }
    }
}
