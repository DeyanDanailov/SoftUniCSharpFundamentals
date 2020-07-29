using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var courses = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] command = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string course = command[0];
                string student = command[1];
                if (!courses.ContainsKey(course))
                {
                    courses.Add(course, new List<string>());
                }

                courses[course].Add(student);
                courses[course] = courses[course].OrderBy(x => x).ToList();

                input = Console.ReadLine();
            }
            
            Dictionary<string, List<string>> result = courses.OrderByDescending(x => x.Value.Count)
                .ToDictionary(k => k.Key, v => v.Value);

            foreach (var course in result)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                
                foreach (var student in course.Value)
                {

                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
