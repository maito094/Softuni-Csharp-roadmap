using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial_1
{
    class Movie
    {   // Class Attributes 
        public string title;        // public = Open to everyone to access
        public string director;                        
        private string rating;      // private = Only access is inside this Movie Class Code Block

        public Movie(string aTitle, string aDirector, string aRating)   // Constructor of the Class , whenever it is called by Public and the Name of the class
        {   // This Method will be Called Everytime an Instance of the Class Book is created (Object)
            title = aTitle;
            director = aDirector;
            Rating = aRating;       //  rating = aRating; removing "rating" so it is better secured

        }

        public string Rating
        {
            get { return rating; }     // Is to Get the "rating" attribute
            set {                      // "value" is the value that outside class code passes through
                if (value == "G" || value == "PG" || value=="PG-13" || value=="R" || value=="NR")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }

    }
}
