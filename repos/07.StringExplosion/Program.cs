using System;
using System.Text;

namespace _07.StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            for (int j = 0; j < input.Length; j++)
            {
                int i = j;
                char currentSymbol = input[i];
                if (currentSymbol == '>')
                {
                    result.Append('>');
                    int bombRange = Convert.ToInt32(new string(input[i + 1], 1));
                label:
                    for (int k = i + 2; k < i + 2 + bombRange; k++)
                    {
                        if (input[k] == '>')
                        {
                            result.Append('>');
                            bombRange = Convert.ToInt32(new string(input[k + 1], 1));
                            i = k;
                            goto label;
                        }
                    }
                    i = bombRange + 1;
                }
                else
                {
                    result.Append(input[i]);
                }
            }
            Console.WriteLine(result);

        }
    }
}
