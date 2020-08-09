using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._3.BattleManager
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            Dictionary<string, User> users = new Dictionary<string, User>();
            while (input != "Statistics")
            {
                string[] command = input.Split('=', StringSplitOptions.RemoveEmptyEntries);
                string action = command[0];
                if (action == "Add")
                {
                    string userName = command[1];
                    int sent = int.Parse(command[2]);
                    int received = int.Parse(command[3]);
                    Add(users, userName, sent, received);
                }
                else if (action == "Message")
                {
                    string sender = command[1];
                    string receiver = command[2];                   
                    Message(users, sender, receiver, capacity);
                }
                else if (action == "Empty")
                {
                    string toDelete = command[1];
                    if (toDelete == "All")
                    {
                        users.Clear();
                    }
                    else
                    {
                        if (users.ContainsKey(toDelete))
                        {
                            users.Remove(toDelete);
                        }
                    }
                }
                input = Console.ReadLine();
            }
            users = users.OrderByDescending(x => x.Value.Received).ThenBy(h => h.Key).ToDictionary(a => a.Key, b => b.Value);
            Console.WriteLine($"Users count: {users.Count}");
            foreach (var item in users)
            {
                Console.WriteLine($"{item.Key} - {item.Value.Sent + item.Value.Received}");
            }
        }
        public static void Add(Dictionary<string, User> users, string userName, int sent, int received)
        {
            if (!users.ContainsKey(userName))
            {
                users.Add(userName, new User { Sent = sent, Received = received });
            }
            else
            {
                return;
            }
        }
        public static void Message(Dictionary<string, User> users, string sender, string receiver, int capacity)
        {
            if (users.ContainsKey(sender) && users.ContainsKey(receiver))
            {
                users[sender].Sent++;
                if (users[sender].Sent + users[sender].Received >= capacity)
                {
                    users.Remove(sender);
                    Console.WriteLine($"{sender} reached the capacity!");
                }
                users[receiver].Received++;
                if (users[receiver].Sent + users[receiver].Received >= capacity)
                {
                    users.Remove(receiver);
                    Console.WriteLine($"{receiver} reached the capacity!");
                }
                
            }
        }
    }
    public class User
    {
        public int Sent { get; set; }
        public int Received { get; set; }
    }
}
