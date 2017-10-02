using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._1VehicalCataloge
{
    class VehicleCataloge
    {
        class Car
        {
            public string Model { get; set; }
            public string Color { get; set; }
            public int HorsePower { get; set; }
        }
        class Truck
        {
            public string Model { get; set; }
            public string Color { get; set; }
            public int HorsePower { get; set; }
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var cars = new List<Car>();
            var trucks = new List<Truck>();

            while (input != "End")
            {
                string[] tokens = input.Split(' ');
                string type = tokens[0].ToLower();
                string model = tokens[1].ToLower();
                string color = tokens[2].ToLower();
                int horsePower = int.Parse(tokens[3]);

                if (type == "car")
                {
                    var car = new Car()
                    {
                        Model = model,
                        Color = color,
                        HorsePower = horsePower
                    };
                    cars.Add(car);
                }
                else if (type == "truck")
                {
                    var truck = new Truck()
                    {
                        Model = model,
                        Color = color,
                        HorsePower = horsePower
                    };
                    trucks.Add(truck);
                }
                input = Console.ReadLine();
            }

            while (true)
            {
                var inputModels = Console.ReadLine();
                if (inputModels == "Close the Catalogue")
                {
                    break;
                }
                var models = inputModels;

                foreach (var item in cars)
                {
                    if (models == item.Model)
                    {
                        Console.WriteLine("Type: Car");
                        Console.WriteLine($"Model: {item.Model}");
                        Console.WriteLine($"Color: {item.Color}");
                        Console.WriteLine($"Horsepower: {item.HorsePower}");
                    }
                }
                foreach (var item in trucks)
                {
                    if (item.Model == models)
                    {
                        Console.WriteLine("Type: Truck");
                        Console.WriteLine($"Model: {item.Model}");
                        Console.WriteLine($"Color: {item.Color}");
                        Console.WriteLine($"Horsepower: {item.HorsePower}");
                    }
                }
                
            }
            var sumCars = 0;
            foreach (var item in cars)
            {
                sumCars += item.HorsePower; 
            }
            var averageCars = 0;
            if (cars.Count > 0)
            {
                averageCars = sumCars / cars.Count;
            }
            else
            {
                averageCars = 0;
            }

            var sumTruck = 0;
            foreach (var item in trucks)
            {
                sumTruck += item.HorsePower;
            }
            var averageTrucks = 0;
            if (trucks.Count > 0)
            {
                averageTrucks = sumTruck / trucks.Count;
            }
            else
            {
                averageTrucks = 0;
            }

            Console.WriteLine($"Cars have average horsepower of: {averageCars:f2}");
            Console.WriteLine($"Trucks have average horsepower of {averageTrucks:f2}");
        }
    }
}
