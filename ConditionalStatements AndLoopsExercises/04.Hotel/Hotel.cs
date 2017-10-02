using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hotel
{
    class Hotel
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine().ToLower();
            int nightCount = int.Parse(Console.ReadLine());
                     
            decimal studioPrice = 0;
            decimal doublePrice = 0;
            decimal suitePrice = 0;
            decimal discount = 0;

            switch (month)
            {
                case "may":
                case "october":
                    studioPrice = 50;
                    doublePrice = 65;
                    suitePrice = 75;
                    if (nightCount > 7 )
                    {                       
                        discount = 5;
                        studioPrice = studioPrice - ((studioPrice * discount)/100);
                        if (month == "october")
                        {
                           studioPrice = studioPrice * (nightCount - 1);
                        }
                        else
                        {
                            studioPrice *= nightCount;
                        }
                    }                  
                    doublePrice *= nightCount;
                    suitePrice *= nightCount;
                    Console.WriteLine($"Studio: {studioPrice:f2} lv.");
                    Console.WriteLine($"Double: {doublePrice:f2} lv.");
                    Console.WriteLine($"Suite: {suitePrice:f2} lv.");
                    break;

                case "june":
                case "september":
                    studioPrice = 60;
                    doublePrice = 72;
                    suitePrice = 82;
                    if (nightCount > 14)
                    {
                        discount = 10;
                        doublePrice = doublePrice - ((doublePrice * discount)/100);
                    }
                    if (nightCount > 7 && month == "september")
                    {

                        studioPrice = studioPrice * (nightCount - 1);
                    }
                    else
                    {
                        studioPrice *= nightCount;
                    }
                    doublePrice *= nightCount;
                    suitePrice *= nightCount;
                    Console.WriteLine($"Studio: {studioPrice:f2} lv.");
                    Console.WriteLine($"Double: {doublePrice:f2} lv.");
                    Console.WriteLine($"Suite: {suitePrice:f2} lv.");
                    break;
                case "july":
                case "august":
                case "december":
                    studioPrice = 68;
                    doublePrice = 77;
                    suitePrice = 89;
                    if (nightCount > 14)
                    {
                        discount = 15;
                        suitePrice = suitePrice - ((suitePrice * discount) / 100);
                    }
                    studioPrice *= nightCount;
                    doublePrice *= nightCount;
                    suitePrice *= nightCount;
                    Console.WriteLine($"Studio: {studioPrice:f2} lv.");
                    Console.WriteLine($"Double: {doublePrice:f2} lv.");
                    Console.WriteLine($"Suite: {suitePrice:f2} lv.");
                    break;
            }

        }
    }
}
