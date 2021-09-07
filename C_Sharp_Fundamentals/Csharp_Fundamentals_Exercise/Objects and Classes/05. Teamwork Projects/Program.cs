using System;
using System.Collections.Generic;
using System.Linq;


namespace _05.Teamwork_Projects
{
   class Program
   {
      static void Main(string[] args)
      {

         List<TeamCreation> teams = new List<TeamCreation>();

         int cntTeams = int.Parse(Console.ReadLine());

         for (int i = 0; i < cntTeams; i++)
         {
            string inputData = Console.ReadLine();

            string[] createTeam = inputData.Split("-", StringSplitOptions.RemoveEmptyEntries);

            TeamCreation currentTeam = new TeamCreation(createTeam[0], createTeam[1]);

            if (teams.Any(s => s.Team == currentTeam.Team))
            {
               Console.WriteLine($"Team {currentTeam.Team} was already created!");
            }
            else if (teams.Any(s => s.Creator == currentTeam.Creator))
            {
               Console.WriteLine($"{currentTeam.Creator} cannot create another team!");
            }
            else
            {
               teams.Add(currentTeam);
               Console.WriteLine($"Team {currentTeam.Team} has been created by {currentTeam.Creator}!");

            }
         }

         string inputUser = Console.ReadLine();
         while (inputUser != "end of assignment")
         {
            string[] inputMember = inputUser.Split("->");
            int teamIndex = teams.FindIndex(s => s.Team == inputMember[1]);

            if (teamIndex == -1)
            {
               Console.WriteLine($"Team {inputMember[1]} does not exist!");
            }
            else if (isExistingMember(ref teams, inputMember[0]))
            {

               Console.WriteLine($"Member {inputMember[0]} cannot join team {teams[teamIndex].Team}!");
            }
            else
            {

               teams[teamIndex].Member.Add((inputMember[0]));

            }

            inputUser = Console.ReadLine();
         }

         List<TeamCreation> disbanded = new List<TeamCreation>();
         disbanded = teams.Where(t => t.Member.Count == 0).OrderBy(t => t.Team).ToList();
         teams.RemoveAll(t => t.Member.Count == 0);
         teams = teams.OrderByDescending(t => t.Member.Count).ThenBy(t => t.Team).ToList();

         //teams = teams.OrderByDescending(o => o.Member.Count).ToList();

         for (int i = 0; i < teams.Count; i++)
         {
            if (teams[i].Member.Count > 0)
            {

               Console.WriteLine(teams[i].Team);
               Console.WriteLine($"- {teams[i].Creator}");
               teams[i].Member = teams[i].Member.OrderBy(o => o).ToList();
               for (int j = 0; j < teams[i].Member.Count; j++)
               {
                  Console.WriteLine($"-- {teams[i].Member[j]}");
               }
            }

         }

         Console.WriteLine("Teams to disband:");
         foreach (var team in disbanded)
         {
            Console.WriteLine(team.Team);
         }

      }

      public static bool isExistingMember(ref List<TeamCreation> teams, string memberName)
      {
         foreach (var user in teams.Select(s => s.Creator))
         {
            if (user is null || user == string.Empty)
            {
               continue;
            }

            if (user == memberName)
            {
               return true;
            }
         }

         foreach (var members in teams.Select(s => s.Member))
         {
            if (members is null || members.Count == 0)
            {
               continue;
            }
            foreach (var member in members)
            {

               if (memberName == member)
               {
                  return true;
               }
            }
         }

         return false;
      }
   }

   class TeamCreation
   {
      public string Creator { get; set; }
      public string Team { get; set; }
      public List<string> Member { get; set; }

      public TeamCreation(string user, string team)
      {
         Creator = user;
         Team = team;
         Member = new List<string>();
      }
   }
}
