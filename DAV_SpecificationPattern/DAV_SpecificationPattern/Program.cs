using DAV_SpecificationPattern.Filter;
using DAV_SpecificationPattern.Model;
using DAV_SpecificationPattern.Specification;
using System;
using System.Collections.Generic;

namespace DAV_SpecificationPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[]
            {
                new Student() { Name = "Name1", Age = 21, FieldOfStudy = "Math", GPA = 4 },
                new Student() { Name = "Name2", Age = 21, FieldOfStudy = "Science", GPA = 4 },
                new Student() { Name = "Name3", Age = 21, FieldOfStudy = "Math", GPA = 4 },
                new Student() { Name = "Name4", Age = 22, FieldOfStudy = "Science", GPA = 4 },
                new Student() { Name = "Name5", Age = 22, FieldOfStudy = "Math", GPA = 3 },
                new Student() { Name = "Name6", Age = 23, FieldOfStudy = "Science", GPA = 3 },
                new Student() { Name = "Name7", Age = 23, FieldOfStudy = "Math", GPA = 3 },
                new Student() { Name = "Name8", Age = 23, FieldOfStudy = "Science", GPA = 3 }
            };

            Console.WriteLine("-------------------------");
            Console.WriteLine("  Students with Age 22");
            Console.WriteLine("-------------------------");
            List<Student> studentsAged22 = StudentFilter.GetStudentsBy(new StudentAgeSpecification(22), students);
            foreach (Student student in studentsAged22)
            {
                Console.WriteLine(student.Name);
            }
            Console.WriteLine("-------------------------");

            Console.WriteLine("-------------------------");
            Console.WriteLine("  Students with GPA 3");
            Console.WriteLine("-------------------------");
            List<Student> studentsGpa3 = StudentFilter.GetStudentsBy(new StudentGpaSpecification(3), students);
            foreach (Student student in studentsGpa3)
            {
                Console.WriteLine(student.Name);
            }
            Console.WriteLine("-------------------------");

            Console.WriteLine("-------------------------");
            Console.WriteLine(" Students studying Math");
            Console.WriteLine("-------------------------");
            List<Student> studentsInMath = StudentFilter.GetStudentsBy(new StudentFieldOfStudySpecification("Math"), students);
            foreach (Student student in studentsInMath)
            {
                Console.WriteLine(student.Name);
            }
            Console.WriteLine("-------------------------");
        }
    }
}
