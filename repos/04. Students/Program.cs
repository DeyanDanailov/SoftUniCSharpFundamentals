using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberToRead = int.Parse(Console.ReadLine());
            List<Student> allStudents = new List<Student>();
            for (int i = 0; i < numberToRead; i++)
            {
                string input = Console.ReadLine();
                Student currentStudent = Student.ReadStudent(input);
                allStudents.Add(currentStudent);
            }
         
            Console.WriteLine(String.Join(Environment.NewLine, allStudents.OrderByDescending(o => o.Grade)));
        }



        
    }
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Grade { get; set; }
        //public List<Student> allStudents { get; set; }
        public Student(string firstName, string lastName, float grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }
        public static Student ReadStudent(string input)
        {
            List<string> currentStudentList = input.Split().ToList();
            Student currentStudent = new Student(currentStudentList[0], currentStudentList[1], float.Parse(currentStudentList[2]));
            return currentStudent;
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }
}



