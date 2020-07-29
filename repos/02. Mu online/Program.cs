using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Mu_online
{
    class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int bitcoins = 0;
            List<string> rooms = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).ToList();
            for (int i = 0; i < rooms.Count; i++)
            {
                string[] command = rooms[i].Split().ToArray();
                if (command[0] == "potion")
                {
                    health += int.Parse(command[1]);
                    if (health > 100)
                    {
                        Console.WriteLine($"You healed for {100 + int.Parse(command[1]) - health} hp.");
                        Console.WriteLine($"Current health: 100 hp.");
                        health = 100;
                    }
                    else
                    {
                        Console.WriteLine($"You healed for {int.Parse(command[1])} hp.");
                        Console.WriteLine($"Current health: {health} hp.");
                    }

                }
                else if (command[0] == "chest")
                {
                    bitcoins += int.Parse(command[1]);
                    Console.WriteLine($"You found {command[1]} bitcoins.");
                }
                else
                {
                    health -= int.Parse(command[1]);
                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {command[0]}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {command[0]}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        break;
                    }
                }
            }
            if (health > 0)
            {
                Console.WriteLine("You've made it!");
                Console.WriteLine($"Bitcoins: {bitcoins}");
                Console.WriteLine($"Health: {health}");
            }

        }
    }
}
