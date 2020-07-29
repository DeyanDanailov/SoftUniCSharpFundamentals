using System;

namespace sort_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int max = 0;
            int next = 0;
            int min = 0;
            if (a <= b)
            {
                if (a<=c)
                {
                    min = a;
                    if (b<=c)
                    {
                        max = c;
                        next = b;
                    } else if (b >= c)
                    {
                        max = b;
                        next = c;
                    }
                } else if (a >= c)
                {
                    min = c;
                    next = a;
                    max = b;
                }
            } else if (a >= b)
            {
                if (b<=c)
                {
                    min = b;
                    if (a>=c)
                    {
                        max = a;
                        next = c;
                    } else if(a<=c)
                    {
                        max = c;
                        next = a;
                    }
                }
                else if (b>=c)
                {
                    max = a;
                    next = b;
                    min = c;
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(next);
            Console.WriteLine(min);
        }
    }
}
