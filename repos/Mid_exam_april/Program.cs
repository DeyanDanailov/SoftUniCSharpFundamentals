using System;
using System.Collections.Generic;
using System.Linq;

namespace Mid_exam_april
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> command = Console.ReadLine().Split(new char[] {' ','-'}, StringSplitOptions.RemoveEmptyEntries).ToList();
            Console.WriteLine(String.Join('|', command));
        }
    }
}
