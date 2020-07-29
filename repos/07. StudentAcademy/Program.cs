using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentsGrades = new Dictionary<string, List<double>>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string student = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());
                if (!studentsGrades.ContainsKey(student))
                {
                    studentsGrades[student] = new List<double>();
                }
                studentsGrades[student].Add(grade);
            }
            Dictionary<string, List<double>> studentsOver = studentsGrades.Where(x => x.Value.Average() >= 4.50)
                .OrderByDescending(y => y.Value.Average())
                .ToDictionary(x=>x.Key, y=> y.Value);
            foreach (var student in studentsOver)
            {
                Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
            }
        }
    }
}
