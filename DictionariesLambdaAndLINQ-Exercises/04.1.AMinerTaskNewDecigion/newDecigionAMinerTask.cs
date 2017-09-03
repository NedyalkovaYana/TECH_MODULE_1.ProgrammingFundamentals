using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._1.AMinerTaskNewDecigion
{
    class newDecigionAMinerTask
    {
        static void Main(string[] args)
        {
            string resources = Console.ReadLine();
            
            bool canContinue = true;
            Dictionary<string, long> task = new Dictionary<string, long>();
            while (canContinue)
            {
                if (resources == "stop")
                {
                    canContinue = false;
                    break;
                }

               long quantity = long.Parse(Console.ReadLine());
                if (task.ContainsKey(resources))
                {
                    task[resources] += quantity;
                }
                else
                {
                    task.Add(resources, quantity);
                }
                resources = Console.ReadLine();
            }
            foreach (var item in task)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
