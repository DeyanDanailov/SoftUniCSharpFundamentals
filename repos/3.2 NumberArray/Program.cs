using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._2_NumberArray
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                string input = Console.ReadLine();
                while (input != "End")
                {
                    List<string> command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                    if (command[0] == "Switch")
                    {
                        Switch(numbers, int.Parse(command[1]));
                    }
                    else if (command[0] == "Change")
                    {
                        Change(numbers, int.Parse(command[1]), int.Parse(command[2]));
                    }
                    else if (command[0] == "Sum")
                    {
                        if (command[1]=="Negative")
                        {
                            Console.WriteLine(SumNegative(numbers));
                        }
                        else if (command[1] == "Positive")
                        {
                            Console.WriteLine(SumPositive(numbers));
                        }
                        else if (command[1] == "All")
                        {
                            Console.WriteLine(numbers.Sum());
                        }
                    }
                    input = Console.ReadLine();
                }
                List<int> positive = numbers.FindAll(n => n >= 0);
                Console.WriteLine(String.Join(" ", positive));
            }
            static List<int> Switch(List<int> list, int index)
            {
                if (index >= 0 && index < list.Count)
                {
                    list[index] = -(list[index]);
                    return list;
                }
                else
                {
                    return list;
                }
            }
            static List<int> Change(List<int> list, int index, int number)
            {
                if (index >= 0 && index < list.Count)
                {
                    list.RemoveAt(index);
                    list.Insert(index, number);
                    return list;
                }
                else
                {
                    return list;
                }
            }
            static int SumNegative(List<int> list)
            {
                List<int> negative = list.FindAll(n => n < 0);
                return negative.Sum();
            }
            static int SumPositive(List<int> list)
            {
                List<int> positive = list.FindAll(n => n >= 0);
                return positive.Sum();
            }

        }
    }
}
