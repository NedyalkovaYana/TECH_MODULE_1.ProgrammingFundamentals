using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.ParkingValidation
{
    class ParkingValidation
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> registerPlate = new Dictionary<string, string>();

            string patternToValidCarNumber = @"^([A-Z]{2}\d{4}[A-Z]{2})$";
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split(' ');
                string command = commands[0].Trim();
                string user = commands[1].Trim();
                switch (command)
                {
                    case "register":                      
                        
                        string carPlate = commands[2].Trim();
                        if (registerPlate.ContainsKey(user))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {registerPlate[user]}");
                            continue;
                        }
                        if (registerPlate.ContainsValue(carPlate))
                        {
                            Console.WriteLine($"ERROR: license plate {carPlate} is busy");
                            continue;
                        }
                        var match = Regex.Match(carPlate, patternToValidCarNumber);
                        if (match.Success)
                        {
                            if (!registerPlate.ContainsKey(user))
                            {
                                registerPlate.Add(user, carPlate);
                                Console.WriteLine($"{user} registered {carPlate} successfully");
                                continue;
                            }                          
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: invalid license plate {carPlate}");
                        }
                        break;
                    case "unregister":
                        if (!registerPlate.ContainsKey(user))
                        {
                            Console.WriteLine($"ERROR: user {user} not found");
                        }
                        else
                        {
                            registerPlate.Remove(user);
                            Console.WriteLine($"user {user} unregistered successfully");
                        }
                        break;
                }
            }

            foreach (var cars in registerPlate)
            {
                Console.WriteLine($"{cars.Key} => {cars.Value}");
            }
        }
    }
}
