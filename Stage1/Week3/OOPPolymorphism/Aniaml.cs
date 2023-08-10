/*
Program Name: OOPPolymorphism
Last Updated: 08/02/2023
Program Description: Pratice Polymorphism in C#

Requirements:
1-

Algorithm:
1 -

*/

using System;
namespace OOPPolymorphism
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
        // this will be a 'virtual' method in our base class.
        public virtual void animalSound()
        {
            Console.WriteLine("\"The animal makes a sound\".");
        }

        // ToString() override so an object can be printed out with the WriteLine.
        public override string ToString()
        {
            return ($"Animal Class (Species: {Species}, Name: {Name}, Rating: {Raiting})");
        }

    }// end class
}// end namespace  