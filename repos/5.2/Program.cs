using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string input = Console.ReadLine();
            while (input!="end")
            {
                string[] command = input.Split().ToArray();
                if (command[0] == "swap")
                {
                    Swap(numbers, int.Parse(command[1]), int.Parse(command[2]));
                }
                else if (command[0] == "multiply")
                {
                    Multiply(numbers, int.Parse(command[1]), int.Parse(command[2]));
                }
                else if (command[0] == "decrease")
                {
                    Decrease(numbers);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(String.Join(", ", numbers));
        }
        static List<int> Swap(List<int> list, int index1, int index2)
        {
            int element1 = list[index1];
            int element2 = list[index2];
            int temp = element1;
            list[index1] = element2;
            list[index2] = temp;

            return list;
        }
        static List<int> Multiply(List<int> list, int index1, int index2)
        {
            int element1 = list[index1];
            int element2 = list[index2];
            list[index1] = element1 * element2;
            
            return list;
        }
        static List<int> Decrease(List<int> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list[i] = list[i] - 1;
            }
            return list;
        }
    }
    
}
