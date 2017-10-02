using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Ladybugs
{
    class Ladybugs
    {
        static void Main(string[] args)
        {

            var filedSize = int.Parse(Console.ReadLine());
            var ladyBugIndexes = 
                Console.ReadLine().Split()
                .Select(int.Parse)
                .Where(a => a >= 0 && a < filedSize)
                .ToArray();

            var ladyBugs = new int[filedSize];
            foreach (var ladyBugIndex in ladyBugIndexes)
            {
                ladyBugs[ladyBugIndex] = 1;
            }

            while (true)
            {
                var line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }
                var tokens = line.Split(' ');
                var ladybugIndex =int.Parse(tokens[0]);
                var direction = tokens[1];
                var count = int.Parse(tokens[2]);

                var isInsideArray = ladybugIndex >= 0 && ladybugIndex < ladyBugs.Length;
                if (!isInsideArray)
                {
                    continue;
                }
                var ladybugExists = ladyBugs[ladybugIndex] == 1;
                if (!ladybugExists)
                {
                    continue;
                }

                MoveLadybug(ladyBugs, ladybugIndex, direction, count);        
            }
            Console.WriteLine(string.Join(" ", ladyBugs));
        }

        static void MoveLadybug(int[] ladyBugs, int ladybugIndex, string direction, int count)
        {
            if (direction == "left")
            {
                count = -count;
            }
            var nextIndex = ladybugIndex + count;
            ladyBugs[ladybugIndex] = 0;
            var hasLeftArrayOrFoundPlace = false;
            while (!hasLeftArrayOrFoundPlace)
            {
                if (nextIndex < 0 || nextIndex > ladyBugs.Length -1)
                {
                    hasLeftArrayOrFoundPlace = true;
                    continue;
                }

                var ladyBugsAlreadyExistOnIndex = ladyBugs[nextIndex] == 1;
                if (ladyBugsAlreadyExistOnIndex)
                {
                    nextIndex += count;
                    continue;
                }

                ladyBugs[nextIndex] = 1;
                hasLeftArrayOrFoundPlace = true;
            }
        }
    }
}
