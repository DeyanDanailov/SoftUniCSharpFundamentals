using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_manipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = ReadIntListSingleLine();
            numbers = ManipulatingIntLists(numbers);
            Console.WriteLine(String.Join(" ", numbers));
        }
        static List<int> ReadIntListSingleLine()
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            return list;
        }
        static List<int> ManipulatingIntLists(List<int> list)
        {
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] command = input.Split();
                if (command[0] == "Add")
                {
                    AddInt(list, int.Parse(command[1]));
                }
                else if (command[0] == "Remove")
                {
                    RemoveInt(list, int.Parse(command[1]));
                }
                else if (command[0] == "RemoveAt")
                {
                    RemoveAtIndex(list, int.Parse(command[1]));
                }
                else if (command[0] == "Insert")
                {
                    Insert(list, int.Parse(command[1]), int.Parse(command[2]));
                }
                input = Console.ReadLine();
            }
            return list;
        }
        static List<int> AddInt(List<int> list, int num)
        {
            list.Add(num);
            return list;
        }
        static List<int> RemoveInt(List<int> list, int num)
        {
            list.Remove(num);
            return list;
        }
        static List<int> RemoveAtIndex(List<int> list, int index)
        {
            list.RemoveAt(index);
            return list;
        }
        static List<int> Insert(List<int> list, int num, int index)
        {
            list.Insert(index, num);
            return list;
        }
    }
}
