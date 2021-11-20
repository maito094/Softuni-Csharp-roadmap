﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
   public class Robot : IIdentifiable
   {
      public Robot(string id, string model)
      {
         Id = id;
         Model = model;
      }

      public string Id { get; set; }

      public string Model { get; set; }
   }
}
