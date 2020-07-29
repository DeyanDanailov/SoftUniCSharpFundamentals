using System;

namespace _11._Pascal_triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfRows = int.Parse(Console.ReadLine());
            int[] row = new int[1];
            row[0] = 1;
            Console.WriteLine(String.Join(" ", row));
            for (int i = 1; i <= numOfRows-1; i++)
            {
                int[] nextRow = new int[i + 1];
                
                for (int j = 1; j <= nextRow.Length; j++)
                {
                   
                    row[0] = 1;
                    if (j>row.Length)
                    {
                        row[j] = 0;
                    }
                    nextRow[j] = 1 ;
                    row[row.Length - 1] = 1;
                    row = nextRow;




                }

                Console.WriteLine(String.Join(" ", row));
            }
        }
    }
}
