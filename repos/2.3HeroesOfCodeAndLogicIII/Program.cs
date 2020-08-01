using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._3HeroesOfCodeAndLogicIII
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, int[]> heroes = new Dictionary<string, int[]>();
            for (int i = 0; i < n; i++)
            {
                string[] heroHM = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                heroes.Add(heroHM[0], new int[] { int.Parse(heroHM[1]), int.Parse(heroHM[2]) });
                
            }
            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] command = input.Split(" - ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string action = command[0];
                string hero = command[1];
                int health = heroes[hero][0];
                int mana = heroes[hero][1];
                if (action == "CastSpell")
                {
                    CastSpell(heroes, command, hero, mana);
                }
                else if (action == "TakeDamage")
                {
                    TakeDamage(heroes, command, hero, health);
                }
                else if (action == "Recharge")
                {
                    Recharge(heroes, command, hero);
                }
                else if (action == "Heal")
                {
                    Heal(heroes, command, hero);
                }

                input = Console.ReadLine();
            }
            heroes = heroes.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Key).ToDictionary(a => a.Key, b => b.Value);
            foreach (var hero in heroes)
            {
                Console.WriteLine(hero.Key);
                Console.WriteLine($"  HP: {hero.Value[0]}");
                Console.WriteLine($"  MP: {hero.Value[1]}");
            }
        }

        private static void Heal(Dictionary<string, int[]> heroes, string[] command, string hero)
        {
            int ammount = int.Parse(command[2]);
            int beforeHealing = heroes[hero][0];
            heroes[hero][0] += ammount;
            if (heroes[hero][0] > 100)
            {
                Console.WriteLine($"{hero} healed for {100 - beforeHealing} HP!");
                heroes[hero][0] = 100;
            }
            else
            {
                Console.WriteLine($"{hero} healed for {ammount} HP!");
            }
        }

        private static void Recharge(Dictionary<string, int[]> heroes, string[] command, string hero)
        {
            int ammount = int.Parse(command[2]);
            int beforeRecharging = heroes[hero][1];
            heroes[hero][1] += ammount;
            if (heroes[hero][1] > 200)
            {
                Console.WriteLine($"{hero} recharged for {200 - beforeRecharging} MP!");
                heroes[hero][1] = 200;
            }
            else
            {
                Console.WriteLine($"{hero} recharged for {ammount} MP!");
            }
        }

        private static void TakeDamage(Dictionary<string, int[]> heroes, string[] command, string hero, int health)
        {
            int damage = int.Parse(command[2]);
            string attacker = command[3];
            health -= damage;
            if (health > 0)
            {
                heroes[hero][0] -= damage;
                Console.WriteLine($"{hero} was hit for {damage} HP by {attacker} and now has {health} HP left!");
            }
            else
            {
                heroes.Remove(hero);
                Console.WriteLine($"{hero} has been killed by {attacker}!");
            }
        }

        private static void CastSpell(Dictionary<string, int[]> heroes, string[] command, string hero, int mana)
        {
            int manaNeeded = int.Parse(command[2]);
            string spellName = command[3];

            if (manaNeeded <= mana)
            {
                heroes[hero][1] -= manaNeeded;
                Console.WriteLine($"{hero} has successfully cast {spellName} and now has {mana - manaNeeded} MP!");
            }
            else
            {
                Console.WriteLine($"{hero} does not have enough MP to cast {spellName}!");
            }
        }
    }
}
