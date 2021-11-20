﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm
{
   public class Box
   {

      private double length;
      private double width;
      private double height;
      public Box(double length, double width, double height)
      {
         Length = length;
         Width = width;
         Height = height;
      }

      public double Length
      {
         get
         {
            return length;
         }
         private set
         {
            if (value < 0)
            {
               throw new ArgumentException($"{nameof(Length)} cannot be zero or negative.");
            }

            length = value;
         }
      }
      public double Width
      {
         get
         {
            return width;
         }
         private set
         {
            if (value < 0)
            {
               throw new ArgumentException($"{nameof(Width)} cannot be zero or negative.");
            }

            width = value;
         }
      }
      public double Height
      {
         get
         {
            return height;
         }
         private set
         {
            if (value < 0)
            {
               throw new ArgumentException($"{nameof(Height)} cannot be zero or negative.");
            }

            height = value;
         }
      }

      public double SurfaceArea()
      {

         return 2 * ((Width * Length) + (Length * Height) + (Width * Height));
      }

      public double LateralSurfaceArea()
      {

         return 2 * Height * (Length + Width);
      }

      public double Volume()
      {
         return Length * Width * Height;
      }
   }
}
