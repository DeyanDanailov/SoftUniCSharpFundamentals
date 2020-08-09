using System;

namespace _11._1.Exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string input = Console.ReadLine();
            while (input != "Travel")
            {
                string[] command = input.Split(':', StringSplitOptions.RemoveEmptyEntries);
                string action = command[0];
                if (action == "Add Stop")
                {
                    int index = int.Parse(command[1]);
                    if (index >= 0 && index < text.Length)
                    {
                        text = text.Insert(index, command[2]);                      
                    }
                    
                } 
                else if (action == "Remove Stop")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);
                    if (startIndex>=0 && startIndex <= endIndex && endIndex < text.Length)
                    {
                        int length = endIndex - startIndex + 1;
                        text = text.Remove(startIndex, length);                       
                    }
                   
                }
                else if (action == "Switch")
                {
                    string oldString = command[1];
                    string newString = command[2];
                    if (text.Contains(oldString))
                    {
                        text = text.Replace(oldString, newString);
                        //Console.WriteLine(text);
                    }
                    
                }
                Console.WriteLine(text);
                input = Console.ReadLine();
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {text}");
        }
    }
}
