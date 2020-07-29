using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = Console.ReadLine();
            while (input != "end")
            {
                List<string> command = input.Split().ToList();
                if (command[0]=="Delete")
                {
                    DeleteAllEquals(numbers, int.Parse(command[1]));
                }
                else if (command[0]=="Insert")
                {
                    InsertElement(numbers, int.Parse(command[1]), int.Parse(command[2]));
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", numbers));
        }
        static List<int> DeleteAllEquals(List<int> list, int numToDelete)
        {
            while (list.Contains(numToDelete))
            {
                list.Remove(numToDelete);
            }
            return list;
        }
        static List<int> InsertElement(List<int> list, int numToInsert, int index)
        {
            list.Insert(index, numToInsert);
            return list;
        }
    }
}
