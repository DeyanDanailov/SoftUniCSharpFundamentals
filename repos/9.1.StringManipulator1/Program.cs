using System;

namespace _8._1.StringManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] command = input.Split();
                string action = command[0];
                switch (action)
                {
                    case "Translate":
                        text = text.Replace(char.Parse(command[1]), char.Parse(command[2]));
                        Console.WriteLine(text);
                        break;
                    case "Includes":
                        if (text.Contains(command[1]))
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                        break;
                    case "Start":
                        if (text.StartsWith(command[1]))
                        {
                            Console.WriteLine("True");
                        }
                        else
                        {
                            Console.WriteLine("False");
                        }
                        break;
                    case "Lowercase":
                        if (text != null)
                        {
                            text = text.ToLower();
                            Console.WriteLine(text); ;
                        }
                        break;
                    case "FindIndex":
                        int charIndex = text.LastIndexOf(command[1]);
                        if (charIndex >= 0)
                        {
                            Console.WriteLine(charIndex);
                        }
                        break;
                    case "Remove":
                        text = text.Remove(int.Parse(command[1]), int.Parse(command[2]));
                        Console.WriteLine(text);
                        break;
                }

                input = Console.ReadLine();
            }
        }
    }
}
