using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.CameraView
{
    class CameraView
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int skip = nums[0];
            int take = nums[1];

            string pattern = @"\|<(\w{" + skip + @"})(\w{0," + take + @"})";
            string text = Console.ReadLine();

            MatchCollection result = Regex.Matches(text, pattern);

            List<string> forPrint = new List<string>();

            foreach (Match pics in result)
            {
                forPrint.Add(pics.Groups[2].Value);
            }
            Console.WriteLine(string.Join(", ", forPrint));

        }
    }
}
