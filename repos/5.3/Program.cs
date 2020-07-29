using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            double sum = numbers.Sum();
            double average = sum / (numbers.Count * 1.0);
            numbers = TopFiveAboveAverage(numbers, average);
            Console.WriteLine(String.Join(" ", numbers));
        }
        static List<int> TopFiveAboveAverage(List<int> list, double average)
        {
            List<int> topFive = list.FindAll(n => n > average);
            topFive = topFive.OrderByDescending(n => n).ToList();
            List<int> result = new List<int>();
            if (topFive.Count>5)
            {              
                for (int i = 0; i < 5; i++)
                {
                    result.Add(topFive[i]);
                }
            }
            else if (topFive.Count==0)
            {
                Console.WriteLine("No");
                Environment.Exit(0);
            }
            else
            {
                result = topFive;
            }
            
            return result;
        }
    }
}
