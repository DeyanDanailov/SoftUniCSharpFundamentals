using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            var registeredCars = new Dictionary<string, string>();
            int numberOfIterations = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < numberOfIterations; i++)
            {
                string[] carLine = Console.ReadLine().Split().ToArray();
                string action = carLine[0];
                string username = carLine[1];
                

                if (action=="register")
                {
                    string licenceNumber = carLine[2];
                    if (!registeredCars.ContainsKey(username))
                    {
                        registeredCars[username] = licenceNumber;
                        Console.WriteLine($"{username} registered {licenceNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {registeredCars[username]}");
                    }
                }
                else if(action == "unregister")
                {
                    if (!registeredCars.ContainsKey(username))
                    {
                        
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                    else
                    {
                        registeredCars.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                }
            }

            foreach (var item in registeredCars)
            {
                Console.WriteLine($"{item.Key} => {item.Value}");
            }
        }
    }
}
