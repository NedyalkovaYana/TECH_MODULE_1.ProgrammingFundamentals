using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.VehicleCatalogue   //// РЕШЕНИЕ С ВЛОЖЕН РЕЧНИК - НЕЗАВЪРШЕНА
{
    class Program
    {
        class Car
        {
            public string  Model { get; set; }
            public string Color { get; set; }
            public int Horsepower { get; set; }

            public override string ToString()
            {
                string result = String.Empty;
                result += string.Format($"Type: Car\r\n");
                result += string.Format($"Model: {Model}\r\n");
                result += string.Format($"Color: {Color}\r\n");
                result += string.Format($"Horsepower: {Horsepower}\r\n");
                return result;
            }
        }
        class Truck
        {
            public string Model { get; set; }
            public string Color { get; set; }
            public int Horsepower { get; set; }

            public override string ToString()
            {
                string result = String.Empty;
                result += string.Format($"Type: Truck\r\n");
                result += string.Format($"Model: {Model}\r\n");
                result += string.Format($"Color: {Color}\r\n");
                result += string.Format($"Horsepower: {Horsepower}\r\n");
                return result;
            }
        }      
        static void Main(string[] args)
        {
            Dictionary<string, Car> catalogueCar = new Dictionary<string, Car>();
            Dictionary<string, Truck> catalogueTruck = new Dictionary<string, Truck>();
            string input = Console.ReadLine().ToLower();
           
            while (input != "end")
            {
                string[] tokens = input.Split(' ');
                string type = tokens[0];
   
                if (tokens[0] == "car")
                {
                    Car car = new Car()
                    {
                        Model = tokens[1],
                        Color = tokens[2],
                        Horsepower = int.Parse(tokens[3])
                    };

                    if (!catalogueCar.ContainsKey(car.Model))
                    {
                        catalogueCar.Add(car.Model, car);
                    }
                    if (!catalogueCar.ContainsKey(car.Color))
                    {
                        catalogueCar[car.Model].Add(car.Color, car);
                    }
                    catalogueCar[car.Model][car.Color] += car.Horsepower;
                }
                if (tokens[0] == "truck")
                {
                    Truck truck = new Truck()
                    {
                        Model = tokens[1],
                        Color = tokens[2],
                        Horsepower = int.Parse(tokens[3])
                    };
                   
                    if (!catalogue.ContainsKey(truck.Model))
                    {
                        catalogue.Add(truck.Model, new Dictionary<string, int>());
                    }
                    if (!catalogue[truck.Model].ContainsKey(truck.Color))
                    {
                        catalogue[truck.Model].Add(truck.Color, 0);
                    }
                    catalogue[truck.Model][truck.Color] += truck.Horsepower;
                }

                input = Console.ReadLine().ToLower();
            }
            string inputModels = Console.ReadLine().ToLower();
            while (inputModels != "close the catalogue")
            {
                foreach (var item in catalogueCar.Where(c => c.Key == inputModels))
                {
                    Car cars = car.Keys 
                }
               

                inputModels = Console.ReadLine().ToLower();
            }
            Console.WriteLine();
        }
    }
}
