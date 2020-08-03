using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._3NikuldenMeals
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> guests = new Dictionary<string, List<string>>();
            int unlikedMealsCounter = 0;
            while (input != "Stop")
            {
                string[] mealInfo = input.Split('-', StringSplitOptions.RemoveEmptyEntries).ToArray();
                string action = mealInfo[0];
                string guest = mealInfo[1];
                string meal = mealInfo[2];
                if (action == "Like")
                {
                    LikeMeal(guests, guest, meal);
                }
                else if (action == "Unlike")
                {
                   unlikedMealsCounter = UnlikeMeal(guests, guest, meal, unlikedMealsCounter);
                }
                input = Console.ReadLine();
            }
            guests = guests.OrderByDescending(x => x.Value.Count).ThenBy(a => a.Key).ToDictionary(a => a.Key, b => b.Value);
            foreach (var item in guests)
            {
                Console.WriteLine($"{item.Key}: {String.Join(", ", item.Value)}");
            }
            Console.WriteLine($"Unliked meals: {unlikedMealsCounter}");
        }
        static void LikeMeal(Dictionary<string, List<string>> guests, string guest, string meal)
        {
            if (guests.ContainsKey(guest))
            {
                if (guests[guest].Contains(meal))
                {
                    return;
                }
                else
                {
                    guests[guest].Add(meal);
                }
            }
            else
            {
                guests.Add(guest, new List<string>());
                guests[guest].Add(meal);
            }          
        }
        static int UnlikeMeal(Dictionary<string, List<string>> guests, string guest, string meal, int unLikedMealsCounter)
        {
            if (guests.ContainsKey(guest))
            {
                if (guests[guest].Contains(meal))
                {
                    guests[guest].Remove(meal);
                    Console.WriteLine($"{guest} doesn't like the {meal}.");
                    unLikedMealsCounter++;
                    return unLikedMealsCounter;
                }
                else
                {
                    Console.WriteLine($"{guest} doesn't have the {meal} in his/her collection.");
                    return unLikedMealsCounter;
                }
            }
            else
            {
                Console.WriteLine($"{guest} is not at the party.");
                return unLikedMealsCounter;
            }
        }
    }
}
