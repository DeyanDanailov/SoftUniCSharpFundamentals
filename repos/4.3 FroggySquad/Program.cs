using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._3_ContactList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> frogSquad = Console.ReadLine().Split().ToList();
            List<string> command = Console.ReadLine().Split().ToList();

            while (command[0] != "Print")
            {
                if (command[0] == "Join")
                {
                    frogSquad.Add(command[1]);
                }
                else if (command[0] == "Jump")
                {
                    Add(frogSquad, command[1], int.Parse(command[2]));
                }
                else if (command[0] == "Dive")
                {
                    Dive(frogSquad, int.Parse(command[1]));
                }
                else if (command[0] == "First")
                {
                    Export(frogSquad, 0, int.Parse(command[1]));
                }
                else if (command[0] == "Last")
                {
                    Export(frogSquad, frogSquad.Count - int.Parse(command[1]), int.Parse(command[1]));
                }
                command = Console.ReadLine().Split().ToList();
            }
            if (command[1] == "Normal")
            {
                PrintNormal(frogSquad);
               
            }
            else if (command[1] == "Reversed")
            {
                PrintReversed(frogSquad);
                
            }
        }
        static List<string> Add(List<string> list, string name, int index)
        {
            if (index >= 0 && index < list.Count)
            {
                list.Insert(index, name);
                return list;
            }
            else
            {
                return list;
            }
        }
        static List<string> Dive(List<string> list, int index)
        {
            if (index >= 0 && index < list.Count)
            {
                list.RemoveAt(index);
                return list;
            }
            else
                return list;
        }
        static void Export(List<string> list, int startIndex, int count)
        {
            if (startIndex + count > list.Count)
            {
                count = list.Count - startIndex;
            }
            List<string> result = new List<string>();
            for (int i = startIndex; i < startIndex + count; i++)
            {
                result.Add(list[i]);
            }
            Console.WriteLine(String.Join(" ", result));
        }

        static void PrintNormal(List<string> list)
        {
            Console.WriteLine($"Frogs: {(String.Join(" ", list))}");
        }
        static void PrintReversed(List<string> list)
        {
            list.Reverse();
            Console.WriteLine($"Frogs: {(String.Join(" ", list))}");
        }
    }
}
