using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._2_TaskPlanner
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> tasks = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string input = Console.ReadLine();
            while (input != "End")
            {
                List<string> command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                if (command[0] == "Complete")
                {
                    ChangeTask(tasks, int.Parse(command[1]), 0);
                }
                else if (command[0] == "Change")
                {
                    ChangeTask(tasks, int.Parse(command[1]), int.Parse(command[2]));
                }
                else if (command[0] == "Drop")
                {
                    ChangeTask(tasks, int.Parse(command[1]), -1);
                }
                else if (command[0] == "Count")
                {
                    if (command[1] == "Completed")
                    {
                        Console.WriteLine(tasks.FindAll(t => t == 0).Count);
                    }
                    else if (command[1] == "Incomplete")
                    {
                        Console.WriteLine(tasks.FindAll(t => t >0).Count);
                    }
                    else if (command[1] == "Dropped")
                    {
                        Console.WriteLine(tasks.FindAll(t => t == -1).Count);
                    }
                }
                input = Console.ReadLine();
            }
            List<int> finalIncomplete = tasks.FindAll(t => (t >0));
            Console.WriteLine(String.Join(" ", finalIncomplete));

        }
        static List<int> ChangeTask(List<int> list, int index, int newTask)
        {
            if (index >= 0 && index < list.Count)
            {
                list.RemoveAt(index);
                list.Insert(index, newTask);
                return list;
            }
            else 
                return list;
        }
       
    }
}
