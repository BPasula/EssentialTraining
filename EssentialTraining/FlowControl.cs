using System;
using System.Collections.Generic;
using System.Text;

namespace EssentialTraining
{ 
    // Simple class to illustrate control flow in C#.
    class FlowControl
    { 
        // Returns true if given string is "green", false otherwise. Capitalization does not matter since
        // the given string is switched to lower case, if needed. 
        public bool FavouriteColour(string colour)
        {
            return (colour.ToLower() == "green");
        }

        // Returns "Can we call you Bruce for the sake of simplicity?" if the given name is not Bruce, or 
        // "G'day Bruce." if it is. Based on a Monty Python sketch. Capitalization does not matter. 
        public string IsYourNameNotBruce(string name)
        {
            return (name.ToLower() != "bruce") ? "Can we call you Bruce for the sake of simplicity?" : "G'day Bruce."; 
        }
    }
}
