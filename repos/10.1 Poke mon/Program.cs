using System;

namespace _10._1_Poke_mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            byte exhaustionFactor = byte.Parse(Console.ReadLine());
            int pokePowerleft = pokePower;
            int targets = 0;
           
            while (pokePowerleft>=distance)
            {
               
                
                if (2*pokePowerleft==pokePower && exhaustionFactor>0)
                {
                   
                        pokePowerleft /= exhaustionFactor;
                    if (pokePowerleft<distance)
                    {
                        break;
                    }
                     
                    
                 
                }
                pokePowerleft -= distance;
                targets++;
            }
            Console.WriteLine(pokePowerleft);
            Console.WriteLine(targets);
        }
    }
}
