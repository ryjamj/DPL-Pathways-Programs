/*
Program Name:
Last Updated:
Program Description:

Requirements:
1-

Algorithm:
1 -

*/

using System;
namespace OOPInheritanceSpace
{
    class FastfoodRestaurant : FoodService
    {
        // variables
        // =================================================
        // propertry approach
        public bool HasFries { get; set; }

        // constructors
        // =================================================
        // // This is the 'default' constructor
        public FastfoodRestaurant() : base()
        {
            HasFries = false;
        }

        // This is the 'parameter' constructor when parameters are passed in
        public FastfoodRestaurant(string newName, string newRaiting, string newEstCost, string newTimeOpen, string newTimeClose, bool newHasFries) : base(newName, newRaiting, newEstCost, newTimeOpen, newTimeClose)
        {
            HasFries = newHasFries;
        }

        // methods
        // =================================================
        public void checkForFriest()
        {
            Console.WriteLine($"'{Name}' has fries: '{HasFries}'.");
        }

        // This ToString() override so an object can be printed out with the WriteLine.
        public override string ToString()
        {
            return ($"FastfoodRestaurant Class (Name: {Name}, Rating: {Raiting}, EstCost: {EstCost}, TimeOpen: {TimeOpen}, TimeClose: {TimeClose})");
        }

    }// end class
}// end namespace