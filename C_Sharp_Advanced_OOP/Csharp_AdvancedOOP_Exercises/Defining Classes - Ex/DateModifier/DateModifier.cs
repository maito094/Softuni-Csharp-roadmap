using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
   public class DateModifier
   {

      public static string CalculateDaysOffset(string date1, string date2)
      {

         DateTime dateTime1 = DateTime.Parse(date1);
         DateTime dateTime2 = DateTime.Parse(date2);

         TimeSpan dateTimeOffset = dateTime1 - dateTime2;

         return Math.Abs(dateTimeOffset.Days).ToString();
      }
   }
}
