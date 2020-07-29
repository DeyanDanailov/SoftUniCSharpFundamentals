using System;

namespace _06.ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string result = String.Empty;
            for (int i = 0 ; i < text.Length-1; i++)
            {               
                if (text[i]!=text[i+1])
                {
                    result += text[i];
                }
            }
            result += text[text.Length - 1];
            Console.WriteLine(result);
        }
    }
}
