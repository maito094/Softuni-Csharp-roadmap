﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Wild_Farm.Food
{
   public abstract class Food : IFood
   {

      protected Food(int quantity)
      {
         Quantity = quantity;
      }
      public int Quantity { get; set; }
   }
}
