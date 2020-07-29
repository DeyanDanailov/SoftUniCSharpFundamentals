using System;

namespace _06._Rectangle_area
{
    class Program
    {
        static int Area(int width, int height)
        {
            int area = width * height;
            return area;
        }
        static void Main(string[] args)
        {
            int widthInput = int.Parse(Console.ReadLine());
            int heightInput = int.Parse(Console.ReadLine());
            
            Console.WriteLine(Area(widthInput, heightInput));
        }
    }
}
