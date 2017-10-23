using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Thea_the_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long amountOfPicture = long.Parse(Console.ReadLine());
            long amountSecond = long.Parse(Console.ReadLine());
            TimeSpan amSeconds = TimeSpan.FromSeconds(amountSecond);

            long presentageGoodPicture = long.Parse(Console.ReadLine());
            long timeToUploadOnePicture = long.Parse(Console.ReadLine());

            double usefulPicture = Math.Ceiling((amountOfPicture * presentageGoodPicture) / 100.0);
            long timeForFilter = amountOfPicture * amountSecond;
            long timeToUpload = (long)usefulPicture * timeToUploadOnePicture;

            long totalTime = timeForFilter + timeToUpload;

            TimeSpan rezult = TimeSpan.FromSeconds(totalTime);

            var print = string.Format("{0:d\\:hh\\:mm\\:ss}", rezult);
            Console.WriteLine(print);

        }
    }
}
