using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace TeamWorkProject_with_object
{
    class Program
    {
        public class Team
        {
            public string Creator { get; set; }
            public List<string> Members { get; set; }

            public string TeamName { get; set; }

            public Team()
            {
                Members = new List<string>();
            }
        }
        static void Main(string[] args)
        {
            List<Team> teamsList = new List<Team>();
          
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] createTeams = Console.ReadLine().Split('-');
                string creator = createTeams[0];
                string createTeam = createTeams[1];

                if (teamsList.Any(a => a.TeamName == createTeam))
                {
                    Console.WriteLine($"Team {createTeam} was already created!");
                    continue;
                }
                else if (teamsList.Any(a => a.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                    continue;
                }
                else
                {
                    Team createdTeam = new Team();
                    createdTeam.Creator = creator;
                    createdTeam.TeamName = createTeam;
                    teamsList.Add(createdTeam);                  
                    Console.WriteLine($"Team {createTeam} has been created by {creator}!");
                } 
            }

            while (true)
            {
                string tryToAddMembers = Console.ReadLine();
                if (tryToAddMembers == "end of assignment")
                {
                    break;
                }

                string[] addMembers = tryToAddMembers.Split(new string[] {"->"}, StringSplitOptions.RemoveEmptyEntries);
                string candidateForMember = addMembers[0];
                string wantedTeam = addMembers[1];

                if (teamsList.All( a=> a.TeamName != wantedTeam))
                {
                    Console.WriteLine($"Team {wantedTeam} does not exist!");
                    continue;
                }
                if (teamsList.Any(a=>a.Creator == candidateForMember) || teamsList.Any(x =>x.Members.Contains(candidateForMember)))
                {
                    Console.WriteLine($"Member {candidateForMember} cannot join team {wantedTeam}!");
                    continue;
                }

                int teamToJointInex = teamsList.FindIndex(a => a.TeamName == wantedTeam);
                teamsList[teamToJointInex].Members.Add(candidateForMember);
            }
            teamsList = teamsList.OrderByDescending(a => a.Members.Count).ThenBy(a => a.TeamName).ToList();

            foreach (Team currentTeam in teamsList)
            {
                if (currentTeam.Members.Count > 0)
                {
                    Console.WriteLine($"{currentTeam.TeamName}");
                    Console.WriteLine($"- {currentTeam.Creator}");

                    foreach (var member in currentTeam.Members.OrderBy(a=>a))
                    {
                        Console.WriteLine($"-- {member}");
                    }
                }
            }
            Console.WriteLine("Teams to disband:");
            foreach (var team in teamsList.OrderBy(a =>a.TeamName))
            {
                if (team.Members.Count == 0 )
                {
                    Console.WriteLine($"{team.TeamName}");
                }
            }
        }
    }
}
