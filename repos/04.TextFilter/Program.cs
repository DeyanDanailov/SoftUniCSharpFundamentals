using System;

namespace _04.TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedWords = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();
            for (int i = 0; i < bannedWords.Length; i++)
            {
                //string newWord = String.Empty;
                //for (int j = 0; j < bannedWords[i].Length; j++)
                //{
                //    newWord += "*";
                //}
                text = text.Replace(bannedWords[i], new string ('*', bannedWords[i].Length));
            }
            Console.WriteLine(text);
        }
    }
}
