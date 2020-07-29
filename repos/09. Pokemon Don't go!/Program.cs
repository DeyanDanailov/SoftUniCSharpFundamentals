using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Pokemon_Don_t_go_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int indexToRemove = int.Parse(Console.ReadLine());
            int sum = 0;
            int value = 0;
            while (pokemons.Count > 0)
            {
                if (indexToRemove < 0)
                {
                    sum += pokemons[0];
                    value = pokemons[0];
                    pokemons.RemoveAt(0);
                    pokemons.Insert(0, pokemons[pokemons.Count - 1]);
                    IndexingPokemons(pokemons, value);
                }
                else if (indexToRemove >= 0 && indexToRemove < pokemons.Count)
                {
                    sum += pokemons[indexToRemove];
                    value = pokemons[indexToRemove];
                    pokemons.RemoveAt(indexToRemove);
                    IndexingPokemons(pokemons, value);
                }
                else if (indexToRemove>=pokemons.Count)                              
                {
                    sum += pokemons[pokemons.Count - 1];
                    value = pokemons[pokemons.Count - 1];
                    pokemons.RemoveAt(pokemons.Count - 1);
                    pokemons.Add(pokemons[0]);
                    IndexingPokemons(pokemons, value);
                }
                if (pokemons.Count==0)
                {
                    break;
                }
                indexToRemove = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
        static List<int> IndexingPokemons(List<int> list, int value)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] <= value)
                {
                    list[i] += value;
                }
                else
                {
                    list[i] -= value;
                }
            }
            return list;
        }
    }
}
