using System;

namespace simple_calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            float income = float.Parse(Console.ReadLine());
            float grade = float.Parse(Console.ReadLine());
            float minsalary = float.Parse(Console.ReadLine());
            float socialscholarship = 0;
            float gradescholarship = 0;
            if (income < minsalary)
            {
                if (grade > 4.5)
                {
                    socialscholarship = 0.35 * minsalary;
                }
            }
            if (grade > 5.5)
            {
                gradescholarship = 25 * grade;
            }
            if ((socialscholarship == 0) && (gradescholarship == 0))
            {
                Console.WriteLine($"You cannot get a scholarship");
            }
        }
        
    }
}
