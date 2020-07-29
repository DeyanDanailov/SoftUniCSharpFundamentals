using System;

namespace Lists_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string rest = input.Substring(2,2);
           
            Console.WriteLine(input); 

            Console.WriteLine(rest);
        }
    }
}
