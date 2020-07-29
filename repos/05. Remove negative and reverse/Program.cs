using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Remove_negative_and_reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = ReadIntListSingleLine();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers.RemoveAt(i);
                    i-=1;
                }
                
            }

            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                numbers.Reverse();
                Console.WriteLine(String.Join(" ", numbers));
            }
        }
        static List<int> ReadIntListSingleLine()
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            return list;
        }

    }
}
