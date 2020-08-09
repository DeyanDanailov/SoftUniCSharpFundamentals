using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _11._3.Exam3
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            Dictionary<string, Plant> allPlants = new Dictionary<string, Plant>();
            for (long i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split("<->", StringSplitOptions.RemoveEmptyEntries);
                string plantName = command[0];
                long rarity = long.Parse(command[1]);
                if (allPlants.ContainsKey(plantName))
                {
                    allPlants[plantName].Rarity = rarity;
                }
                allPlants.Add(plantName, new Plant {Rarity = rarity, Rating = new List<long>() });               
            }
            string command2 = Console.ReadLine();
            while (command2 != "Exhibition")
            {
                string[] actions = command2.Split(new string[] {": ", " - "}, StringSplitOptions.RemoveEmptyEntries);

                if (actions[0] == "Rate")
                {
                    string plantName = actions[1];
                    if (allPlants.ContainsKey(plantName))
                    {                       
                        long currentRating = long.Parse(actions[2]);
                        allPlants[plantName].Rating.Add(currentRating);
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                    
                }
                else if (actions[0] == "Update")
                {
                    string plantName = actions[1];
                    if (allPlants.ContainsKey(plantName))
                    {
                        long newRarity = long.Parse(actions[2]);
                        allPlants[plantName].Rarity = newRarity;
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (actions[0] == "Reset")
                {
                    string plantName = actions[1];
                    if (allPlants.ContainsKey(plantName))
                    {
                       
                        allPlants[plantName].Rating.Clear();
                    }
                    else
                    {
                        Console.WriteLine("error");
                    }
                }
                else
                {
                    Console.WriteLine("error");
                }
                command2 = Console.ReadLine();
            }
            foreach (var item in allPlants)
            {
                if (item.Value.Rating.Count==0)
                {
                    item.Value.AverageRating = 0;
                }
                else
                {
                    item.Value.AverageRating = item.Value.Rating.Average();
                }
               
            }
            allPlants = allPlants.OrderByDescending(x => x.Value.Rarity)
                .ThenByDescending(x => x.Value.AverageRating)
                .ToDictionary(a => a.Key, b => b.Value);
            Console.WriteLine("Plants for the exhibition:");
            foreach (var item in allPlants)
            {
                Console.WriteLine($"- {item.Key}; Rarity: {item.Value.Rarity}; Rating: {item.Value.AverageRating:f2}");
            }
        }
    }
    public class Plant
    {
        public long Rarity { get; set; }
        public List<long> Rating { get; set; }
        public double AverageRating { get; set; }
    }
}
