using System;

namespace _09.ExtractPersonInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfLines; i++)
            {
                string input = Console.ReadLine();
                Console.WriteLine($"{FindName(input)} is {FindAge(input)} years old.");
            }
        }
        static string FindName(string input)
        {
            int startNameIndex = input.IndexOf('@');
            int endNameIndex = input.IndexOf('|');
            int nameLength = endNameIndex - startNameIndex - 1;
            string name = input.Substring(startNameIndex + 1, nameLength);
            return name;
        }
        static string FindAge(string input)
        {
            int startAgeIndex = input.IndexOf('#');
            int endAgeIndex = input.IndexOf('*');
            int ageLength = endAgeIndex - startAgeIndex - 1;
            string age = input.Substring(startAgeIndex + 1, ageLength);
            return age;
        }
    }
}
