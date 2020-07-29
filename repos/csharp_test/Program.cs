using System;

namespace csharp_test
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname = Console.ReadLine();
            string lastname = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string town = Console.ReadLine();
            
            Console.WriteLine($"You are {firstname} {lastname}, a {age}-year old from {town}.");
        }
    }
}
