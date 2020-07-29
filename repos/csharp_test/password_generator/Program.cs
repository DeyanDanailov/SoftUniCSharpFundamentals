using System;

namespace password_generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            for (int first = 1; first <=n; first++)
            {
                for (int second = 1; second<=n; second++)
                {
                    for (int third = 97;third < 97+l; third++)
                    {
                        char a = Convert.ToChar(third);
                        for (int fourth = 97; fourth < 97+l; fourth++)
                        {
                            char b = Convert.ToChar(fourth);
                            for (int fifth = 1; fifth <=n; fifth++)
                            {
                                if(fifth>first && fifth > second)
                                {
                                    Console.Write($"{first}{second}{a}{b}{fifth} ");
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
