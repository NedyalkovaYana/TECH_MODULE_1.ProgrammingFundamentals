using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _02.Icarus
{
    class Icarus
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();

            int startPosition = int.Parse(Console.ReadLine());
            var currentIndex = startPosition;
            var damage = 1;
            var stepsMade = 0;

            string commands = Console.ReadLine();

            while (commands != "Supernova")
            {
                string[] tokens = commands.Split();
                string direction = tokens[0];
                int steps = int.Parse(tokens[1]);


                if (direction == "left")
                {
                    for (int i = currentIndex - 1; i >= -1; i--)
                    {
                        if (stepsMade == steps)
                        {
                            break;
                        }
                        if (i != -1)
                        {
                            currentIndex = i;
                        }
                        else
                        {
                            i = array.Length - 1;
                            damage++;
                            currentIndex = array.Length - 1;
                        }
                        array[i] = array[i] - damage;
                        stepsMade++;
                    }
                    stepsMade = 0;
                }
                else
                {
                    for (int i = currentIndex + 1; i <= array.Length; i++)
                    {
                        if (stepsMade == steps)
                        {
                          break;   
                        }
                        if (i != array.Length)
                        {
                            currentIndex = i;
                        }
                        else
                        {
                            damage++;
                            i = 0;
                            currentIndex = 0;
                        }
                        array[i] = array[i] - damage;
                        stepsMade++;
                    }
                    stepsMade = 0;
                }
                commands = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", array));
        }
    }
}
