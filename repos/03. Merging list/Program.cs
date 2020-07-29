using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers1 = ReadIntListSingleLine();
            List<int> numbers2 = ReadIntListSingleLine();
            List<int> result = new List<int>();
            for (int i = 0; i < Math.Max(numbers1.Count, numbers2.Count); i++)
            {
                if (i<numbers1.Count)
                {
                    result.Add(numbers1[i]);
                }
                if (i < numbers2.Count)
                {
                    result.Add(numbers2[i]);
                }
            }
            Console.WriteLine(string.Join(" ", result));
        }
        static List<int> ReadIntListSingleLine()
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            return list;
        }
        
    }
}
