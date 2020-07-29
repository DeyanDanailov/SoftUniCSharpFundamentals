using System;

namespace Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = int.Parse(Console.ReadLine());
            var number2 = int.Parse(Console.ReadLine());
            if (number2 > 10)
            {
                Console.WriteLine($"{number1} X {number2} = {number1 * number2}");
            }
            for (int i = number2; i <= 10; i++)
            {
               
                Console.WriteLine($"{number1} X {i} = {number1*i}");
            }
        }
    }
}
