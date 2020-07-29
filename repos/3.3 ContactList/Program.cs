using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._3_ContactList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> contactList = Console.ReadLine().Split().ToList();
            List<string> command = Console.ReadLine().Split().ToList();

            while (command[0] != "Print")
            {
                if (command[0] == "Add")
                {
                    Add(contactList, command[1], int.Parse(command[2]));
                }
                else if (command[0] == "Remove")
                {
                    Remove(contactList, int.Parse(command[1]));
                }
                else if (command[0] == "Export")
                {
                    Export(contactList, int.Parse(command[1]), int.Parse(command[2]));
                }
                command = Console.ReadLine().Split().ToList();
            }
            if (command[1] == "Normal")
            {
                PrintNormal(contactList);
            }
            else if (command[1] == "Reversed")
            {
                PrintReversed(contactList);
            }
        }
        static List<string> Add(List<string> list, string contact, int index)
        {
            if (list.Contains(contact))
            {
                if (index >= 0 && index < list.Count)
                {
                    list.Insert(index, contact);
                }
                else
                {
                    return list;
                }
            }
            else
            {
                list.Add(contact);
            }
            return list;
        }
        static List<string> Remove(List<string> list, int index)
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
            Console.WriteLine($"Contacts: {(String.Join(" ", list))}");
        }
        static void PrintReversed(List<string> list)
        {
            list.Reverse();
            Console.WriteLine($"Contacts: {(String.Join(" ", list))}");
        }
    }
}
