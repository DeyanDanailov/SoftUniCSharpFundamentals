using System;
using System.Linq;

namespace _3._1ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string rawKey = Console.ReadLine();
            string input = Console.ReadLine();
            while (input != "Generate")
            {
                string[] command = input.Split(">>>", StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (command[0] == "Contains")
                {
                    if (rawKey.Contains(command[1]))
                    {
                        Console.WriteLine($"{rawKey} contains {command[1]}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                if (command[0] == "Flip")
                {
                    int startIndex = int.Parse(command[2]);
                    int endIndex = int.Parse(command[3]);
                    int lengthToChange = endIndex - startIndex;
                    if (command[1]=="Upper")
                    {
                        rawKey = rawKey.Replace(rawKey.Substring(startIndex, lengthToChange), rawKey.Substring(startIndex, lengthToChange).ToUpper());
                    }
                    else if (command[1]== "Lower")
                    {
                        rawKey = rawKey.Replace(rawKey.Substring(startIndex, lengthToChange), rawKey.Substring(startIndex, lengthToChange).ToLower());
                    }
                    Console.WriteLine(rawKey);
                }
                if (command[0] == "Slice")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);
                    int lengthToRemove = endIndex - startIndex;
                    rawKey = rawKey.Remove(startIndex, lengthToRemove);
                    Console.WriteLine(rawKey);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Your activation key is: {rawKey}");
        }
    }
}
