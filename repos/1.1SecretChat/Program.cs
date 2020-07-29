using System;
using System.Linq;

namespace _1._1SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string input;

            while ((input = Console.ReadLine()) != "Reveal")
            {
                string[] command = input.Split(":|:", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string action = command[0];
                if (action == "InsertSpace")
                {
                    text = text.Insert(int.Parse(command[1]), " ");
                }
                else if (action == "Reverse")
                {
                    int index = text.IndexOf(command[1]);
                    if (index == -1)
                    {
                        Console.WriteLine("error");
                        continue;
                    }
                    else
                    {
                        string toAdd = text.Substring(index, command[1].Length);
                        if (toAdd == command[1])
                        {
                            text = text.Remove(index, command[1].Length);
                            char[] chars = toAdd.ToCharArray().Reverse().ToArray();
                            string result = new string(chars);
                            text += result;
                        }
                        else
                        {
                            Console.WriteLine("error");
                            continue;
                        }
                    }
                }
                else if (action == "ChangeAll")
                {
                    text = ReplaceText(text, command);
                }
                Console.WriteLine(text);
                
            }
            Console.WriteLine($"You have a new text message: {text}");
        }

        public static string ReplaceText(string text, string[] command)
        {
            int index = text.IndexOf(command[1]);
            while (index !=-1)
            {
                text = text.Remove(index, command[1].Length).ToString();
                text = text.Insert(index, command[2]).ToString();
                index = text.IndexOf(command[1]);
            }
            return text;
        }      
    }
}
