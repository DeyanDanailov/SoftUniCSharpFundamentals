using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._House_party
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();
            for (int i = 0; i < numberOfCommands; i++)
            {
                List<string> command = Console.ReadLine().Split().ToList();
                if (command[2] == "going!")
                {
                    GoingGuest(guests, command[0]);
                }
                else if (command[2] == "not")
                {
                    NotGoing(guests, command[0]);
                }
            }
            Console.WriteLine(String.Join("\n", guests));
        }
        static List<string> GoingGuest(List<string> list, string name)
        {
            if (list.Contains(name))
            {
                Console.WriteLine($"{name} is already in the list!");
                return list;
            }
            else
            {
                list.Add(name);
                return list;
            }
        }
        static List<string> NotGoing(List<string> list, string name)
        {
            if (list.Contains(name))
            {
                list.Remove(name);
                return list;
            }
            else
            {
                Console.WriteLine($"{name} is not in the list!");
                return list;
            }
        }
    }
}
