using System;
using System.Linq;

namespace _1._1SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string input = Console.ReadLine();

            while (input != "Reveal")
            {
                string[] command = input.Split(":|:", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string action = command[0];
                if (action == "InsertSpace")
                {
                    text.Insert(int.Parse(command[1]), " ");
                }
                else if (action == "Reverse")
                {
                    text = ReverseString(text, command);
                }
                else if (action=="ChangeAll")
                {
                    ReplaceText(text, command);
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"You have a new text message: {text}");
        }

        public static string ReplaceText(string text, string[] command)
        {
            int index = text.IndexOf(command[1]);
            while (index >0)
            {
                string newText = text.Remove(index, command[1].Length).ToString();
                text = newText.Insert(index, command[2]).ToString();
                index = text.IndexOf(command[1]);
            }
            return text;
        }

        public static string ReverseString(string text, string[] command)
        {
            int index = text.IndexOf(command[1]);
            string toAdd = text.Substring(index, command[1].Length);
            text.Remove(index, command[1].Length);
            char[] chars = toAdd.ToCharArray().Reverse().ToArray();
            //chars = toAdd.ToCharArray().Reverse().ToArray();
            string result = chars.ToString();
            text += result;
            return text;
        }
    }
}
