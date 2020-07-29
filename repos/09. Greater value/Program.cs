using System;

namespace _09._Greater_value
{
    class Program
    {
        //static string GetMax(string type, string first, string second)
        //{
        //    string result = "";
        //    if (type == "int")
        //    {
        //        if (int.Parse(first) > int.Parse(second))
        //        {
        //            result = first;
        //        }
        //        else
        //            result = second;
        //    }
        //    else if (type == "char")
        //    {
        //        if ((int)(char.Parse(first)) > (int)(char.Parse(second)))
        //        {
        //            result = first;
        //        }
        //        else
        //            result = second;

        //    }

        //    return result;
        //}

        static int GetMax(int first, int second)
        {
            int result = first.CompareTo(second);
            if (result > 0)
            {
                return first;
            }
            else return second;
        }
        static char GetMax(char first, char second)
        {
            int result = first.CompareTo(second);
            if (result > 0)
            {
                return first;
            }
            else return second;
        }
        static string GetMax(string first, string second)
        {
            int result = first.CompareTo(second);
            if (result > 0)
            {
                return first;
            }
            else return second;
        }
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            if (type == "int")
            {
                int first = int.Parse(Console.ReadLine());
                int second = int.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(first, second));
            }
            else if (type == "char")
            {
                char first = char.Parse(Console.ReadLine());
                char second = char.Parse(Console.ReadLine());
                Console.WriteLine(GetMax(first, second));

            }
            else if (type == "string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                Console.WriteLine(GetMax(first, second));

            }



        }
    }
}
