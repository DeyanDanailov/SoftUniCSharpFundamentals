using System;
using System.Linq;

namespace _4._1WarriorQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            string skill = Console.ReadLine();
            string input = Console.ReadLine();
            while (input != "For Azeroth")
            {
                string[] command = input.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (command[0] == "GladiatorStance")
                {
                    skill = skill.ToUpper();
                    Console.WriteLine(skill);
                }
                else if (command[0] == "DefensiveStance")
                {
                    skill = skill.ToLower();
                    Console.WriteLine(skill);
                }
                else if (command[0] == "Dispel")
                {
                    int index = int.Parse(command[1]);
                    if (index < 0 || index > skill.Length - 1)
                    {
                        Console.WriteLine("Dispel too weak.");
                    }
                    else
                    {                      
                        char letter = char.Parse(command[2]);
                        char[] temp = skill.ToCharArray();
                        temp[index] = letter;
                        skill = new string(temp);
                        Console.WriteLine("Success!");
                    }
                    
                }
                else if (command[0] == "Target")
                {
                    string substring = command[2];
                    
                    if (command[1] == "Change" && skill.Contains(substring))
                    {
                        string secondSubstring = command[3];                       
                        skill = skill.Replace(substring, secondSubstring);
                        Console.WriteLine(skill);
                    }
                    else if (command[1] == "Remove" && skill.Contains(substring))
                    { 
                        int indexToRemove = skill.IndexOf(substring);
                        skill = skill.Remove(indexToRemove, substring.Length);
                        Console.WriteLine(skill);
                    }
                    else
                    {
                        Console.WriteLine("Command doesn't exist!");
                    }

                }
                else
                {
                    Console.WriteLine("Command doesn't exist!");
                }

                input = Console.ReadLine();
            }
        }
    }
}
