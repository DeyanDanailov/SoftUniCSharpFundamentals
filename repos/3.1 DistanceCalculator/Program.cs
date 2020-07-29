using System;

namespace _3._1_DistanceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int stepsmade = int.Parse(Console.ReadLine());
            double singleStepLength = double.Parse(Console.ReadLine());
            double fifthStepLength = 0.7 * singleStepLength;
            double distanceToTravel = double.Parse(Console.ReadLine())*100;
            double travelledDistance = 0.0;
            if (stepsmade<5)
            {
                travelledDistance = stepsmade * singleStepLength;
            }
            else if (stepsmade>=5)
            {
                travelledDistance = (stepsmade / 5) * fifthStepLength + (stepsmade - (stepsmade / 5)) * singleStepLength;
            }
            double percentage = (travelledDistance / distanceToTravel)*100;
            Console.WriteLine($"You travelled {percentage:f2}% of the distance!");
        }
    }
}
