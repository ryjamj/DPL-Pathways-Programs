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
    class Fish : Animal, IAnimalSound, IBellyRubs
    {
        // variables
        // =================================================
        // propertry approach
        public bool CanSwim { get; set; }

        // constructors
        // =================================================
        // // This is the 'default' constructor
        public Fish() : base()
        {
            CanSwim = true;
        }

        // This is the 'parameter' constructor when parameters are passed in
        public Fish(string newSpecies, string newName, string newRaiting, bool newCanSwim) : base(newSpecies, newName, newRaiting)
        {
            CanSwim = newCanSwim;
        }

        // methods
        // =================================================
        // override methods() for Polymorphism.
        public string animalSound()
        {
            return ($"\"The {Species} {Name} says:... nothings, it's a {Species}\".");
        }

        // this will be a inherited method from the interface
        public string wantsBellyRubs()
        {
            return ($"\"{Name} does not want belly rubs, because it's a {Species}\".");
        }

        // This ToString() override so an object can be printed out with the WriteLine.
        public override string ToString()
        {
            return ($"{base.ToString()} |  CanSwim: {CanSwim} | AnimalSound: {animalSound()} | wantsBellyRubs: {wantsBellyRubs()}");
        }

    }// end class
}// end namespace