using System;

namespace Bonus_Score
{
    class Program
    {
        static void Main(string[] args)
        {
          int startNumber = int.Parse(Console.ReadLine());
           
            double bonusPoints=0.00;

            if (startNumber<=100)
            {
                bonusPoints = bonusPoints + 5;
            }
            else if (startNumber>100 && startNumber<=1000)
            {
                bonusPoints = startNumber *0.2;
            }
            else if (startNumber>1000)
            {
                bonusPoints = startNumber * 0.1;
            }

            if (startNumber%2==0)
            {
                bonusPoints = bonusPoints + 1;
            }
           else if (startNumber%5==0)
            {
                bonusPoints = bonusPoints + 2;
            }
            Console.WriteLine(bonusPoints);
            Console.WriteLine(bonusPoints+startNumber);

        }
    }
}
