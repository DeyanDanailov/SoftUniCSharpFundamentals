using System;

namespace _09._Spice_must_flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int totalAmount = 0;
            int daysCounter = 0;
            while (yield>=100)
            {
                totalAmount += yield;
                totalAmount -= 26;
                if (totalAmount<0)
                {
                    totalAmount = 0;
                }
                yield -= 10;
                daysCounter++;
            }
            totalAmount -= 26;
            if (totalAmount < 0)
            {
                totalAmount = 0;
            }
            Console.WriteLine(daysCounter);
            Console.WriteLine(totalAmount);
        }
    }
}
