using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes
{
  public abstract class MyValidationAttribute : Attribute
   {
      public MyValidationAttribute()
      {
      }

      public abstract bool IsValid(object obj);
   }
}
