using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Student> allStudents = new List<Student>();
            while (input != "end")
            {
                Student currentStudent = Student.ReadStudent(input);
                bool studentExists = false;
                foreach (var student in allStudents) // Student student = students.FirstOrDefault(s=>s.FirstName==firstName && s.LastName == lastName);
                {
                    if (student.FirstName == currentStudent.FirstName && student.LastName == currentStudent.LastName) // if(student == null/default)
                    {
                        student.Hometown = currentStudent.Hometown; // students.Add(...)
                        student.Age = currentStudent.Age; // else student.FirstName = firstName
                        studentExists = true; // ...
                    }
                }
                if (!studentExists)
                {
                    allStudents.Add(currentStudent);
                }
               
                input = Console.ReadLine();
            }
            string city = Console.ReadLine();
            for (int i = 0; i < allStudents.Count; i++)
            {
                if (allStudents[i].Hometown == city)
                {
                    Console.WriteLine($"{allStudents[i].FirstName} {allStudents[i].LastName} is {allStudents[i].Age} years old.");
                }
            }
        }
    }

    public class Student
    {
        public Student(string firstName, string lastName, int age, string hometown)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Hometown = hometown;
        }
        public static Student ReadStudent(string input)
        {
            List<string> studentsList = input.Split().ToList();
            Student student = new Student(studentsList[0], studentsList[1], int.Parse(studentsList[2]), studentsList[3]);
            return student;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Hometown { get; set; }
    }
}
