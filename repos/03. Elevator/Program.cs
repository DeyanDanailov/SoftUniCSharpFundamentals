using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int courses = 0;
            if (number % capacity == 0)
            {
                courses = number / capacity;
            }
            else
                courses = number / capacity + 1;
            Console.WriteLine(courses);
        }
    }
}
