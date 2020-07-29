using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            var resourcesQuantity = new SortedDictionary<string, int>();
            var junkResourceQuantity = new SortedDictionary<string, int>();
            resourcesQuantity.Add("shards", 0);
            resourcesQuantity.Add("motes", 0);
            resourcesQuantity.Add("fragments", 0);
            string input = Console.ReadLine().ToLower();
            bool legendaryItemObtained = false;
            while (!legendaryItemObtained)
            {
                string[] resources = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
                int quantity = 0;
                string resource = String.Empty;
                for (int i = 0; i < resources.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        quantity = int.Parse(resources[i]);
                    }
                    else
                    {
                        resource = resources[i];
                        if (resource == "shards" || resource == "fragments" || resource == "motes")
                        {
                            if (!resourcesQuantity.ContainsKey(resource))
                            {
                                resourcesQuantity.Add(resource, 0);
                            }
                            resourcesQuantity[resource] += quantity;
                            if (resourcesQuantity["shards"] >= 250)
                            {
                                legendaryItemObtained = true;
                                resourcesQuantity["shards"] -= 250;
                                Console.WriteLine("Shadowmourne obtained!");
                                break;
                            }
                            if (resourcesQuantity["fragments"] >= 250)
                            {
                                legendaryItemObtained = true;
                                resourcesQuantity["fragments"] -= 250;
                                Console.WriteLine("Valanyr obtained!");
                                break;
                            }
                            if (resourcesQuantity["motes"] >= 250)
                            {
                                legendaryItemObtained = true;
                                resourcesQuantity["motes"] -= 250;
                                Console.WriteLine("Dragonwrath obtained!");
                                break;
                            }
                        }
                        else
                        {
                            if (!junkResourceQuantity.ContainsKey(resource))
                            {
                                junkResourceQuantity.Add(resource, 0);
                            }
                            junkResourceQuantity[resource] += quantity;
                        }

                    }
                }
                if (legendaryItemObtained)
                {
                    break;
                }
                input = Console.ReadLine().ToLower();
            }
            Dictionary<string, int> resourcesQuantitySorted =
                 resourcesQuantity.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in resourcesQuantitySorted)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
            foreach (var item in junkResourceQuantity)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}
