﻿using System;

namespace chars_to_strong
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            char thirdChar = char.Parse(Console.ReadLine());
            
            Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
        }
    }
}
