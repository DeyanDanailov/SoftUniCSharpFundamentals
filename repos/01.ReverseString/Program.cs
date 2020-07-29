using System;

namespace _01.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "end")
            {
                char[] str = input.ToCharArray();
                Array.Reverse(str);
                string reversed = new string(str);

                Console.WriteLine($"{input} = {reversed}");

                input = Console.ReadLine();
            }
            
        }
    }
}
