/*
Program Name: OOPInterface
Last Updated: 08/08/2023
Program Description: Pratice interface in C#

Requirements:
1-

Algorithm:
1 -

*/

using System;
namespace OOPInterface
{
    class Animal

    {
        // variables
        // =================================================
        // propertry approach
        public string Species { get; set; }
        public string Name { get; set; }
        public string Raiting { get; set; }

        // constructors
        // =================================================
        // This is the 'default' constructor
        public Animal()
        {
            Species = null;
            Name = null;
            Raiting = null;
        }
        // This is the 'parameter' constructor when parameters are passed in
        public Animal(string newSpecies, string newName, string newRaiting)
        {
            Species = newSpecies;
            Name = newName;
            Raiting = newRaiting;
        }

        // methods
        // =================================================
        // ToString() override so an object can be printed out with the WriteLine.
        public override string ToString()
        {
            return ($"Species: {Species} | Name: {Name} |  Rating: {Raiting}");
        }

    }// end class
}// end namespace  