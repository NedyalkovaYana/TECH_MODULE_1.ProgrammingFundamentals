using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._1Max_Sequence_SecondSolution
{
    class MaxSequence_SecondSolution
    {
        static void Main(string[] args)
        {
            var inputArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var maxSequenceOfEqualElem = FindMaxSequenceOfEqualElem(inputArr);
            Console.WriteLine(String.Join(" ", maxSequenceOfEqualElem));
        }

        static int[] FindMaxSequenceOfEqualElem(int[] inputArr)
        {
            var longestSequense = new List<int>();
            var currentSequence = new List<int>();
            currentSequence.Add(inputArr[0]);

            for (int i = 1; i < inputArr.Length; i++)
            {
                var currentNum = inputArr[i];
                var searchNum = currentSequence[0];

                if (currentNum == searchNum)
                {
                    currentSequence.Add(currentNum);
                }
                else
                {
                    if (currentSequence.Count > longestSequense.Count)
                    {
                        longestSequense = new List<int>(currentSequence);
                    }
                    currentSequence.Clear();
                    currentSequence.Add(currentNum);
                }
            }
            if (currentSequence.Count > longestSequense.Count)
            {
                longestSequense = new List<int>(currentSequence);
            }
            return longestSequense.ToArray();
        }
    }
}
