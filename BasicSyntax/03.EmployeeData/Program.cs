﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            var employeeID = int.Parse(Console.ReadLine());
            decimal monthSalary = decimal.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Employee ID: {employeeID:D8}");
            Console.WriteLine($"Salary: {monthSalary:f2}");
        }
    }
}
