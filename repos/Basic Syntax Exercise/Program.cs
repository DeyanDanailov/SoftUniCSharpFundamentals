using System;
using System.Globalization;

namespace Basic_Syntax_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string num = Console.ReadLine();
            double.Parse("num", CultureInfo.InvariantCulture);
            Console.WriteLine(num);
        }
    }
}
