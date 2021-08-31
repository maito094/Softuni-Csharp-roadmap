using System;
using System.Linq;

namespace _09._Kamino_Factory
{
   class Program
   {
      static void Main(string[] args)
      {
         int n = int.Parse(Console.ReadLine());

         string cmd = Console.ReadLine();

         int maxSequence = 0;
         int currSequence = 1;

         int DNAsample = 0;
         int sumOnes = 0;
         int currBestIndex = 0;

         int[] bestSequence = new int[n];
         int currentMaxSequence = 0;
         int currBestIndexSequence = int.MaxValue;

         while (cmd != "Clone them!")
         {

            int[] number = cmd.Split('!').Select(int.Parse).ToArray();

            for (int i = 0; i < n - 1; i++)
            {
               if (number[i] == 1 && 1 == number[i + 1])
               {
                  currBestIndex = i;
                  currSequence++;
               }
               else
               {
                  currSequence = 1;
               }
               if (currSequence > maxSequence)
               {

                  maxSequence = currSequence;

               }

               //Best sequence HAS the Greatest maxSequence or Lesser Index or the  or the Most Ones(sum of it)
            }

            if (maxSequence > currentMaxSequence)  //Priority 1
            {
               currentMaxSequence = maxSequence;
               bestSequence = number;


            }
            if (currBestIndexSequence > currBestIndex) //Priority 2
            {

               bestSequence = number;
               currBestIndexSequence = currBestIndex;
               DNAsample++;
            }


            cmd = Console.ReadLine();
         }
         foreach (var num in bestSequence)
         {
            if (num == 1)
            {
               sumOnes++;
            }
         }


         Console.WriteLine($"Best DNA sample {DNAsample} with sum: {sumOnes}.");
         Console.WriteLine(string.Join(' ', bestSequence));

      }
   }
}

