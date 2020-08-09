using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._1.Concert
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Band> allBands = new Dictionary<string, Band>();
            string input = Console.ReadLine();
            int totalTime = 0;
            while (input != "start of concert")
            {
                string[] command = input.Split(new string[] { "; ", ", " }, StringSplitOptions.RemoveEmptyEntries);

                if (command[0] == "Add")
                {
                    string bandName = command[1];
                    Add(allBands, bandName, command);
                }
                else if (command[0] == "Play")
                {
                    string bandName = command[1];
                    int time = int.Parse(command[2]);
                    totalTime += time;
                    Play(allBands, bandName, time);
                }
                input = Console.ReadLine();
            }
            string bandToPrint = Console.ReadLine();
            allBands = allBands.OrderByDescending(x => x.Value.Time).ThenBy(y => y.Key).ToDictionary(a => a.Key, b => b.Value);
            Console.WriteLine($"Total time: {totalTime}");
            foreach (var item in allBands)
            {
                Console.WriteLine($"{item.Key} -> {item.Value.Time}");
            }
            Console.WriteLine(bandToPrint);
            foreach (var musician in allBands[bandToPrint].Members)
            {
                Console.WriteLine($"=> {musician}");
            }
        }
        public static void Add(Dictionary<string, Band> allBands, string bandName, string[] command)
        {
            if (!allBands.ContainsKey(bandName))
            {
                allBands.Add(bandName, new Band());
                allBands[bandName].Members = new List<string>();
            }
            for (int i = 2; i < command.Length; i++)
            {
                string musician = command[i];
                if (!allBands[bandName].Members.Contains(musician))
                {
                    allBands[bandName].Members.Add(musician);
                }
            }
        }
        public static void Play(Dictionary<string, Band> allBands, string bandName, int time)
        {
            if (!allBands.ContainsKey(bandName))
            {
                allBands.Add(bandName, new Band());
                allBands[bandName].Members = new List<string>();
            }
            allBands[bandName].Time += time;


        }
    }
    public class Band
    {
        public List<string> Members { get; set; }
        public int Time { get; set; }
    }
}
