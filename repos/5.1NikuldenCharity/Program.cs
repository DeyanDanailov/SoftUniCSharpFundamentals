using System;

namespace _5._1NikuldenCharity
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string input = Console.ReadLine();
            while (input != "Finish")
            {
                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string action = command[0];
                if (action == "Replace")
                {
                    text = text.Replace(command[1], command[2]);
                    Console.WriteLine(text);
                }
                else if (action == "Cut")
                {
                    int startIndex = int.Parse(command[1]);
                    if (startIndex > 0 && startIndex < text.Length && int.Parse(command[2]) > 0 && int.Parse(command[2]) < text.Length)
                    {
                        int length = int.Parse(command[2]) - startIndex +1;
                        text = text.Remove(startIndex, length);
                        Console.WriteLine(text);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indexes!");
                    }

                }
                else if (action == "Make")
                {
                    if (command[1] == "Upper")
                    {
                        text = text.ToUpper();
                        Console.WriteLine(text);
                    }
                    else if (command[1] == "Lower")
                    {
                        text = text.ToLower();
                        Console.WriteLine(text);
                    }
                }
                else if (action == "Check")
                {
                    if (text.Contains(command[1]))
                    {
                        Console.WriteLine($"Message contains {command[1]}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {command[1]}");
                    }
                }
                else if (action == "Sum")
                {
                    int startIndex = int.Parse(command[1]);
                    if (startIndex > 0 && startIndex < text.Length && int.Parse(command[2]) > 0 && int.Parse(command[2]) < text.Length)
                    {
                        int length = int.Parse(command[2]) - startIndex +1;
                        char[] toSum = text.Substring(startIndex, length).ToCharArray();
                        int sum = 0;
                        foreach (var item in toSum)
                        {
                            sum += item;
                        }                       
                        Console.WriteLine(sum);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                }
                input = Console.ReadLine();
            }
        }
    }
}
