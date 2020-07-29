using System;
using System.Linq;

namespace _09._Kamino
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int[] dna = input.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int index = 0;
            int maxSequence = 0;
            int bestSample = 0;
            int bestIndex = 0;
            int[] bestDna = new int[length];
            int bestSampleCounter = 0;
            while (input != "Clone them!")
            {
                bestSampleCounter++;
                dna = input.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int counter = 0;
                for (int i = 0; i < dna.Length; i++)
                {
                    index = i;
                    if (dna[i] == 1)
                    {
                        counter++;
                        if (counter > maxSequence)
                        {
                            maxSequence = counter;
                            bestDna = dna.ToArray();
                            bestSample = bestSampleCounter;
                            bestIndex = index;

                        }
                        else if (counter == maxSequence)
                        {
                            if (index < bestIndex)
                            {
                                bestDna = dna.ToArray();
                                bestSample = bestSampleCounter;
                                bestIndex = index;
                            }
                            else if (index == bestIndex)
                            {
                                if (dna.Sum() > bestDna.Sum())
                                {
                                    bestDna = dna.ToArray();
                                    bestSample = bestSampleCounter;
                                }
                            }
                        }
                    }
                    else if (dna[i] == 0)
                    {
                        counter = 0;
                        index = i;
                    }

                }

                
                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestDna.Sum()}.");
            Console.WriteLine(String.Join(" ", bestDna));

        }
    }
}
