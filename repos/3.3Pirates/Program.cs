using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._3Pirates
{
    public class City
    {
        public int population { get; set; }
        public int gold { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, City> allCities = new Dictionary<string, City>();
            while (input != "Sail")
            {
                string[] cityData = input.Split("||", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string cityName = cityData[0];
                if (allCities.ContainsKey(cityName))
                {
                    allCities[cityName].population += int.Parse(cityData[1]);
                    allCities[cityName].gold += int.Parse(cityData[2]);
                }
                else
                {
                    allCities.Add(cityName, new City());
                    allCities[cityName].population = int.Parse(cityData[1]);
                    allCities[cityName].gold = int.Parse(cityData[2]);
                }

                input = Console.ReadLine();
            }
            string eventInput = Console.ReadLine();
            while (eventInput != "End")
            {
                string[] events = eventInput.Split("=>", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string action = events[0];
                if (action == "Plunder")
                {
                    string cityToPlunder = events[1];
                    int peopleToKill = int.Parse(events[2]);
                    int goldToSteal = int.Parse(events[3]);
                    Plunder(allCities, cityToPlunder, peopleToKill, goldToSteal);
                }
                if (action == "Prosper")
                {
                    string cityToProsper = events[1];
                    int goldToReceive = int.Parse(events[2]);
                    Prosper(allCities, cityToProsper, goldToReceive);
                }
                eventInput = Console.ReadLine();
            }
            allCities = allCities.OrderByDescending(g => g.Value.gold).ThenBy(n => n.Key).ToDictionary(n => n.Key, c => c.Value);
            if (allCities.Count>0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {allCities.Count} wealthy settlements to go to:");
                foreach (var item in allCities)
                {
                    Console.WriteLine($"{item.Key} -> Population: {item.Value.population} citizens, Gold: {item.Value.gold} kg");
                }
            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            
        }
        public static void Plunder(Dictionary<string, City> cities, string cityToPlunder, int peopleToKill, int goldToSteal)
        {
            if (!cities.ContainsKey(cityToPlunder))
            {
                return;
            }
            cities[cityToPlunder].population -= peopleToKill;
            cities[cityToPlunder].gold -= goldToSteal;
            Console.WriteLine($"{cityToPlunder} plundered! {goldToSteal} gold stolen, {peopleToKill} citizens killed.");
            if (cities[cityToPlunder].population <= 0 || cities[cityToPlunder].gold <= 0)
            {
                cities.Remove(cityToPlunder);
                Console.WriteLine($"{cityToPlunder} has been wiped off the map!");
            }
        }
        public static void Prosper(Dictionary<string, City> cities, string cityToProsper, int goldToReceive)
        {
            if (goldToReceive < 0)
            {
                Console.WriteLine("Gold added cannot be a negative number!");
                return;
            }
            cities[cityToProsper].gold += goldToReceive;
            Console.WriteLine($"{goldToReceive} gold added to the city treasury. {cityToProsper} now has {cities[cityToProsper].gold} gold.");
        }
    }
}
