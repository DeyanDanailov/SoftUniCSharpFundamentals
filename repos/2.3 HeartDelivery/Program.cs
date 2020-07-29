using System;
using System.Linq;

namespace _2._3_HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] houses = Console.ReadLine().Split("@", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            string input = Console.ReadLine();
            int startIndex = 0;
            int valentineHouses = 0;
            while (input != "Love!")
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                int jumpLength = int.Parse(command[1]);
                int loveIndex = startIndex + jumpLength;
                if (loveIndex>houses.Length-1)
                {
                    loveIndex = 0;
                }
                if (houses[loveIndex]==0)
                {
                    Console.WriteLine($"Place {loveIndex} already had Valentine's day.");
                }
                else
                {
                    houses[loveIndex] -= 2;
                    if (houses[loveIndex] == 0)
                    {
                        Console.WriteLine($"Place {loveIndex} has Valentine's day.");
                        valentineHouses++;
                    }
                }
                startIndex = loveIndex;
                input = Console.ReadLine();
            }
            Console.WriteLine($"Cupid's last position was {startIndex}.");
            if (valentineHouses==houses.Length)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                Console.WriteLine($"Cupid has failed {houses.Length-valentineHouses} places.");
            }
            
        }
    }
}
