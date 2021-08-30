using System;
using System.Numerics;
namespace _11._Snowballs
{
   class Program
   {
      static void Main(string[] args)
      {
         int n = int.Parse(Console.ReadLine());
         int largestSnowball = 0;
         int largestSnowballTime = 0;
         int largestSnowballQuality = 0;
         BigInteger largestSnowballValue = 0;
         for (int i = 0; i < n; i++)
         {
            int snowballSnow = int.Parse(Console.ReadLine());
            int snowballTime = int.Parse(Console.ReadLine());
            int snowballQuality = int.Parse(Console.ReadLine());

            BigInteger snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
            if (snowballValue >= largestSnowballValue)
            {
               largestSnowballValue = snowballValue;
               largestSnowball = snowballSnow;
               largestSnowballTime = snowballTime;
               largestSnowballQuality = snowballQuality;
            }
         }
         Console.WriteLine($"{ largestSnowball} : { largestSnowballTime} = { largestSnowballValue} ({largestSnowballQuality})");
      }
   }
}
