using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes += 30;
            if (minutes > 59)
            {
                minutes = minutes - 60;
                hour += 1;
            }
            if (hour==24)
            {
                hour = 0;
            }
           Console.WriteLine($"{hour}:{minutes:D2}");
        }
    }
}
