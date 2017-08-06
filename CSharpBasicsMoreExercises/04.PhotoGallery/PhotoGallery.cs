using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PhotoGallery
{
    class PhotoGallery
    {
        static void Main(string[] args)
        {
            int photoNumber = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            double photoSizeInBytes = double.Parse(Console.ReadLine());
            int widthPixels = int.Parse(Console.ReadLine());
            int heightPixels = int.Parse(Console.ReadLine());
            string sizeName = "B";
            Console.WriteLine($"Name: DSC_{photoNumber:D4}.jpg");
            Console.WriteLine($"Date Taken: {day:d2}/{month:d2}/{year} {hour:d2}:{minutes:d2}");
            if (photoSizeInBytes > 1000000)
            {
                photoSizeInBytes /= 1000000;
                sizeName = "MB";
            }

            else if (photoSizeInBytes > 1000)
            {
                photoSizeInBytes /= 1000;
                sizeName = "KB";
            }
           
            Console.WriteLine($"Size: {photoSizeInBytes}{sizeName}");

            if (widthPixels == heightPixels)
            {
                Console.WriteLine($"Resolution: {widthPixels}x{heightPixels} (square)");
            }
            else if (heightPixels > widthPixels)
            {
                Console.WriteLine($"Resolution: {widthPixels}x{heightPixels} (portrait)");
            }
            else
            {
                Console.WriteLine($"Resolution: {widthPixels}x{heightPixels} (landscape)");
            }
        }
    }
}
