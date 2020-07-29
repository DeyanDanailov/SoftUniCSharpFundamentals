using System;
using System.Collections.Generic;

namespace _02._MinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var resourcesQuantity = new Dictionary<string, int>();
            string input = Console.ReadLine();
            int inputCounter = 1;
            string resource = String.Empty;
            while (input != "stop")
            {
                                
                if (inputCounter % 2 == 1)
                {
                    resource = input;
                    if (!resourcesQuantity.ContainsKey(input))
                    {
                        resourcesQuantity.Add(input, 0);
                    }
                }
                else
                {
                    resourcesQuantity[resource] += int.Parse(input);
                }
                inputCounter++;
                input = Console.ReadLine();
            }
            foreach (var item in resourcesQuantity)
            {
                Console.WriteLine(item.Key + " -> " + item.Value);
            }
        }
    }
}
