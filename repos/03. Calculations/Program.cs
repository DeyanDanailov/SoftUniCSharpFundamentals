using System;

namespace _03._Calculations
{
    class Program
    {
        static void Add(int first, int second)
        {
            Console.WriteLine(first + second);
        }
        static void Subtract(int first, int second)
        {
            Console.WriteLine(first-second);
        }
        static void Multiply(int first, int second)
        {
            Console.WriteLine(first*second);
        }
        static void Divide(int first, int second)
        {
            Console.WriteLine(first/second);
        }
        static void Main(string[] args)
        {
            string operation = Console.ReadLine();
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            if (operation=="add")
            {
                Add(firstNum, secondNum);
            } else if (operation == "subtract")
            {
                Subtract(firstNum, secondNum);
            } else if (operation == "multiply")
            {
                Multiply(firstNum, secondNum);
            } else if (operation == "divide")
            {
                Divide(firstNum, secondNum);
            }
        }
    }
}
