using System;
using System.Diagnostics;
using System.Text;

namespace _07._Receive_string
{
    class Program
    {
        static string RepeatStringFast(string ToRepeat, int times)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < times; i++)
            {
                result.Append(ToRepeat);
            }
            return result.ToString();
        }

        static string MultiplyString(string input, int multiplyer)
        {

            string result = "";
            for (int i = 0; i < multiplyer; i++)
            {
                result += input;
            }
            return result;
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int multiplyer = int.Parse(Console.ReadLine());

            Stopwatch timer = Stopwatch.StartNew();
            MultiplyString(input, multiplyer);
            timer.Stop();
            Console.WriteLine(timer.ElapsedMilliseconds);
            timer = Stopwatch.StartNew();
            RepeatStringFast(input, multiplyer);
            timer.Stop();
            Console.WriteLine(timer.ElapsedMilliseconds);

            //Console.WriteLine(RepeatStringFast(input, multiplyer));
        }
    }
}
