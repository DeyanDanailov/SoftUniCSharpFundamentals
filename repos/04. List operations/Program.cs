using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = Console.ReadLine();         
            while (input != "End")
            {
                List<string> command = input.Split().ToList();
                if (command[0] == "Add")
                {
                    AddElement(numbers, int.Parse(command[1]));
                }
                else if (command[0] == "Insert")
                {
                    if (int.Parse(command[2])<0 ||int.Parse(command[2])>numbers.Count-1)
                    {
                        Console.WriteLine("Invalid index");
                        goto label;
                    }
                    else
                    {
                        InsertElement(numbers, int.Parse(command[1]), int.Parse(command[2]));
                    }
                   
                }
                else if (command[0] == "Remove")
                {
                    if (int.Parse(command[1]) < 0 || (int.Parse(command[1]) > numbers.Count - 1))
                    {
                        Console.WriteLine("Invalid index");
                        goto label;                        
                    }
                    else
                    {
                        RemoveAtIndex(numbers, int.Parse(command[1]));
                    }                    
                }
                else if (command[0] == "Shift")
                {
                    if (command[1] == "left")
                    {
                        ShiftLeft(numbers, int.Parse(command[2]));
                    }
                    else if (command[1] == "right")
                    {
                        ShiftRight(numbers, int.Parse(command[2]));
                    }
                }
                label:
                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
        static List<int> InsertElement(List<int> list, int numToInsert, int index)
        {
            list.Insert(index, numToInsert);
            return list;
        }
        static List<int> AddElement(List<int> list, int element)
        {
            list.Add(element);
            return list;
        }
        static List<int> RemoveAtIndex(List<int> list, int index)
        {
            list.RemoveAt(index);
            return list;
        }
        static List<int> ShiftLeft(List<int> list, int times)
        {
            for (int i = 0; i < times; i++)
            {
                int temp = list[0];
                list.RemoveAt(0);
                list.Add(temp);
            }
            return list;
        }
        static List<int> ShiftRight(List<int> list, int times)
        {
            for (int i = 0; i < times; i++)
            {
                int temp = list[list.Count-1];
                list.RemoveAt(list.Count-1);
                list.Insert(0, temp);
            }
            return list;
        }
    }
}
