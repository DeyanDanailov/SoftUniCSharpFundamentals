using System;

namespace Masta_Yoda
{
    class Program
    {
        static void Main(string[] args)
        {
            double Chomoney = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double priceoflightsabres = double.Parse(Console.ReadLine());
            double priceofrobes = double.Parse(Console.ReadLine());
            double priceofbelts = double.Parse(Console.ReadLine());
            
            double morelightsabres = 1.1*students;
            morelightsabres = Math.Ceiling(morelightsabres);
            var totallightsabres = morelightsabres * priceoflightsabres;
            double totalrobes = students * priceofrobes;
            int freebelts = students / 6;
            double totalbelts = (students - freebelts) * priceofbelts;
            double totalprice = totallightsabres + totalbelts + totalrobes;
            if (totalprice <= Chomoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalprice:F2}lv.");
            }
            else
            {
                double neededmoney = totalprice - Chomoney;
                Console.WriteLine($"Ivan Cho will need {neededmoney:F2}lv more.");
            }
        }

    }
}
