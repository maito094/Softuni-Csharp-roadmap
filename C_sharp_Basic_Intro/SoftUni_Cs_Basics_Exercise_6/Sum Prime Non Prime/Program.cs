using System;

namespace Sum_Prime_Non_Prime
{
   class Program
   {
      static void Main(string[] args)
      {
         string number = Console.ReadLine();
         int sumPrime = 0;
         int sumNonPrime = 0;

         while (number != "stop")
         {
            int num = int.Parse(number);
            if (num < 0)
            {
               Console.WriteLine("Number is negative.");
               number = Console.ReadLine();
               continue;
            }
            else if (num>3 &&(num%2==0 || num%3==0))
            {
               sumNonPrime += num;
            }
            else
            {
               sumPrime += num;
            }
            number = Console.ReadLine();
         }
         Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
         Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
      }
   }
}
