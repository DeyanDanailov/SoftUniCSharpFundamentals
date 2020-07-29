using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> allPeople = new List<Person>();
            string input = Console.ReadLine();
            while (input != "End")
            {
                Person current = Person.ReadPerson(input);
                allPeople.Add(current);
                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(Environment.NewLine, allPeople.OrderBy(o => o.Age)));
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
        //public List<Student> allStudents { get; set; }
        public Person(string name, string id, int age)
        {
            this.Name = name;
            this.ID = id;
            this.Age = age;
        }
        public static Person ReadPerson(string input)
        {
            List<string> currentList = input.Split().ToList();
            Person current = new Person(currentList[0], currentList[1], int.Parse(currentList[2]));
            return current;
        }

        public override string ToString()
        {
            return $"{Name} with ID: {ID} is {Age} years old.";
        }
    }
}
