using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._OddOccurences
{
    class Program
    {
        static void Main(string[] args)
        {
            var wordsLine = Console.ReadLine().Split().ToList();
            Dictionary<string, int> words = new Dictionary<string, int>();
            for (int i = 0; i < wordsLine.Count; i++)
            {
                wordsLine[i] = wordsLine[i].ToLower();
                if (!words.ContainsKey(wordsLine[i]))
                {
                    words.Add(wordsLine[i], 1);
                }
                else
                {
                    words[wordsLine[i]]++;
                }
            }
            foreach (var item in words)
            {
                if (item.Value%2==1)
                {
                    Console.Write(item.Key + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
