using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial_1
{     // Template
    class Book  //Like a Blueprint for our custom DataType (Complex datatype). It defines the Specification
    {   //Defining Attributes to the Class
        public string title;    // Class Attributes
        public string author;
        public int pages;

        public Book(string name)   // Constructor of the Class , whenever it is called by Public and the Name of the class
        {   // This Method will be Called Everytime an Instance of the Class Book is created (Object)
            Console.WriteLine(name);
        }
    }
}
