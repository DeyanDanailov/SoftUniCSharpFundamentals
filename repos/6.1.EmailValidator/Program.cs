using System;
using System.Collections.Generic;

namespace _6._1.EmailValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();
            string input = Console.ReadLine();
            while (input != "Complete")
            {
                string[] command = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (command[0] == "Make")
                {
                    if (command[1] == "Upper")
                    {
                        email = email.ToUpper();
                        Console.WriteLine(email);
                    }
                    else if (command[1] == "Lower")
                    {
                        email = email.ToLower();
                        Console.WriteLine(email);
                    }
                }
                else if (command[0] == "GetDomain")
                {
                    int count = int.Parse(command[1]);
                    int index = email.Length - count;
                    string domain = email.Substring(index);
                    Console.WriteLine(domain);
                }
                else if (command[0] == "GetUsername")
                {
                    int index = email.IndexOf('@');
                    if (index == -1)
                    {
                        Console.WriteLine($"The email {email} doesn't contain the @ symbol.");
                    } else
                    Console.WriteLine(email.Substring(0, index));
                }
                else if (command[0] == "Replace")
                {
                    char toReplace = char.Parse(command[1]);
                    email = email.Replace(toReplace, '-');
                    Console.WriteLine(email);
                }
                else if (command[0] == "Encrypt")
                {
                    List<int> result = new List<int>();
                    foreach (var item in email)
                    {
                        result.Add((int)item);
                    }
                    Console.WriteLine(String.Join(' ',result));
                }

                input = Console.ReadLine();
            }
        }
    }
}
