using System;

namespace _08._Factorial_Division
{
    class Program
    {
        static ulong FactorialOf(ulong num)
        {
            ulong factorial = 1;
            for (ulong i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
        static void Main(string[] args)
        {
            ulong num1 = ulong.Parse(Console.ReadLine());
            ulong num2 = ulong.Parse(Console.ReadLine());
            double result = (double)(FactorialOf(num1)) / (double)(FactorialOf(num2));
            Console.WriteLine($"{result:f2}");
        }
    }
}
