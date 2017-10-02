using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MergeFiles
{
    class MergeFiles
    {
        static void Main(string[] args)
        {
            List<string> inputOne = File.ReadAllLines("input1.txt").ToList();
            List<string> inputTwo = File.ReadAllLines("input2.txt").ToList();

            inputOne.AddRange(inputTwo);
            inputOne.Sort();
            File.AppendAllLines("output.txt", inputOne);
            Console.WriteLine(File.ReadAllLines("output.txt"));
        }
    }
}
