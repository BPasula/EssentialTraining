using System;
using System.Reflection;

namespace EssentialTraining
{ 
    // Simple string array class. 
    public class SimpleArray
    {
        public string[] GroceryList;

        // Constructs a SimpleArray of given size.
        public SimpleArray(int size)
        {
            GroceryList = new string[size];
        }

        // Prints out the contents of Grocery List in the format "There are [GroceryList.Length] items and they are
        // [Item1, Item2, Item3, etc.]." 
        public override string ToString()
        {
            return String.Format("There are {0:D} items and they are {1}.", GroceryList.Length, GroceryList);
        }

        // Adds given string at the given index. 
        public void Add(string str, int index)
        {
            GroceryList[index] = str; 
        }

        // Returns the item at the given index. 
        public string Get(int index)
        {
            return GroceryList[index]; 
        }
    }
}