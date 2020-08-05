using System;
using System.Collections.Generic;
using System.Linq;

namespace _7._3.Followers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, int[]> users = new Dictionary<string, int[]>();
            while (input != "Log out")
            {
                string[] command = input.Split(": ", StringSplitOptions.RemoveEmptyEntries);
                string action = command[0];
                string username = command[1];
                if (action == "New follower")
                {
                    if (!users.ContainsKey(username))
                    {
                        users.Add(username, new int[2]);
                    }
                }
                else if (action == "Like")
                {
                    if (!users.ContainsKey(username))
                    {
                        users.Add(username, new int[2]);
                        users[username][0] = int.Parse(command[2]);
                    }
                    else
                    {
                        users[username][0] += int.Parse(command[2]);
                    }
                }
                else if (action == "Comment")
                {
                    if (!users.ContainsKey(username))
                    {
                        users.Add(username, new int[2]);
                        users[username][1] = 1;
                    }
                    else
                    {
                        users[username][1] ++;
                    }
                }
                else if (action == "Blocked")
                {
                    if (!users.ContainsKey(username))
                    {
                        Console.WriteLine($"{username} doesn't exist.");
                    }
                    else
                    {
                        users.Remove(username);
                    }
                }
                input = Console.ReadLine();
            }
            users = users.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Key).ToDictionary(a => a.Key, b => b.Value);
            Console.WriteLine($"{users.Count} followers");
            foreach (var item in users)
            {
                Console.WriteLine($"{item.Key}: {item.Value.Sum()}");
            }
        }
    }
}
