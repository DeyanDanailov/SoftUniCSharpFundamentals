using System;

namespace _4._1_GiftboxCoverage
{
    class Program
    {
        static void Main(string[] args)
        {
            double sizeOfASide = double.Parse(Console.ReadLine());
            double giftBoxArea = Math.Pow(sizeOfASide, 2) * 6;
            int numberOfSheets = int.Parse(Console.ReadLine());
            double areaOfASingleSheet = double.Parse(Console.ReadLine());
            double thirdSheetArea = 0.25 * areaOfASingleSheet;           
            double coveredArea = 0.0;
            if (numberOfSheets < 3)
            {
                coveredArea = numberOfSheets * areaOfASingleSheet;
            }
            else if (numberOfSheets >= 3)
            {
                coveredArea = (numberOfSheets / 3) * thirdSheetArea + (numberOfSheets - (numberOfSheets / 3)) * areaOfASingleSheet;
            }
            double percentage = (coveredArea / giftBoxArea) * 100;
            Console.WriteLine($"You can cover {percentage:f2}% of the box.");
        }
    }
}
