using System;
using System.Linq;

namespace _10._Ladybugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[] initialIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] field = new int[fieldSize];
            for (int i = 0; i < initialIndexes.Length; i++)
            {
                int currentIndex = initialIndexes[i];

                if (currentIndex < field.Length && currentIndex >= 0)
                {
                    field[initialIndexes[i]] = 1;
                }

            }
            string command = String.Empty;


            while ((command = Console.ReadLine()) != "end")
            {
                string[] elements = command.Split();
                int ladybugIndex = Int32.Parse(elements[0]);
                string direction = elements[1];
                int flylength = Int32.Parse(elements[2]);

                if (ladybugIndex < 0 || ladybugIndex > field.Length - 1 || field[ladybugIndex] == 0)
                {
                    continue;
                }

                field[ladybugIndex] = 0; //ladybug flies away from start index
                if (direction=="right")
                {
                    int landIndex = ladybugIndex + flylength;
                    if (landIndex>field.Length-1)
                    {
                        continue;
                    }
                    if (field[landIndex]==1)
                    {
                        while (field[landIndex] == 1)
                        {
                            landIndex+=flylength;
                            if (landIndex>field.Length-1)
                            {
                                break;
                            }
                        }
                        
                    }
                    if (landIndex >= 0 && landIndex < field.Length)
                    {
                        field[landIndex] = 1;
                    }
                }
                else if (direction=="left")
                {
                    int landIndex = ladybugIndex - flylength;
                    if (landIndex<0)
                    {
                        continue;
                    }
                    if (field[landIndex] == 1)
                    {
                        while (field[landIndex] == 1)
                        {
                            landIndex-=flylength;
                            if (landIndex<0)
                            {
                                break;
                            }
                        }
                        
                    }
                    if (landIndex>=0 && landIndex<field.Length)
                    {
                        field[landIndex] = 1;
                    }
                    
                }
                


               
            }
            Console.WriteLine(String.Join(" ", field));
        }
    }
}
