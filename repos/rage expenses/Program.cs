using System;

namespace rage_expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostgames = int.Parse(Console.ReadLine());
            double headsetprice = double.Parse(Console.ReadLine());
            double mouseprice = double.Parse(Console.ReadLine());
            double keyboardprice = double.Parse(Console.ReadLine());
            double displayprice = double.Parse(Console.ReadLine());
            int brokenheadset = lostgames / 2;
            int brokenmouse = lostgames / 3;
            int brokenkeyboard = lostgames / 6;
            int brokendisplay = lostgames / 12;
            double total = headsetprice * brokenheadset + mouseprice * brokenmouse + keyboardprice * brokenkeyboard + displayprice * brokendisplay;
            Console.WriteLine($"Rage expenses: {total:F2} lv.");
        }
    }
}
