﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
   public class StartUp
   {
      public static void Main(string[] args)
      {
         string firstDate = Console.ReadLine();
         string secondDate = Console.ReadLine();

         string daysOffset = DateModifier.CalculateDaysOffset(firstDate, secondDate);

         Console.WriteLine(daysOffset);
      }
   }
}
