using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_manipulation_advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> numbersCopy = new List<int>(numbers);
            for (int i = 0; i < numbers.Count; i++)
            {
                numbersCopy[i] = numbers[i];
            }
 
            string input = Console.ReadLine();
    
            while (input != "end")
            {
                string[] command = input.Split();
                if (command[0] == "Contains")
                {
                    ContainsIntInList(numbers, int.Parse(command[1]));
                }
                else if (command[0] == "PrintEven")
                {
                    PrintEven(numbers);
                }
                else if (command[0] == "PrintOdd")
                {
                    PrintOdd(numbers);
                }
                else if (command[0] == "GetSum")
                {
                    Console.WriteLine(numbers.Sum());
                }
                else if (command[0] == "Filter")
                {
                    Filter(numbers, command[1], int.Parse(command[2]));
                }
                else if (command[0] == "Add")
                {
                    AddInt(numbers, int.Parse(command[1]));
                }
                else if (command[0] == "Remove")
                {
                    RemoveInt(numbers, int.Parse(command[1]));
                }
                else if (command[0] == "RemoveAt")
                {
                    RemoveAtIndex(numbers, int.Parse(command[1]));
                }
                else if (command[0] == "Insert")
                {
                    Insert(numbers, int.Parse(command[1]), int.Parse(command[2]));
                }
                input = Console.ReadLine();
            }
            for (int j = 0; j < numbers.Count; j++)
            {
                if (numbers[j] != numbersCopy[j])
                {
                    
                    Console.WriteLine(String.Join(" ", numbers));
                    break;
                }
                
            }
            return;
        }
       
       
        static void ContainsIntInList(List<int> list, int numToCheck)
        {
            if (list.Contains(numToCheck))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No such number");
            }
        }
        static void PrintEven(List<int> list)
        {
            List<int> newList = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 0)
                {
                    newList.Add(list[i]);
                }
            }
            Console.WriteLine(String.Join(" ", newList));
        }
        static void PrintOdd(List<int> list)
        {
            List<int> newList = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] % 2 == 1)
                {
                    newList.Add(list[i]);
                }
            }
            Console.WriteLine(String.Join(" ", newList));
        }
        static void Filter(List<int> list, string sign, int num)
        {
            List<int> newList = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                if (sign == ">" && list[i] > num)
                {
                    newList.Add(list[i]);
                }
                else if (sign == "<" && list[i] < num)
                {
                    newList.Add(list[i]);
                }
                else if (sign == ">=" && list[i] >= num)
                {
                    newList.Add(list[i]);
                }
                else if (sign == "<=" && list[i] <= num)
                {
                    newList.Add(list[i]);
                }
            }
            Console.WriteLine(String.Join(" ", newList));
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
