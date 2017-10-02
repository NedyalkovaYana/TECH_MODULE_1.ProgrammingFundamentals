using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.AverageGrades
{
    class AverageGrades
    {
        class Students
        {
            public string  Name { get; set; }
            public double[] Grades { get; set; }
            public double AverageGrade => this.Grades.Average();
        }
        static void Main(string[] args)
        {
            var students = new List<Students>();
            int studentsCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < studentsCount; i++)
            {
                var tokens = Console.ReadLine().Split();
                var name = tokens.First();
                var grades = tokens
                    .Skip(1)
                    .Select(double.Parse)
                    .ToArray();
                var student = new Students()
                {
                    Name = name,
                    Grades = grades
                };
                students.Add(student);
            }
            students = students
                .Where(a =>a.AverageGrade >= 5.00)
                .OrderBy(a => a.Name)
                .ThenByDescending(a => a.AverageGrade)
                .ToList();

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name} -> {student.AverageGrade:f2} ");
            }
        }
    }
}
