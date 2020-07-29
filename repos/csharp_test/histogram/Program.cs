using System;

namespace histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double p1 = 0; double p2 = 0; double p3 = 0; double p4 = 0; double p5 = 0;
            for (int i =0; i<n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num < 200)
                    p1+=1;
                else if (num >= 200 && num < 400)
                    p2+=1;
                else if (num >= 400 && num < 600)
                    p3+=1;
                else if (num >= 600 && num < 800)
                    p4+=1;
                else 
                    p5+=1;
            }
            double p1cent = (p1 / n) * 100.00;
            double p2cent = (p2 / n) * 100.00;
            double p3cent = (p3 / n) * 100.00;
            double p4cent = (p4 / n) * 100.00;
            double p5cent = (p5 / n) * 100.00;

            Console.WriteLine($"{p1cent:f2} %");
            Console.WriteLine($"{p2cent:f2} %");
            Console.WriteLine($"{p3cent:f2} %");
            Console.WriteLine($"{p4cent:f2} %");
            Console.WriteLine($"{p5cent:f2} %");
        }
    }
}
