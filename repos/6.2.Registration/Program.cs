using System;
using System.Text.RegularExpressions;

namespace _6._2.Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int validCounter = 0;
            for (int i = 0; i < n; i++)
            {
                string email = Console.ReadLine();
                Match isValid = Regex.Match(email, @"U\$(?<username>[A-Z][a-z]{2,})U\$P@\$(?<password>[A-Za-z]{5,}\d+)P@\$");
                if (isValid.Success)
                {
                    validCounter++;
                    Console.WriteLine("Registration was successful");
                    Console.WriteLine($"Username: {isValid.Groups["username"].Value}, Password: {isValid.Groups["password"].Value}");
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                }
            }
            Console.WriteLine($"Successful registrations: {validCounter}");
        }
    }
}
