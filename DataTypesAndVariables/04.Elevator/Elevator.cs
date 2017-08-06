using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Elevator
{
    class Elevator
    {
        static void Main(string[] args)
        {
            double personCapacity = double.Parse(Console.ReadLine());
            int peopleCount = int.Parse(Console.ReadLine());
            int courses =(int)Math.Ceiling((personCapacity / peopleCount));
            Console.WriteLine(courses);
        }
    }
}
