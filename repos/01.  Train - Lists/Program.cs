using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.__Train___Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> train = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxPassengersPerWagon = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            while (input != "end")
            {
                List<string> command = input.Split().ToList();
                if (command[0] == "Add")
                {
                    AddWagon(train, int.Parse(command[1]));
                }
                else
                {
                    for (int i = 0; i < train.Count; i++)
                    {
                        if (train[i] + int.Parse(command[0]) <= maxPassengersPerWagon)
                        {
                            train[i] += int.Parse(command[0]);
                            break;
                        }
                    }
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(" ", train));
        }
        static List<int> AddWagon (List<int> list, int newWagon)
        {
            list.Add(newWagon);
            return list;
        }
        
    }
}
