﻿using System;
using System.Collections.Generic;
using System.Text;
using DefiningClasses;
namespace DefiningClasses
{
   public class Person
   {
      public Person()
      {
         Name = "No name";
         Age = 1;
      }
      public Person(int age)
      {
         Name = "No name";
         Age = age;
      }
      public Person(string name, int age)
      {
         Name = name;
         Age = age;
      }
      private string name;
      private int age;

      public string Name
      {
         get
         {
            return name;
         }
         set
         {
            name = value;
         }
      }

      public int Age
      {
         get
         {
            return age;
         }

         set
         {
            age = value;
         }
      }
   }
}
