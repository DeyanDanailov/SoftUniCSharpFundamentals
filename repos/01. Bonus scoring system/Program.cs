using System;

namespace _01._Bonus_scoring_system
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());
            int countOfLectures = int.Parse(Console.ReadLine());
            int additionalBonus = int.Parse(Console.ReadLine());
            double maxBonus = 0;
            int attendOfMaxBonus = 0;
            for (int i = 0; i < countOfStudents; i++)
            {
                int attendancies = int.Parse(Console.ReadLine());
                double currentBonus =(((double)attendancies / (double)countOfLectures)*(5 + (double)additionalBonus));
                if (currentBonus>=maxBonus)
                {
                    maxBonus = currentBonus;
                    attendOfMaxBonus = attendancies;
                }
            }
            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxBonus)}.");
            Console.WriteLine($"The student has attended {attendOfMaxBonus} lectures.");
        }
    }
}
