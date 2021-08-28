using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tutorial_1
{
    class Song
    {
        //Defining Attributes to the Class
        public string title;    // Class Attributes
        public string artist;
        public int duration;
        public static int songCount = 0;    // Specific Attribute about the Class, not the Objects of the Class

        public Song(string aTitle, string aArtist, int aDuration)   // Constructor of the Class , whenever it is called by Public and the Name of the class
        {   // This Method will be Called Everytime an Instance of the Class Book is created (Object)
            title = aTitle;
            artist = aArtist;
            duration = aDuration;
            songCount++;        // Very Useful to know the number of created objects of this class

            
        }

        public int getSongCount()
        {
            return songCount;

        }
    }
}
