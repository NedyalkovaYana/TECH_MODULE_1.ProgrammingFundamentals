using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            long numberID = long.Parse(Console.ReadLine());
            long uniqueNumber = long.Parse(Console.ReadLine());
            Console.WriteLine($"First name: {firstName} \nLast name: {lastName} \nAge: {age}" +
                $" \nGender: {gender} \nPersonal ID: {numberID} \nUnique Employee number: {uniqueNumber}");
        }
    }
}
