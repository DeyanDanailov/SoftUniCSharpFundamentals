using System;

namespace _5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int employee1Capacity = int.Parse(Console.ReadLine());
            int employee2Capacity = int.Parse(Console.ReadLine());
            int employee3Capacity = int.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            int allCapacity = employee1Capacity + employee2Capacity + employee3Capacity;
            int hoursNeeded = 0;
            if ((studentsCount / allCapacity) >= 3)
            {
                if ((studentsCount / allCapacity) % 3 == 0)
                {
                    if (studentsCount % allCapacity > 0)
                    {
                        hoursNeeded = studentsCount / allCapacity + 1;
                        hoursNeeded += hoursNeeded / 3;
                    }
                    else if (studentsCount % allCapacity == 0)
                    {
                        hoursNeeded = studentsCount / allCapacity;
                        hoursNeeded += hoursNeeded / 3 - 1;
                    }
                }
                else
                {
                    if ((studentsCount % allCapacity) > 0)
                    {
                        hoursNeeded = studentsCount / allCapacity + 1;
                        hoursNeeded += hoursNeeded / 3;
                    }
                    else if (studentsCount % allCapacity == 0)
                    {
                        hoursNeeded = studentsCount / allCapacity;
                        hoursNeeded += hoursNeeded / 3;
                    }
                }
            }
            else if (studentsCount / allCapacity < 3 && studentsCount / allCapacity > 0)
            {
                if (studentsCount % allCapacity > 0)
                {
                    hoursNeeded = studentsCount / allCapacity + 1;
                }
                else if (studentsCount % allCapacity == 0)
                {
                    hoursNeeded = studentsCount / allCapacity;
                }

            }

            Console.WriteLine($"Time needed: {hoursNeeded}h.");

        }
    }
}
