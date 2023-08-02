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
    class FancyRestaurant : FoodService
    {
        // variables
        // =================================================
        // propertry approach
        public bool HasDressCode { get; set; }
        public int CostPerPlate { get; set; }

        // constructors
        // =================================================
        // // This is the 'default' constructor
        public FancyRestaurant() : base()
        {
            HasDressCode = false;
            CostPerPlate = 0;
        }

        // This is the 'parameter' constructor when parameters are passed in
        public FancyRestaurant(string newName, string newRaiting, string newEstCost, string newTimeOpen, string newTimeClose, bool newHasDressCode, int newCostPerPlate) : base(newName, newRaiting, newEstCost, newTimeOpen, newTimeClose)
        {
            HasDressCode = newHasDressCode;
            CostPerPlate = newCostPerPlate;
        }

        // methods
        // =================================================
        public void checkForFriest()
        {
            Console.WriteLine($"'{Name}' has a dress code: '{HasDressCode}'.");
        }

        public void checkCostofPlate()
        {
            Console.WriteLine($"'{Name}' has a cost per plate of: '${CostPerPlate}'.");
        }

        // This ToString() override so an object can be printed out with the WriteLine.
        public override string ToString()
        {
             return ($"FancyRestaurant Class (Name: {Name}, Rating: {Raiting}, EstCost: {EstCost}, TimeOpen: {TimeOpen}, TimeClose: {TimeClose})");
        }

    }// end class
}// end namespace  