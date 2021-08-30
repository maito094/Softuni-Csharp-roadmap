using System;

namespace _04._Centuries_to_Minutes
{
   class Program
   {
      static void Main(string[] args)
      {

         byte centuries = byte.Parse(Console.ReadLine());
         float oneYearDays = 365.2422f;
         ushort years = (ushort)(100 * centuries);
         int days = (int)(years * oneYearDays);
         int hours = days * 24;
         int minutes = hours * 60;

         Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
      }
   }
}
