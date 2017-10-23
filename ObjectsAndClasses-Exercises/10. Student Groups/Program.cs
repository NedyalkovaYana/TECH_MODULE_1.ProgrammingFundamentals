namespace _10.Student_Groups
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    class Student_Groups
    {
        class Student
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public DateTime RegistrationDate { get; set; }
        }
        class Town
        {
            public string Name { get; set; }
            public int SeatsCount { get; set; }
            public List<Student> Students { get; set; }
        }
        class Group
        {
            public Town Town { get; set; }
            public List<Student> Students { get; set; }
        }
        static void Main()
        {
            List<Town> towns = new List<Town>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                if (input.Contains("=>"))
                {
                    towns.Add(ReadTown(input));
                }
                else
                {
                    towns[towns.Count -1].Students.Add(ReadStudent(input));
                }
                input = Console.ReadLine();
            }
            List<Group> grups = DestributeStudentsInGroup(towns);

            Console.WriteLine($"Created {grups.Count} groups in {towns.Count} towns:");
            foreach (Group group in grups.OrderBy(a => a.Town.Name))
            {
                Console.WriteLine("{0} => {1}", group.Town.Name, string.Join(", ", group.Students.Select(s => s.Email).ToList()));
            }

        }

        static List<Group> DestributeStudentsInGroup(List<Town> towns)
        {
            var groups = new List<Group>();

            foreach (Town town in towns)
            {
                IEnumerable<Student> students = town.Students.OrderBy(a => a.RegistrationDate).ThenBy(a => a.Name)
                    .ThenBy(a => a.Email);

                while (students.Any())
                {
                    var group = new Group();
                    group.Town = town;
                    group.Students = students.Take(group.Town.SeatsCount).ToList();
                    students = students.Skip(group.Town.SeatsCount);
                    groups.Add(group);
                }
            }
            return groups;
        }

        static Student ReadStudent(string input)
        {
            string[] inputStudent = input.Split('|');
            string studentName = inputStudent[0].Trim();
            string studentEmail = inputStudent[1].Trim();
            DateTime registrationDay =
                DateTime.ParseExact(inputStudent[2].Trim(), "d-MMM-yyyy", CultureInfo.InvariantCulture);

            return new Student
            {
                Name = studentName,
                Email = studentEmail,
                RegistrationDate = registrationDay
            };
        }

        static Town ReadTown(string input)
        {
            string[] readTown = input.Split(new string[] {"=>"}, StringSplitOptions.RemoveEmptyEntries);
            string townName = readTown[0].Trim();
            int seatsCount = int.Parse(readTown[1].Trim().Split(' ')[0]);
            List<Student> studentsList = new List<Student>();

            return new Town
            {
                Name = townName,
                SeatsCount = seatsCount,
                Students = studentsList
            };

        }
    }
}
