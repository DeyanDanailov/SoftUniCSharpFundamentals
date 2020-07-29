using System;

namespace upper_or_lower
{
    class Program
    {
        static void Main(string[] args)
        {
            char ch = char.Parse(Console.ReadLine());
            bool IsUpper = true;
            IsUpper = Char.IsUpper(ch);
            if (IsUpper)
            {
                Console.WriteLine("upper-case");
            } else
            Console.WriteLine("lower-case");
        }
    }
}
