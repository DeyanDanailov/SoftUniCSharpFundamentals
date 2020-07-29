using System;
using System.Collections.Generic;

namespace _02._WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> synonyms = new Dictionary<string, List<string>>();
            int cycles = int.Parse(Console.ReadLine());
            for (int i = 0; i < cycles; i++)
            {
                string key = Console.ReadLine();
                string value = Console.ReadLine();
                if (synonyms.ContainsKey(key))
                {
                    synonyms[key].Add(value);
                }
                else
                {
                    synonyms.Add(key, new List<string>());
                    synonyms[key].Add(value);
                }
            }
            foreach (var item in synonyms)
            {
                Console.WriteLine(item.Key + " - " + String.Join(", ",item.Value));
            }
        }
    }
}
