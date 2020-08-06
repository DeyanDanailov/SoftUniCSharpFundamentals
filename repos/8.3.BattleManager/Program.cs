using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._3.BattleManager
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Hero> heroes = new Dictionary<string, Hero>();
            while (input != "Results")
            {
                string[] command = input.Split(':', StringSplitOptions.RemoveEmptyEntries);
                string action = command[0];
                if (action == "Add")
                { 
                    string heroName = command[1];
                    int health = int.Parse(command[2]);
                    int energy = int.Parse(command[3]);
                    Add(heroes, heroName, health, energy);
                }
                else if (action == "Attack")
                {
                    string attackerName = command[1];
                    string defenderName = command[2];
                    int damage = int.Parse(command[3]);
                    Attack(heroes, attackerName, defenderName, damage);
                }
                else if (action == "Delete")
                {
                    string toDelete = command[1];
                    if (toDelete == "All")
                    {
                        heroes.Clear();
                    }
                    else
                    {
                        if (heroes.ContainsKey(toDelete))
                        {
                            heroes.Remove(toDelete);
                        }
                    }
                }
                input = Console.ReadLine();
            }
            heroes = heroes.OrderByDescending(x => x.Value.Health).ThenBy(h => h.Key).ToDictionary(a => a.Key, b => b.Value);
            Console.WriteLine($"People count: {heroes.Count}");
            foreach (var item in heroes)
            {
                Console.WriteLine($"{item.Key} - {item.Value.Health} - {item.Value.Energy}");
            }
        }
        public static void Add(Dictionary<string, Hero> heroes, string heroName, int health, int energy)
        {
            if (!heroes.ContainsKey(heroName))
            {
                heroes.Add(heroName, new Hero { Health = health, Energy = energy });
            }
            else
            {
                heroes[heroName].Health += health;
            }          
        }
        public static void Attack(Dictionary<string, Hero> heroes, string attackerName, string defenderName, int damage)
        {
            if (heroes.ContainsKey(attackerName) && heroes.ContainsKey(defenderName))
            {
                heroes[defenderName].Health -= damage;
                if (heroes[defenderName].Health<0)
                {
                    heroes.Remove(defenderName);
                    Console.WriteLine($"{defenderName} was disqualified!");
                }
                heroes[attackerName].Energy--;
                if (heroes[attackerName].Energy == 0)
                {
                    heroes.Remove(attackerName);
                    Console.WriteLine($"{attackerName} was disqualified!");
                }
            }
        }
    }
    public class Hero
    {
        public int Health { get; set; }
        public int Energy { get; set; }
    }
}
