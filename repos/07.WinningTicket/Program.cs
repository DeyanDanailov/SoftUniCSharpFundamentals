using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _07.WinningTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] alltickets = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            foreach (var currentTicket in alltickets)
            {
                if (currentTicket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                }
                else
                {
                    string leftHalf = currentTicket.Substring(0, 10);
                    string rightHalf = currentTicket.Substring(10, 10);
                    Regex match = new Regex(@"(\@{6,}|\${6,}|\^{6,}|\#{6,})");
                    Regex jackpot = new Regex(@"(\@{10}|\${10}|\^{10}|\#{10})");
                    if (jackpot.IsMatch(leftHalf) && jackpot.IsMatch(rightHalf) && leftHalf[5]==rightHalf[5])
                    {
                        Console.WriteLine($"ticket \"{currentTicket}\" - {10}{leftHalf[5]} Jackpot!");
                    }
                    else if (match.IsMatch(leftHalf) && (match.IsMatch(rightHalf) && leftHalf[5] == rightHalf[5]))
                    {
                        Match symbolsLeft = match.Match(leftHalf);
                        Match symbolsRight = match.Match(rightHalf);
                        int matchLength = Math.Min(symbolsLeft.Length, symbolsRight.Length);
                        Console.WriteLine($"ticket \"{currentTicket}\" - {matchLength}{leftHalf[5]}");
                    }
                    else
                    {
                        Console.WriteLine($"ticket \"{currentTicket}\" - no match");
                    }
                }
            }
        }
    }
}
