using System;

namespace _03.Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string textToRemove = Console.ReadLine().ToLower();
            string text = Console.ReadLine();           
            int index = text.IndexOf(textToRemove);
            while (index != -1)
            {
                text = text.Remove(index, textToRemove.Length);
                index = text.IndexOf(textToRemove);
            }
            Console.WriteLine(text);
        }
    }
}
