using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string userName = Console.ReadLine();

        string input = Console.ReadLine();

        while (input != "Sign up")
        {
            string[] commands = input.Split(" ");

            string command = commands[0];

            if (command == "Case")
            {
                string casees = commands[1];
                if (casees == "lower")
                {
                    userName = userName.ToLower();
                    Console.WriteLine(userName);
                }
                else
                {
                    userName = userName.ToUpper();
                    Console.WriteLine(userName);
                }
            }
            else if (command == "Reverse")
            {
                int startIndex = int.Parse(commands[1]);
                int endIndex = int.Parse(commands[2]);

                if (startIndex >= 0 &&
                    endIndex > startIndex &&
                    endIndex < userName.Length)
                {

                    string word = userName.Substring(startIndex, (endIndex - startIndex) + 1);
                    Console.WriteLine(string.Join("", word.Reverse()));
                }
            }
            else if (command == "Cut")
            {
                string word = commands[1];
                if (userName.Contains(word))
                {
                    userName = userName.Remove(userName.IndexOf(word), word.Length);
                    Console.WriteLine(userName);
                }
                else
                {
                    Console.WriteLine($"The word {userName} doesn't contain {word}.");
                }
            }
            else if (command == "Check")
            {
                string word = commands[1];
                if (userName.Contains(word))
                {
                    Console.WriteLine("Valid");
                }
                else
                {
                    Console.WriteLine($"Your username must contain {word}.");
                }
            }
            else if (command == "Replace")
            {
                string replacement = commands[1];
                userName = userName.Replace(replacement, "*");
                Console.WriteLine(userName);
            }
            input = Console.ReadLine();
        }
    }
}
