using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._3HeroRecruitment
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> heroes = new Dictionary<string, List<string>>();
            while (input != "End")
            {
                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string hero = command[1];
                string action = command[0];
                if (action == "Enroll")
                {
                    if (heroes.ContainsKey(hero))
                    {
                        Console.WriteLine($"{hero} is already enrolled.");
                    }
                    else
                    {
                        heroes.Add(hero, new List<string>());
                    }
                }
                else if (action == "Learn")
                {
                    string spell = command[2];
                    if (heroes.ContainsKey(hero))
                    {
                        if (heroes[hero].Contains(spell))
                        {
                            Console.WriteLine($"{hero} has already learnt {spell}.");
                        }
                        else
                        {
                            heroes[hero].Add(spell);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{hero} doesn't exist.");
                    }
                }
                else if (action == "Unlearn")
                {
                    string spell = command[2];
                    if (heroes.ContainsKey(hero))
                    {
                        if (heroes[hero].Contains(spell))
                        {
                            heroes[hero].Remove(spell);
                        }
                        else
                        {
                            Console.WriteLine($"{hero} doesn't know {spell}.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"{hero} doesn't exist.");
                    }
                }


                input = Console.ReadLine();
            }
            heroes = heroes.OrderByDescending(h => h.Value.Count).ThenBy(h => h.Key).ToDictionary(h => h.Key, l => l.Value);
            Console.WriteLine("Heroes: ");
            foreach (var item in heroes)
            {
                Console.WriteLine($"== {item.Key}: {String.Join(", ", item.Value)}");
            }
        }
    }
}
