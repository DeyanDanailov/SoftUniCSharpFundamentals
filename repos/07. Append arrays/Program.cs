using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lists = Console.ReadLine().Split('|').ToList();
            List<string> result = new List<string>();
            for (int i = lists.Count-1; i >=0; i--)
            {
                List<string> currentList = lists[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                result.AddRange(currentList);
            }
            Console.WriteLine(String.Join(" ", result));
        }
    }
}
