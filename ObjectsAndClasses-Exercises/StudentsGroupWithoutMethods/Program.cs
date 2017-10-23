using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsGroupWithoutMethods
{
    class Program
    {
        public class Town
        {
            public string Name { get; set; }
            public int SeatsCount { get; set; }
            public List<Student> Students { get; set; }
        }
        public class Student
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public DateTime RegistartionTime { get; set; }
        }
        public class Group
        {
            public Town Town { get; set; }
            public List<Student> Students { get; set; }
        }
        static void Main(string[] args)
        {
            var towns = new List<Town>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                if (input.Contains("=>"))
                {
                    string[] parsedTownInput = input.Split(new char[] { '=', '>' }, StringSplitOptions.RemoveEmptyEntries);
                    string[] seats = parsedTownInput[1].Trim().Split();
                    string townName = parsedTownInput[0].Trim();
                    int seatCount = int.Parse(seats[0].Trim());

                    var currentTown = new Town
                    {
                        Name = townName,
                        SeatsCount = seatCount,
                        Students = new List<Student>()
                    };
                    towns.Add(currentTown);
                }
                else
                {                   
                    Town town = new Town();
                    town.Students = new List<Student>();
                    string[] inputStudentIntro = input.Trim().Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                    string studentName = inputStudentIntro[0].Trim();
                    string email = inputStudentIntro[1].Trim();
                    DateTime dateToJoin =
                        DateTime.ParseExact(inputStudentIntro[2].Trim(), "d-MMM-yyyy", CultureInfo.InvariantCulture);

                    var currentStudent = new Student
                    {
                        Name = studentName,
                        Email = email,
                        RegistartionTime = dateToJoin
                    };
                    town.Students.Add(currentStudent);
                }
            }


        }
    }
}
