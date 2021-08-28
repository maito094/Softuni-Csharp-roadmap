using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int nTabs = int.Parse(Console.ReadLine());
            int Salary = int.Parse(Console.ReadLine());

            for (int i = 1; i <= nTabs; i++)
            {


                string website = Console.ReadLine();

                switch (website)
                {
                    case "Facebook":
                        Salary -= 150;
                        break;
                    case "Instagram":
                        Salary -= 100;
                        break;
                    case "Reddit":
                        Salary -= 50;
                        break;

                    default:
                        break;
                }
                if (i == nTabs && Salary > 0)
                {
                    Console.WriteLine(Salary);
                }

                else if (Salary <= 0)
                {


                    Console.WriteLine("You have lost your salary.");
                    break;
                }


            }
        }
    }
}
