using System;

namespace _07._Water_overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            byte numberOfLines = byte.Parse(Console.ReadLine());
            ushort sum = 0;
            for (int i = 0; i < numberOfLines; i++)
            {
                ushort litres = ushort.Parse(Console.ReadLine());
                
                if ((sum+ litres)>255)
                {
                    Console.WriteLine("Insufficient capacity!");
                } else
                sum += litres;
            }
            Console.WriteLine(sum);

        }
    }
}
