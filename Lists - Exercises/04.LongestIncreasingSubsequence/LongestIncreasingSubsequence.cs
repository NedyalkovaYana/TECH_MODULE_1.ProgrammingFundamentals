using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.LongestIncreasingSubsequence
{
    class LongestIncreasingSubsequence
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var longestIncreasingSubsequence = FindLongestIncreasingSubsequence(arr);
            Console.WriteLine(string.Join(" ",longestIncreasingSubsequence));

        }

       static int[] FindLongestIncreasingSubsequence(int[] arr)
       {
            var lengths = new int[arr.Length];
            var previous = new int[arr.Length];
            var bestLegth = 0;
            var lastIndex = -1;

            for (int i = 0; i < arr.Length; i++)
            {
                lengths[i] = 1;
                previous[i] = -1;
                var anchoNum = arr[i];
                for (int j = 0; j < i; j++)
                {
                    var currentNum = arr[j];
                    if (currentNum < anchoNum && lengths[j] + 1 > lengths[i])
                    {
                        lengths[i] = lengths[j] + 1;
                        previous[i] = j;
                    }
                }
                if (lengths[i] > bestLegth)
                {
                    bestLegth = lengths[i];
                    lastIndex = i;
                }
            }
            var longestIncreasingSubSequence = new List<int>();
            while (lastIndex != -1)
            {
                longestIncreasingSubSequence.Add(arr[lastIndex]);
                lastIndex = previous[lastIndex];
            }
            longestIncreasingSubSequence.Reverse();
            return longestIncreasingSubSequence.ToArray();
       }
    }
}
