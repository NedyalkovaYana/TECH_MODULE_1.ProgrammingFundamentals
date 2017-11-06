using System.Collections.Generic;
using System.Numerics;

namespace ConsoleApp1
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main()
        {
            int countOfAffectedWebsite = int.Parse(Console.ReadLine());
            double secutiryKey = int.Parse(Console.ReadLine());
            Dictionary<string,  decimal> sites = new Dictionary<string, decimal>();
            decimal totalSiteLost = 0m;
            for (int i = 0; i < countOfAffectedWebsite; i++)
            {//{siteName} {siteVisits} {siteCommercialPricePerVisit}
                var website = Console.ReadLine().Split(' ').ToList();
                var siteName = website[0].Trim();
                var siteVisits = decimal.Parse(website[1].Trim());
                var sitePrice = decimal.Parse(website[2].Trim());
                
                //site loss = siteVisits * siteCommercialPricePerVisit
                decimal siteLoss = sitePrice * siteVisits;
                totalSiteLost += siteLoss;
                if (!sites.ContainsKey(siteName))
                {
                    sites.Add(siteName, siteLoss);
                }
                else if (sites.ContainsKey(siteName))
                {
                    sites[siteName] += siteLoss;
                }
            }
           
            decimal securityToken = (secutiryKey * secutiryKey)

            foreach (var pair in sites)
            {
                Console.WriteLine($"{pair.Key}");
            }
            Console.WriteLine($"Total Loss: {totalSiteLost:f20}");
            Console.WriteLine($"Security Token: {securityToken}");
        }
    }
}

