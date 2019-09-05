using System.Collections.Generic;

namespace EssentialTraining
{ 
    // Simple string list class. 
    public class MyList
    {
        public List<string> Elements;

        // Constructs a MyList of given size. 
        public MyList(int size)
        {
            Elements = new List<string>(size); 
        }

        // Returns false if Elements is not empty, and true if it is.
        public bool IsEmpty()
        {
            if (Elements.Count == 0)
            {
                return true; 
            }
            else
            {
                return false; 
            }
        }

        // Adds given string to Elements. 
        public void Add(string str)
        {
            Elements.Add(str);
        }
    }
}