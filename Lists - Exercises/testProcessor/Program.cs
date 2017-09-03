using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testProcessor
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("start");
            long count = 0;
            for (int i = 0; i < 1000000000; i++)
            {
                count++;
            }
            Console.WriteLine("stop");
        }
    }
}
