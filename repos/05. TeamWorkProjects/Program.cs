using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        List<Team> teams = new List<Team>();

        int numOfTeams = int.Parse(Console.ReadLine());



        for (int i = 0; i < numOfTeams; i++)
        {
            var info = Console.ReadLine().Split("-").ToArray();
            string creator = info[0];
            string teamName = info[1];
            // Create a team

            if (teams.Any(x => x.Name == teamName))
            {
                Console.WriteLine($"Team {teamName} was already created!");
                continue;
            }
            if (teams.Any(x => x.Creator == creator))
            {
                Console.WriteLine($"{creator} cannot create another team!");
                continue;
            }

            Team team = new Team(teamName, creator);
            teams.Add(team);
            Console.WriteLine($"Team {teamName} has been created by {creator}!");
        }

        string command = String.Empty;
        while ((command = Console.ReadLine()) != "end of assignment")
        {
            var info = command.Split("->").ToArray();
            string person = info[0];
            string teamName = info[1];

            if (!teams.Any(x => x.Name == teamName))
            {
                Console.WriteLine($"Team {teamName} does not exist!");
                continue;
            }
            if (teams.Any(x => x.peopleJoined.Contains(person)) || teams.Any(x => x.Creator == person && x.Name == teamName))
            {
                Console.WriteLine($"Member {person} cannot join team {teamName}!");
                continue;
            }

            int index = teams.FindIndex(x => x.Name == teamName);
            teams[index].peopleJoined.Add(person);
        }

        var teamsToBeDisbanded = teams
            .FindAll(x => x.peopleJoined.Count == 0)
            .OrderBy(x => x.Name)
            .ToList();

        foreach (var team in teams.Where(x => x.peopleJoined.Count > 0)
            .OrderByDescending(x => x.peopleJoined.Count)
            .ThenBy(x => x.Name))
        {
            Console.WriteLine(team.ToString());
        }

        Console.WriteLine("Teams to disband:");
        foreach (var team in teamsToBeDisbanded)
        {
            Console.WriteLine(team.Name);
        }

    }

    public class Team
    {
        public string Name { get; set; }
        public string Creator { get; set; }

        public List<string> peopleJoined;

        public Team(string name, string creator)
        {
            this.Name = name;
            this.Creator = creator;
            peopleJoined = new List<string>();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(Name);
            sb.AppendLine("- " + Creator);

            foreach (var member in peopleJoined.OrderBy(x => x))
            {
                sb.AppendLine("-- " + member);
            }

            return sb.ToString().TrimEnd();
        }


    }

}