using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] allNames = Console.ReadLine().Split(", ").ToArray();
            List<string> validUsernames = new List<string>();
            for (int i = 0; i < allNames.Length; i++)
            {
                string currentName = allNames[i];
                bool isValid = true;
                if (currentName.Length >=3 && currentName.Length <=16)
                {
                    for (int j = 0; j < currentName.Length; j++)
                    {
                        if (!(char.IsLetterOrDigit(currentName[j]) || currentName[j]=='-' || currentName[j]=='_'))
                        {
                            isValid = false;
                            break;
                        }
                    }
                    if (isValid)
                    {
                        validUsernames.Add(currentName);
                    }
                }
            }
            Console.WriteLine(String.Join(Environment.NewLine, validUsernames));
        }
    }
}
