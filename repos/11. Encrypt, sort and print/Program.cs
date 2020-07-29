using System;

namespace _11._Encrypt__sort_and_print
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int[] nameCodes = new int[num];
            for (int i = 0; i < num; i++)
            {
                string name = Console.ReadLine();
                char[] chars = name.ToCharArray();
                int charCode = 0;
                int nameCode = 0;
                switch (chars[0])
                {
                    case 'A':
                    case 'E':
                    case 'I':
                    case 'O':
                    case 'U':
                        charCode = ((int)chars[0]) * chars.Length;
                        break;
                    case 'B':
                    case 'C':
                    case 'D':
                    case 'F':
                    case 'G':
                    case 'H':
                    case 'J':
                    case 'K':
                    case 'L':
                    case 'M':
                    case 'N':
                    case 'P':
                    case 'Q':
                    case 'R':
                    case 'S':
                    case 'T':
                    case 'V':
                    case 'W':
                    case 'X':
                    case 'Y':
                    case 'Z':
                        charCode = ((int)chars[0]) / chars.Length;
                        break;
                    default:
                        break;
                }
                nameCode += charCode;
                        for (int j = 1; j < chars.Length; j++)
                {
                    switch (chars[j])
                    {
                        case 'a':
                        case 'e':
                        case 'i':
                        case 'o':
                        case 'u':
                            charCode = ((int)chars[j])*chars.Length;
                            break;
                        case 'b':
                        case 'c':
                        case 'd':
                        case 'f':
                        case 'g':
                        case 'h':
                        case 'j':
                        case 'k':
                        case 'l':
                        case 'm':
                        case 'n':
                        case 'p':
                        case 'q':
                        case 'r':
                        case 's':
                        case 't':
                        case 'v':
                        case 'w':
                        case 'x':
                        case 'y':
                        case 'z':
                            charCode = ((int)chars[j]) / chars.Length;
                            break;
                        default:
                            break;
                    }
                    nameCode += charCode;
                }

                nameCodes[i] = nameCode;
            }
            Array.Sort(nameCodes);
            for (int k = 0; k < nameCodes.Length; k++)
            {
                Console.WriteLine(nameCodes[k]);
            }
        }
    }
}
