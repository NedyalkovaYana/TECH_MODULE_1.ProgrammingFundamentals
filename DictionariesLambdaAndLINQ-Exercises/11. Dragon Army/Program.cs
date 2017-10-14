using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _11.Dragon_Army
{
    class Program
    {
      
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int[]>> dragonsList = new Dictionary<string, Dictionary<string, int[]>>();
            int numbersOfDragons = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbersOfDragons; i++)
            {
                string[] currentDragon = Console.ReadLine().Split(' ').ToArray();
                int dragonDamage = 0;
                int dragonHealt = 0;
                string dragonType = currentDragon[0];
                string dragonName = currentDragon[1];
                int dragonArmor = 0;
                if (currentDragon[2] == "null")
                {
                    dragonDamage = 45;
                }
                else
                {
                    dragonDamage = int.Parse(currentDragon[2]);
                }
                if (currentDragon[3] == "null")
                {
                    dragonHealt = 250;
                }
                else
                {
                    dragonHealt = int.Parse(currentDragon[3]);
                }
                if (currentDragon[4] == "null")
                {
                    dragonArmor = 10;
                }
                else
                {
                    dragonArmor = int.Parse(currentDragon[4]);
                }

                if (!dragonsList.ContainsKey(dragonType))
                {
                    dragonsList[dragonType] = new Dictionary<string, int[]>();
                }
                if (!dragonsList[dragonType].ContainsKey(dragonName))
                {
                    dragonsList[dragonType][dragonName] = new int[3];
                }

                dragonsList[dragonType][dragonName][0] = dragonDamage;
                dragonsList[dragonType][dragonName][1] = dragonHealt;
                dragonsList[dragonType][dragonName][2] = dragonArmor;

            }

            
            foreach (var item in dragonsList)
            {
                Console.WriteLine("{0}::({1:f2}/{2:f2}/{3:f2})", item.Key, item.Value.Select(a => a.Value[0]).Average(),
                    item.Value.Select(a => a.Value[1]).Average(), item.Value.Select(a => a.Value[2]).Average());

                foreach (var items in item.Value.OrderBy(a => a.Key))
                {
                    Console.WriteLine($"-{items.Key} -> damage: {items.Value[0]}, health: {items.Value[1]}, armor: {items.Value[2]}");
                }
            }
        }
    }
}
