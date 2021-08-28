using System;

namespace ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int numProjects=int.Parse(Console.ReadLine());
            int numHours = numProjects * 3;

            Console.WriteLine($"The architect {name} will need {numHours} hours to complete {numProjects} project/s.");
        }
    }
}
