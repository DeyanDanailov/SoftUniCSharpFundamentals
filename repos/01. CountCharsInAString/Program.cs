using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            var charsCount =  new Dictionary <char, int> ();
            for (int i = 0; i < input.Length; i++)
            {
                string current = input[i];
                for (int j = 0; j < current.Length; j++)
                {
                    if (charsCount.ContainsKey(current[j]))
                    {
                        charsCount[current[j]]++;
                    }
                    else
                    {
                        charsCount.Add(current[j], 1);
                    }
                }
            }
            foreach (var item in charsCount)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
        }
    }
}
