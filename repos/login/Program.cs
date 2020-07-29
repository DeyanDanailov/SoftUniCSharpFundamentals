using System;

namespace login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = String.Empty;
            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }
            string input = Console.ReadLine();
            int wrongtrials = 0;
            while (input != password)
            {
                wrongtrials++;
                if (wrongtrials == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
                Console.WriteLine("Incorrect password. Try again.");
                input = Console.ReadLine();
            }
            Console.WriteLine($"User {username} logged in.");
        }
    }
}
