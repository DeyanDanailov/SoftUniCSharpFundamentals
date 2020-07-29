using System;

namespace metres
{
    class Program
    {
        static void Main(string[] args)
        {
            float meters = float.Parse(Console.ReadLine());
            float km = meters* 0.001f;
            Console.WriteLine($"{km:F2}");
        }
    }
}
