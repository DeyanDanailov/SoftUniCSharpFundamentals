using System;

namespace _08._Beer_kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfKegs = int.Parse(Console.ReadLine());
            string biggestKeg = String.Empty;
            float biggestVolume = 0;
            for (int i = 0; i < numberOfKegs; i++)
            {
                string kegName = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                float volume = (float)(Math.PI * radius * radius * height);
                
                if (volume>=biggestVolume)
                {
                    biggestVolume = volume;
                    biggestKeg = kegName;
                }
            }
            Console.WriteLine(biggestKeg);
        }
    }
}
