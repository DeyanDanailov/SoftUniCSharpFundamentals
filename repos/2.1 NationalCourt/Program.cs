using System;

namespace _2._1_NationalCourt
{
    class Program
    {
        static void Main(string[] args)
        {
            int employee1Capacity = int.Parse(Console.ReadLine());
            int employee2Capacity = int.Parse(Console.ReadLine());
            int employee3Capacity = int.Parse(Console.ReadLine());
            int peopleCount = int.Parse(Console.ReadLine());
            int allCapacity = employee1Capacity + employee2Capacity + employee3Capacity;
            int hoursNeeded = 0;
            if ((peopleCount / allCapacity) >= 3)
            {
                if ((peopleCount / allCapacity) % 3 == 0)
                {
                    if (peopleCount % allCapacity > 0)
                    {
                        hoursNeeded = peopleCount / allCapacity + 1;
                        hoursNeeded += hoursNeeded / 3;
                    }
                    else if (peopleCount % allCapacity == 0)
                    {
                        hoursNeeded = peopleCount / allCapacity;
                        hoursNeeded += hoursNeeded / 3 - 1;
                    }
                }
                else
                {
                    if ((peopleCount % allCapacity) > 0)
                    {
                        hoursNeeded = peopleCount / allCapacity + 1;
                        hoursNeeded += hoursNeeded / 3;
                    }
                    else if (peopleCount % allCapacity == 0)
                    {
                        hoursNeeded = peopleCount / allCapacity;
                        hoursNeeded += hoursNeeded / 3;
                    }
                }
            }
            else if (peopleCount / allCapacity < 3 && peopleCount / allCapacity>0)
            {
                if (peopleCount % allCapacity > 0)
                {
                    hoursNeeded = peopleCount / allCapacity + 1;
                }
                else if (peopleCount % allCapacity == 0)
                {
                    hoursNeeded = peopleCount / allCapacity;
                }

            }

                Console.WriteLine($"Time needed: {hoursNeeded}h.");
        }
    }
}
