using System;

namespace _8._1.StringManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string input = Console.ReadLine();
            while(input != "Done")
            {
                string[] command = input.Split();
                string action = command[0];
                switch (action)
                {
                    case "Change":
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
                    case "End":                        
                            if (text.EndsWith(command[1]))
                            {
                                Console.WriteLine("True");
                            }
                            else
                            {
                                Console.WriteLine("False");
                            }                       
                        break;
                    case "Uppercase":
                        if (text != null)
                        {
                            text = text.ToUpper();
                            Console.WriteLine(text); ;
                        }
                        break;
                    case "FindIndex":
                        int charIndex = text.IndexOf(command[1]);
                        if (charIndex>=0)
                        {
                            Console.WriteLine(charIndex);
                        }
                        break;
                    case "Cut":
                        text = text.Substring(int.Parse(command[1]), int.Parse(command[2]));
                        Console.WriteLine(text);
                        break;
                }

                input = Console.ReadLine();
            }
        }
    }
}
