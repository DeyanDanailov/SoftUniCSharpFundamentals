using System;

namespace _11._Data_type_finder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "END")
            {
               
                bool checkInteger = Int32.TryParse(input, out _);
                bool checkFloat = double.TryParse(input, out _);
                bool checkChar = char.TryParse(input, out _);
                bool checkBool = bool.TryParse(input, out _);
                if (checkInteger)
                {
                    Console.WriteLine($"{input} is integer type");
                } else if (checkFloat)
                {
                    Console.WriteLine($"{input} is floating point type");
                } else if (checkChar)
                {
                    Console.WriteLine($"{input} is character type");
                } else if (checkBool)
                {
                    Console.WriteLine($"{input} is boolean type");
                } else
                    Console.WriteLine($"{input} is string type");
                input = Console.ReadLine();

            }
        }
    }
}
