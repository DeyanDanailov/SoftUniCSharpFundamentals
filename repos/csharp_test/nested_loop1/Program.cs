using System;

namespace nested_loop1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double studenttickets = 0.0;
            double kidtickets = 0.0;
            double standardtickets = 0.0;
            double totaltickets = 0.0;
            double allstudenttickets = 0.0;
            double allkidstickets = 0.0;
            double allstandardtickets = 0.0;
            string movie = Console.ReadLine();
            while (movie != "Finish")
            {
                double freeseats = double.Parse(Console.ReadLine());
                string ticket = Console.ReadLine();
                while (ticket != "End")
                {
                    if (ticket == "student")
                    {
                        studenttickets++;
                    } else if (ticket == "kid")
                    {
                        kidtickets++;
                    } else if (ticket == "standard")
                    {
                        standardtickets++;
                    } if ((studenttickets + kidtickets + standardtickets) == freeseats)
                        break;
                     ticket = Console.ReadLine();
                }
               
                totaltickets += (studenttickets + kidtickets + standardtickets);
                allkidstickets += kidtickets;  
                allstandardtickets += standardtickets;            
                allstudenttickets += studenttickets;             
                double percent = (studenttickets + kidtickets + standardtickets) / freeseats * 100;
                Console.Write($"{movie} - { percent:f2} % full.\n");
                studenttickets = 0.0;
                standardtickets = 0.0;
                kidtickets = 0.0;
                movie = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {totaltickets}");
            Console.WriteLine($"{((allstudenttickets/totaltickets)*100):f2} % student tickets.");
            Console.WriteLine($"{((allstandardtickets / totaltickets) * 100):f2} % standard tickets.");
            Console.WriteLine($"{((allkidstickets / totaltickets) * 100):f2} % kid tickets.");
        }
    }
}
