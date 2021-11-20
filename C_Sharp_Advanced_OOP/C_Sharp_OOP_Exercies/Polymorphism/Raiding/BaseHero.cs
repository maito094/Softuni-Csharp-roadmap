using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding
{
   public abstract class BaseHero
   {

      protected BaseHero(string name)
      {
         Name = name;
      }


      public string Name { get; set; }

      public virtual int Power { get;}


      public abstract string CastAbility();

   }
}
