using System;
using System.Numerics;

namespace _10._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = byte.Parse(Console.ReadLine());
            BigInteger bestSnowballValue = int.MinValue;
            short bestSnowballSnow = 0;
            short bestSnowballTime = 0;
            byte bestSnowballQuality = 0;
            for (int i = 0; i < number; i++)
            {
                short snowballSnow = short.Parse(Console.ReadLine());
                short snowballTime = short.Parse(Console.ReadLine());
                byte snowballQuality = byte.Parse(Console.ReadLine());
                BigInteger snowballValue = BigInteger.Pow((snowballSnow /snowballTime), (snowballQuality));
                if (snowballValue > bestSnowballValue)
                {
                    bestSnowballValue = snowballValue;
                    bestSnowballSnow = snowballSnow;
                    bestSnowballTime = snowballTime;
                    bestSnowballQuality = snowballQuality;
                }
            }
            Console.WriteLine($"{bestSnowballSnow} : {bestSnowballTime} = {bestSnowballValue} ({bestSnowballQuality})");
        }

    }
}
