using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial_1
{
    class Student
    {
        public string name;
        public string major;
        public double gpa;

        public Student(string aName, string aMajor, double aGpa)
        {
            name = aName;
            major = aMajor;
            gpa = aGpa;

        }

        public bool HasHonors() //Method Allows to define different rules for all the Objects
        {
            if (gpa>=2.5)       //3.5    
            {
                return true;
            }
            return false;

        }
    }
}
