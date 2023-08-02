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
    class FoodService
    {
        // variables
        // =================================================
        // propertry approach
        public string Name { get; set; }
        public string Raiting { get; set; }
        public string EstCost { get; set; }
        public string TimeOpen { get; set; }
        public string TimeClose { get; set; }


        // constructors
        // =================================================
        // This is the 'default' constructor
        public FoodService()
        {
            Name = null;
            Raiting = null;
            EstCost = null;
            TimeOpen = null;
            TimeClose = null;
        }
        // This is the 'parameter' constructor when parameters are passed in
        public FoodService(string newName, string newRaiting, string newEstCost, string newTimeOpen, string newTimeClose)
        {
            Name = newName;
            Raiting = newRaiting;
            EstCost = newEstCost;
            TimeOpen = newTimeOpen;
            TimeClose = newTimeClose;
        }


        // methods
        // =================================================
        public void HoursOperation()
        {
            Console.WriteLine($"I am open at '{TimeOpen}' and I close at '{TimeClose}'.");
        }

        // This ToString() override so an object can be printed out with the WriteLine.
        public override string ToString()
        {
            return ($"FoodService Class (Name: {Name}, Rating: {Raiting}, EstCost: {EstCost}, TimeOpen: {TimeOpen}, TimeClose: {TimeClose})");
        }

    }// end class
}// end namespace  