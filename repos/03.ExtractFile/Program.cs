using System;

namespace _03.ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] path = Console.ReadLine().Split(new char[] { '.', '\\' });//kak da splitna po '\'
          
            string name = path[path.Length - 2];
            string extension = path[path.Length - 1];
            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
