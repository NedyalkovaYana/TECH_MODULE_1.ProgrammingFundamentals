using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.OrderByAge
{
    class OrderByAge
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();
            List<dynamic> list = new List<dynamic>();

            while (input[0] != "End")
            {
                string name = input[0].ToString();
                string id = input[1].ToString();
                int age = int.Parse(input[2]);
                dynamic person = new { name, id, age };

                list.Add(person);
                input = Console.ReadLine().Split(' ').ToList();
            }
            var result = list.OrderBy(person => person.age);
            foreach (var item in result)
            {
                Console.WriteLine($"{item.name} with ID: {item.id} is {item.age} years old.");
            }
        }
    }
}
