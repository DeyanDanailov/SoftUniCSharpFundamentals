using System;

namespace test_Exam
{
    class Program
    {
        static void Main(string[] args)
        {

            int days = int.Parse(Console.ReadLine());
            double money = 0.0;
            double allmoney = 0.0;
            int wins = 0;
            int losses = 0;
            int windays = 0;
            int lossdays = 0;
            for (int i = 1; i <= days; i++)
            {
                string game = Console.ReadLine();
                while (game != "Finish")
                {
                    string result = Console.ReadLine();
                    if (result == "win")
                    {
                        money += 20;
                        wins++;
                    }
                    else if (result == "lose")
                    {
                        losses++;
                    }
                    game = Console.ReadLine();
                }
                if (wins > losses)
                {
                    money = 1.1*money;
                    windays++;
                }
                else
                    lossdays++;

                allmoney += money;
                wins = 0;
                losses = 0;
                money = 0.0;
            }
            if (windays > lossdays)
            {

                allmoney = 1.2 * allmoney;
                Console.WriteLine($"You won the tournament! Total raised money : {allmoney:f2}");
            } else

             Console.WriteLine($"You lost the tournament! Total raised money : {allmoney:f2}");
            

            }
        }
    }
