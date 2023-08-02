/*
// Two pieces of data are being stored for each object.  
// RName is the restaurant name.  To show the difference in how values can be stored,
// RName will be an instance variable.
// RRating is the restaurant rating.  To show the difference in how values can be stored,
// RRating will be an automatic property.
*/

using System;

namespace restaurantAPP
{
    class Restaurant
    {
        // variables
        // ========================================================
        // This is a 'instance' variable example.
        private string RName;  // restaurant name

        // This is the automatic 'property' variable example.  This auto creates get and set methods().
        public int RRating  // property
        { get; set; }


        // constructors
        // ========================================================
        // This is the 'default' constructor when no values are being passed.
        public Restaurant()
        {
            RName = null;
            RRating = -1;
        }

        // This is the 'parameter' constructor when two values are passed.
        public Restaurant(string newRestaurant, int newRating)
        {
            RName = newRestaurant;
            RRating = newRating;
        }

        // methods
        // ========================================================
        //  Since RName is NOT defined as a property variable, we need to create the get and set mehtods() for it.
        public string getName()
        {
            return RName;
        }
        public void setName(string newName)
        {
            RName = newName;
        }

        // This ToString() override so an object can be printed out with the WriteLine.
        public override string ToString()
        {
            return "Restaurant: " + RName + ":  Rating: " + RRating;
        }

    }// class Restaurant
}// namespace restaurantAPP 