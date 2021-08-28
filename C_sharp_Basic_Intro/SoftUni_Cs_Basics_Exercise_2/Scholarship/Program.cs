using System;

namespace Scholarship
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());
            double minimumWage = double.Parse(Console.ReadLine());

            double socialScholarship = 0;
            double excellentScholarship = 0;

            bool isSocialApproved=false;
            bool isExcellentApproved=false;
           
            if (grade>4.5 && income <minimumWage)
            {
                socialScholarship = minimumWage*0.35;
                isSocialApproved = true;

            }
            if (grade>=5.5)
            {
                excellentScholarship = grade * 25;
                isExcellentApproved = true;
            }

            if (!isSocialApproved && !isExcellentApproved)
            {
                Console.WriteLine("You cannot get a scholarship!");

            }
            else if (isExcellentApproved && excellentScholarship >= socialScholarship)
            {
                Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excellentScholarship)} BGN");

            }
            else if (isSocialApproved && excellentScholarship < socialScholarship)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");

            }





        }
    }
}
