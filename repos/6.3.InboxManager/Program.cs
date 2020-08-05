using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._3.InboxManager
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> allUsers = new Dictionary<string, List<string>>();
            while (input != "Statistics")
            {
                string[] command = input.Split("->", StringSplitOptions.RemoveEmptyEntries);
                string action = command[0];
                string username = command[1];
                if (action == "Add")
                {
                    if (allUsers.ContainsKey(username))
                    {
                        Console.WriteLine($"{username} is already registered");
                    }
                    else
                    {
                        allUsers.Add(username, new List<string>());
                    }
                }
                else if (action == "Send")
                {
                    string email = command[2];
                    allUsers[username].Add(email);
                }
                else if (action == "Delete")
                {
                    if (allUsers.ContainsKey(username))
                    {
                        allUsers.Remove(username);
                        
                    }
                    else
                    {
                        Console.WriteLine($"{username} not found!");
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Users count: {allUsers.Count}");
            if (allUsers.Count == 0)
            {
                return;
            }
            allUsers = allUsers.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ToDictionary(a => a.Key, b => b.Value);
            foreach (var item in allUsers)
            {
                Console.WriteLine($"{item.Key}");
                foreach (var mail in item.Value)
                {
                    Console.WriteLine($" - {mail}");
                }
            }
        }
    }
}
