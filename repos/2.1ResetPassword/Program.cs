using System;
using System.Linq;

namespace _2._1ResetPassword
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string command = Console.ReadLine();
            while (command != "Done")
            {
                string[] commandDetails = command.Split().ToArray();
                if (commandDetails[0] == "TakeOdd")
                {
                    password = TakeOdd(password);
                }
                else if (commandDetails[0] == "Cut")
                {
                    int index = int.Parse(commandDetails[1]);
                    int length = int.Parse(commandDetails[2]);
                    password = Cut(password, index, length);
                }
                else if (commandDetails[0] == "Substitute")
                {
                    string substring = commandDetails[1];
                    string substitute = commandDetails[2];
                    password = Substitute(password, substring, substitute);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Your password is: {password}");
        }
        static string TakeOdd(string password)
        {
            string newPassword = String.Empty;
            for (int i = 0; i < password.Length; i++)
            {
                if (i % 2 == 1)
                {
                    newPassword += password[i];
                }
            }
            Console.WriteLine(newPassword);
            return newPassword;
        }
        static string Cut(string password, int index, int length)
        {
            password = password.Remove(index, length);
            Console.WriteLine(password);
            return password;
        }
        static string Substitute(string password, string substring, string substitute)
        {
            if (password.Contains(substring))
            {
                password = password.Replace(substring, substitute);
                Console.WriteLine(password);
            }
            else
            {
                Console.WriteLine("Nothing to replace!");
            }
            return password;
        }
    }
}
