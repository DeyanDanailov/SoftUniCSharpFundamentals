using System;

namespace _05._Add_and_subtract
{
    class Program
    {
        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            Console.WriteLine(Subtract(Add(firstNum, secondNum), thirdNum));

        }
    }
}
