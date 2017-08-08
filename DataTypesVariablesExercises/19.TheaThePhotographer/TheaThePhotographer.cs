using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.TheaThePhotographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long picturesCount = long.Parse(Console.ReadLine());
            int singlePictureFilterTimeSeconds = int.Parse(Console.ReadLine());
            int filterPersentage = int.Parse(Console.ReadLine());
            int singlePictureUploadTimeSeconds = int.Parse(Console.ReadLine());

            long filterTimeSeconds = picturesCount * singlePictureFilterTimeSeconds;
            double picturesToUploadCount = (long)Math.Ceiling(picturesCount * (filterPersentage/100d));
            double uploadTimeSeconds = picturesToUploadCount * singlePictureUploadTimeSeconds;
            var totalTimeNeededSeconds = filterTimeSeconds + uploadTimeSeconds;

            var totalTimeNeededTimeSpan = TimeSpan.FromSeconds(totalTimeNeededSeconds);
            Console.WriteLine(totalTimeNeededTimeSpan.ToString(@"d\:hh\:mm\:ss"));
        }
    }
}
